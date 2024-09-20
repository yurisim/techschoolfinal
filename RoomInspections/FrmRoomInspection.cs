/* A1C Sim
 * Revision: BETA 2.0
 * Desc: Manages Room Inspections
 */

using System;
using System.Collections.Generic;
using System.Data;
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

            // The program will crash if any person has an empty inspection date; this fixes it.
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
            // method that occurs when the selected index of the cboBuilding changes, which
            // populates floors.
            if (cboBuilding.Items.Count > 0)
            {
                cboBuilding.SelectedIndex = 0;
            }

            // POPULATE AUTO FAIL AND DEMERIT LISTS
            // Read the CSV file directly
            if (File.Exists(Str_Checks))
            {
                try
                {
                    string[] lines = File.ReadAllLines(Str_Checks);

                    if (lines.Length > 0)
                    {
                        // Assuming the first line is the header
                        string headerLine = lines[0];
                        string[] headers = headerLine.Split(',');

                        int autoFailIndex = Array.IndexOf(headers, "Auto Failures");
                        int demeritIndex = Array.IndexOf(headers, "Demerits");

                        if (autoFailIndex == -1 || demeritIndex == -1)
                        {
                            // Handle error: columns not found
                            MessageBox.Show("The required columns 'Auto Failures' and 'Demerits' are not present in the CSV file.");
                        }
                        else
                        {
                            for (int i = 1; i < lines.Length; i++)
                            {
                                // Skip empty lines
                                if (string.IsNullOrWhiteSpace(lines[i]))
                                    continue;

                                string[] fields = lines[i].Split(',');

                                // Handle cases where fields may contain commas within quotes
                                fields = ParseCsvLine(lines[i]);

                                if (fields.Length > autoFailIndex)
                                {
                                    string autoFailEntry = fields[autoFailIndex].Trim();
                                    if (!string.IsNullOrEmpty(autoFailEntry))
                                    {
                                        strListAutoFails.Add(autoFailEntry);
                                    }
                                }

                                if (fields.Length > demeritIndex)
                                {
                                    string demeritEntry = fields[demeritIndex].Trim();
                                    if (!string.IsNullOrEmpty(demeritEntry))
                                    {
                                        strListDemerits.Add(demeritEntry);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while reading the CSV file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"The file {Str_Checks} does not exist.");
            }
        }

        /// <summary>
        /// Parses a CSV line, handling commas within quoted fields.
        /// </summary>
        private string[] ParseCsvLine(string line)
        {
            var fields = new List<string>();
            bool inQuotes = false;
            string field = "";

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"' && (i == 0 || line[i - 1] != '\\'))
                {
                    inQuotes = !inQuotes;
                }
                else if (c == ',' && !inQuotes)
                {
                    fields.Add(field);
                    field = "";
                }
                else
                {
                    field += c;
                }
            }

            fields.Add(field);
            return fields.ToArray();
        }

        /// <summary>
        /// Edits the floors with names.
        /// </summary>
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

            // Populates Floors ComboBox with floors that are occupied
            cboFloor.Items.Clear();
            foreach (char floor in chrOccupiedFloors)
            {
                cboFloor.Items.Add(floor);
            }

            if (cboFloor.Items.Count > 0)
            {
                cboFloor.SelectedIndex = 0;
            }
        }

        private void CboFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Formats Header for the group box
            grpFloorPlan.Text = string.Format(Resources.BuildingFloor,
                cboBuilding.SelectedItem,
                cboFloor.SelectedItem);

            // Resets Room Colors
            ChangeButtonColors(grpFloorPlan.Controls.OfType<Button>(), btnEmpty.BackColor);

            // Gets the list of people who live on a floor
            PeopleWhoLiveInFloor = PeopleWhoLiveInBuilding
                .Where(Person => Person["Room"].ToString()[2] == cboFloor.SelectedItem.ToString()[0]);

            // Changes the tags of each "Room" on the Floor Layout,
            // e.g., turns xAy00 --> SA100
            ChangeButtonFloorTags(cboBuilding.SelectedItem.ToString(),
                cboFloor.SelectedItem.ToString());

            InspectionStateToColor();
        }

        /// <summary>
        /// Changes the colors of buttons based on inspection state.
        /// </summary>
        private void InspectionStateToColor()
        {
            // ROOMS THAT PASSED INSPECTION
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
            if (double.TryParse(txtMaskInterval.Text, out double interval))
            {
                double dblDateToday = DateTime.Today.ToOADate();

                var RoomsToInspect = PeopleWhoLiveInFloor
                    .Where(Person => Convert.ToDouble(Person["InspectionDate"]) + interval <= dblDateToday)
                    .Select(Person => Person["Room"].ToString());

                // Get the buttons where the tag on that button is contained in the list of rooms to inspect
                var ButtonsOfRoomsToInspect = grpFloorPlan.Controls.OfType<Button>()
                    .Where(btnButton => RoomsToInspect.Contains(btnButton.Tag.ToString()));

                ChangeButtonColors(ButtonsOfRoomsToInspect, btnNeeded.BackColor);
            }
        }

        /// <summary>
        /// Changes the tags of the floor buttons to match the selected building and floor.
        /// </summary>
        private void ChangeButtonFloorTags(string chrBuilding, string chrFloor)
        {
            var btnRoomsOnFloor = grpFloorPlan.Controls.OfType<Button>();

            foreach (Button btnEachRoom in btnRoomsOnFloor)
            {
                string tag = btnEachRoom.Tag.ToString();

                if (tag.Length >= 3)
                {
                    tag = tag.Remove(0, 1)
                             .Insert(0, chrBuilding)
                             .Remove(2, 1)
                             .Insert(2, chrFloor);

                    btnEachRoom.Tag = tag;
                }
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
            // Need to make sure it's not empty and is a valid number
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
        /// Saves the data back to the XML file.
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
