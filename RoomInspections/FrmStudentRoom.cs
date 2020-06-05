using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomInspections
{
	internal sealed partial class FrmStudentRoom : Form
	{
		private readonly List<DataRow> PeopleInRoom;

		private readonly Array TabLayout;

		private const int IntDemeritsFailed = 3;

		// Make this private in case Kegley decides to try to make this
		private FrmStudentRoom()
		{
			InitializeComponent();

			// Creates copy of GUI for other Tabs
			TabLayout = new Control[tabStudentData.TabPages[0].Controls.Count];
			tabStudentData.TabPages[0].Controls.CopyTo(TabLayout, 0);
		}

		public FrmStudentRoom(List<string> strListAutoFails, List<string> strListDemerits, List<DataRow> peopleInRoom,
			string strRoomID) : this()
		{
			PeopleInRoom = peopleInRoom;

			this.Text = strRoomID;

			// Populate Auto Fails
			foreach (string strAutoFail in strListAutoFails)
			{
				clbAutoFailures.Items.Add(strAutoFail);
			}

			// Populate Demerits
			foreach (string strDemerit in strListDemerits)
			{
				clbDemerits.Items.Add(strDemerit);
			}

			// Makes Tabs if the # of Tabs is less than the number of people
			while (tabStudentData.TabPages.Count < PeopleInRoom.Count)
			{
				tabStudentData.TabPages.Add(new TabPage());
			}

			// Removes Tabs if the # of Tabs is more than the number of people
			while (tabStudentData.TabPages.Count > PeopleInRoom.Count && tabStudentData.TabPages.Count > 1)
			{
				tabStudentData.TabPages.RemoveAt(tabStudentData.TabPages.Count - 1);
			}

			// Rename Tabs To Names of Students
			for (int i = 0; i < PeopleInRoom.Count; i++)
			{
				tabStudentData.TabPages[i].Text = PeopleInRoom[i]["Name"].ToString();
			}

			if (PeopleInRoom.Count > 0)
			{
				ConfigurePage(0);
			}
		}

		private void tabStudentData_SelectStudent(object sender, TabControlEventArgs e)
		{
			ConfigurePage(tabStudentData.SelectedIndex);
		}

		private void ConfigurePage(int intSelectedStudent)
		{
			// Moves Controls to Tab
			tabStudentData.TabPages[intSelectedStudent].Controls.AddRange((Control[]) TabLayout);

			// The last inspection date
			lblDate.Text = DateTime.FromOADate(Convert.ToDouble(PeopleInRoom[intSelectedStudent]["InspectionDate"]))
				.ToShortDateString();

			for (int i = 0; i < clbAutoFailures.Items.Count; i++)
			{
				clbAutoFailures.SetItemChecked(i, false);
			}

			for (int i = 0; i < clbDemerits.Items.Count; i++)
			{
				clbDemerits.SetItemChecked(i, false);
			}

			// Reads the auto fails from the student
			for (int i = 0; i < PeopleInRoom[intSelectedStudent]["Autofails"].ToString().Length; i++)
			{
				bool blnItemWasFailed = PeopleInRoom[intSelectedStudent]["Autofails"].ToString()[i].Equals('1');

				clbAutoFailures.SetItemChecked(i, blnItemWasFailed);
			}

			for (int i = 0; i < PeopleInRoom[intSelectedStudent]["Demerits"].ToString().Length; i++)
			{
				bool blnItemWasFailed = PeopleInRoom[intSelectedStudent]["Demerits"].ToString()[i].Equals('1');

				clbDemerits.SetItemChecked(i, blnItemWasFailed);
			}
		}

		private List<string> CheckFailures(out bool blnFail)
		{
			var AutoFailures = Enumerable.Range(0, clbAutoFailures.Items.Count)
				.Select(i => (int)clbAutoFailures.GetItemCheckState(i))
				.ToArray();

			var Demerits = Enumerable.Range(0, clbDemerits.Items.Count)
				.Select(i => (int)clbDemerits.GetItemCheckState(i))
				.ToArray();

			blnFail = AutoFailures.Contains(1) ||
			               Demerits.Count(x => x == 1) > IntDemeritsFailed;

			lblInspectionStatus.Text = blnFail ? "FAIL" : "PASS";

			lblInspectionStatus.ForeColor = blnFail ? Color.LightCoral : Color.LightGreen;

			return new List<string> {string.Concat(AutoFailures), string.Concat(Demerits)};
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var strListInspectionState = CheckFailures(out bool blnFail);

			PeopleInRoom[tabStudentData.SelectedIndex]["Autofails"] = string.Concat(strListInspectionState[0]);
			PeopleInRoom[tabStudentData.SelectedIndex]["Demerits"] = string.Concat(strListInspectionState[1]);
			PeopleInRoom[tabStudentData.SelectedIndex]["InspectionDate"] = DateTime.Today.ToOADate();
			PeopleInRoom[tabStudentData.SelectedIndex]["Pass"] = blnFail ? "F" : "T";

			ConfigurePage(tabStudentData.SelectedIndex);
		}
	}
}
