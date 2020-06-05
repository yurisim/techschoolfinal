/* A1C Sim
 * Revision: BETA 2.0
 * Desc: Manages Room Inspections
 *
 * TODO: Export the Strea
 *
 * TODO: Export failures
 *
 * TODO: Make a form for adding a student that appears in FrmStudentRoom when "add student is clicked:
 *
 * TODO: Make a TODO List
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using RoomInspections.Properties;

namespace RoomInspections
{
	internal sealed partial class FrmRoomInspection : Form
	{
		private const string Str_ConnectionType =
			@"Provider=Microsoft.ACE.OLEDB.16.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited(,)""";

		private readonly string Str_DBFileName = Application.StartupPath + @"\StudentAssignments.xml";

		private readonly DataSet datRoomAssignments = new DataSet();
		private readonly string Str_Checks = Application.StartupPath + @"\Checks.csv";

		private IEnumerable<DataRow> PeopleWhoLiveInBuilding;
		private IEnumerable<DataRow> PeopleWhoLiveInFloor;

		private readonly List<string> strListAutoFails = new List<string>();
		private readonly List<string> strListDemerits = new List<string>();

		internal FrmRoomInspection()
		{
			InitializeComponent();
		}

		private void FrmRoomInspection_Load(object sender, EventArgs e)
		{
			datRoomAssignments.ReadXml(Str_DBFileName, XmlReadMode.ReadSchema);

			datRoomAssignments.Tables["RoomAssignment"].PrimaryKey =
				new[] { datRoomAssignments.Tables["RoomAssignment"].Columns["StudentID"] };

			// The program will crash if any person has an empty inspection date, this fixes this.
			var PeopleWithNoInspectionDates = datRoomAssignments.Tables["RoomAssignment"].AsEnumerable()
				.Where(Person => DBNull.Value.Equals(Person["InspectionDate"]));

			foreach (DataRow Person in PeopleWithNoInspectionDates)
			{
				Person["InspectionDate"] = 1;
			}

			// This nabs the buildings that appear to be on the list
			var objArrayBuildings = datRoomAssignments.Tables["RoomAssignment"]
				.AsEnumerable()
				.Select(rowEntry => rowEntry["Room"].ToString()[0])
				.Distinct();

			foreach (char chrBuildingLetter in objArrayBuildings)
			{
				cboBuilding.Items.Add(chrBuildingLetter);
			}

			// Change the building Selected Index to the First one, this should trigger another
			// methods that occurs when the selected index of the cboBuilding changes, which
			// populates floors.
			cboBuilding.SelectedIndex = 0;

			// POPULATE AUTO FAIL AND DEMERIT LISTS
			string strConnection = string.Format(Str_ConnectionType, Application.StartupPath);
			using (var ConnectToDemerits = new OleDbConnection(strConnection))
			{
				string strQuery = $"SELECT * FROM {Path.GetFileName(Str_Checks)}";
				var dataAdapter = new OleDbDataAdapter(strQuery, ConnectToDemerits);
				dataAdapter.Fill(datRoomAssignments, "AutoFailuresAndDemerits");
			}

			// Get Auto fails
			var AutoFails = datRoomAssignments.Tables["AutoFailuresAndDemerits"]
				.AsEnumerable()
				.Select(AutoFailEntry => AutoFailEntry["Auto Failures"].ToString())
				.Where(AutoFailEntry => !string.IsNullOrEmpty(AutoFailEntry));

			strListAutoFails.AddRange(AutoFails.ToArray());

			// Get Demerits
			var Demerits = datRoomAssignments.Tables["AutoFailuresAndDemerits"]
				.AsEnumerable()
				.Select(DemeritEntry => DemeritEntry["Demerits"].ToString())
				.Where(DemeritEntries => !string.IsNullOrEmpty(DemeritEntries));

			strListDemerits.AddRange(Demerits.ToArray());
		}

		/// <summary>
		/// Edits the floors with names.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CboBuilding_SelectedIndexChanged(object sender, EventArgs e)
		{
			PeopleWhoLiveInBuilding = datRoomAssignments.Tables["RoomAssignment"].AsEnumerable()
				// Find the people who live in the building
				.Where(Person => Person["Room"].ToString()[0] == cboBuilding.SelectedItem.ToString()[0]);

			// Of the people who live inside the building, find the floors they live in
			var chrOccupiedFloors = PeopleWhoLiveInBuilding
				// and SELECT the floor they are living in
				.Select(Person => Person["Room"].ToString()[2])
				.Distinct();

			// Populates Floors CBO with floors that are occupied
			cboFloor.Items.Clear();
			foreach (char floors in chrOccupiedFloors)
			{
				cboFloor.Items.Add(floors);
			}

			cboFloor.SelectedIndex = 0;
		}

		private void CboFloor_SelectedIndexChanged(object sender, EventArgs e)
		{
			//  Formats Header for the group box
			grpFloorPlan.Text = string.Format(Resources.BuildingFloor,
				cboBuilding.SelectedItem,
				cboFloor.SelectedItem);

			// Resets Room Colors
			ChangeButtonColors(grpFloorPlan.Controls.OfType<Button>(), btnEmpty.BackColor);

			// Gets the List of people who live in a Floor
			PeopleWhoLiveInFloor = PeopleWhoLiveInBuilding
				.Where(Person => Person["Room"].ToString()[2] == cboFloor.SelectedItem.ToString()[0]);

			// Changes the Tags of each "Room" on the Floor Layout,
			// Turns a xAy00 --> SA100
			ChangeButtonFloorTags(cboBuilding.SelectedItem.ToString(),
				cboFloor.SelectedItem.ToString());

			InspectionStateToColor();
		}

		/// <summary>
		/// Changes the colors of buttons based on inspection state
		/// </summary>
		private void InspectionStateToColor()
		{
			//ROOMS THAT PASSED INSPECTION
			var SafeRooms = PeopleWhoLiveInFloor
				.Where(Person => Person["Pass"].ToString() == "T")
				.Select(Person => Person["Room"].ToString());

			var ButtonsOfSafeRooms = grpFloorPlan.Controls.OfType<Button>()
				.Where(btnButton => SafeRooms.Contains(btnButton.Tag.ToString()));

			ChangeButtonColors(ButtonsOfSafeRooms, btnPassed.BackColor);

			// ROOMS THAT FAILED INSPECTION
			var FailRooms = PeopleWhoLiveInFloor
				.Where(Person => Person["Pass"].ToString() == "F")
				.Select(Person => Person["Room"].ToString());

			var ButtonsOfFailRooms = grpFloorPlan.Controls.OfType<Button>()
				.Where(btnButton => FailRooms.Contains(btnButton.Tag.ToString()));

			ChangeButtonColors(ButtonsOfFailRooms, btnFailed.BackColor);

			// ROOMS THAT NEED TO BE INSPECTED
			double dblDateToday = DateTime.Today.ToOADate();

			var RoomsToInspect = PeopleWhoLiveInFloor
				.Where(Person => Convert.ToDouble(Person["InspectionDate"]) + Convert.ToDouble(txtMaskInterval.Text) <= dblDateToday)
				.Select(Person => Person["Room"].ToString());

			// Get the Buttons where the tag on that button is contained in the list
			// of rooms to inspect
			var ButtonsOfRoomsToInspect = grpFloorPlan.Controls.OfType<Button>()
				.Where(btnButton => RoomsToInspect.Contains(btnButton.Tag.ToString()));

			ChangeButtonColors(ButtonsOfRoomsToInspect, btnNeeded.BackColor);
		}

		/// <summary>
		/// </summary>
		/// <param name="chrBuilding"></param>
		/// <param name="chrFloor"></param>
		private void ChangeButtonFloorTags(string chrBuilding, string chrFloor)
		{
			var btnRoomsOnFloor = grpFloorPlan.Controls.OfType<Button>();

			foreach (Button btnEachRoom in btnRoomsOnFloor)
			{
				btnEachRoom.Tag = btnEachRoom.Tag.ToString()
					.Remove(0, 1)
					.Insert(0, chrBuilding)
					.Remove(2, 1)
					.Insert(2, chrFloor);
			}
		}

		private void ChangeButtonColors(IEnumerable<Button> SeqButtons, Color clrButton)
		{
			foreach (Button btnButton in SeqButtons)
			{
				btnButton.BackColor = clrButton;
			}
		}

		private void DaysBetweenInspection_TextChanged(object sender, EventArgs e)
		{
			// Need to make sure it's not empty, otherwise program crashes :D
			if (!string.IsNullOrEmpty(txtMaskInterval.Text))
			{
				InspectionStateToColor();
			}
		}

		private void BtnRoom_Click(object sender, EventArgs e)
		{
			string strTag = (sender as Button).Tag.ToString();

			var PeopleInRoom = PeopleWhoLiveInFloor
				.Where(Person => Person["Room"].ToString() == strTag)
				.ToList();

			var DisplayRoom = new FrmStudentRoom(strListAutoFails, strListDemerits, PeopleInRoom, strTag);

			DisplayRoom.ShowDialog();

			InspectionStateToColor();

			SaveStuff();
		}

		/// <summary>
		/// This currently isn't working because I'm a bad programmer :D
		/// </summary>
		private void SaveStuff()
		{
			try
			{
				using (var StudentDataWriter = new XmlTextWriter(Str_DBFileName, null))
				{
					datRoomAssignments.Tables["RoomAssignment"].WriteXml(StudentDataWriter, 0);
				}
			}
			catch
			{
				MessageBox.Show(
					Resources.ErrorWithSaving,
					Resources.FrmRoomInspection_SaveStuff_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}