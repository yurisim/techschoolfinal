namespace RoomInspections
{
	internal sealed partial class FrmStudentRoom
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button25 = new System.Windows.Forms.Button();
			this.button24 = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.tabCurrentStudent = new System.Windows.Forms.TabPage();
			this.lblInspectionStatus = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblLastInspection = new System.Windows.Forms.Label();
			this.txtComments = new System.Windows.Forms.TextBox();
			this.lblDemerits = new System.Windows.Forms.Label();
			this.clbDemerits = new System.Windows.Forms.CheckedListBox();
			this.lblAutoFailures = new System.Windows.Forms.Label();
			this.clbAutoFailures = new System.Windows.Forms.CheckedListBox();
			this.tabStudentData = new System.Windows.Forms.TabControl();
			this.tabCurrentStudent.SuspendLayout();
			this.tabStudentData.SuspendLayout();
			this.SuspendLayout();
			// 
			// button25
			// 
			this.button25.Location = new System.Drawing.Point(137, 18);
			this.button25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(144, 35);
			this.button25.TabIndex = 32;
			this.button25.Text = "&Remove Student";
			this.button25.UseVisualStyleBackColor = true;
			// 
			// button24
			// 
			this.button24.Location = new System.Drawing.Point(9, 18);
			this.button24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(118, 35);
			this.button24.TabIndex = 33;
			this.button24.Text = "&Add Student";
			this.button24.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(289, 18);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(57, 35);
			this.btnSave.TabIndex = 34;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// tabCurrentStudent
			// 
			this.tabCurrentStudent.BackColor = System.Drawing.SystemColors.Control;
			this.tabCurrentStudent.Controls.Add(this.lblInspectionStatus);
			this.tabCurrentStudent.Controls.Add(this.lblDate);
			this.tabCurrentStudent.Controls.Add(this.lblLastInspection);
			this.tabCurrentStudent.Controls.Add(this.txtComments);
			this.tabCurrentStudent.Controls.Add(this.lblDemerits);
			this.tabCurrentStudent.Controls.Add(this.clbDemerits);
			this.tabCurrentStudent.Controls.Add(this.lblAutoFailures);
			this.tabCurrentStudent.Controls.Add(this.clbAutoFailures);
			this.tabCurrentStudent.Location = new System.Drawing.Point(4, 29);
			this.tabCurrentStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabCurrentStudent.Name = "tabCurrentStudent";
			this.tabCurrentStudent.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabCurrentStudent.Size = new System.Drawing.Size(574, 415);
			this.tabCurrentStudent.TabIndex = 0;
			this.tabCurrentStudent.Text = "StudentName";
			// 
			// lblInspectionStatus
			// 
			this.lblInspectionStatus.AutoSize = true;
			this.lblInspectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInspectionStatus.Location = new System.Drawing.Point(375, 278);
			this.lblInspectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInspectionStatus.Name = "lblInspectionStatus";
			this.lblInspectionStatus.Size = new System.Drawing.Size(56, 20);
			this.lblInspectionStatus.TabIndex = 38;
			this.lblInspectionStatus.Text = "PASS";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(375, 62);
			this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(84, 20);
			this.lblDate.TabIndex = 37;
			this.lblDate.Text = "IAmADate";
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLastInspection
			// 
			this.lblLastInspection.AutoSize = true;
			this.lblLastInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastInspection.Location = new System.Drawing.Point(375, 32);
			this.lblLastInspection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLastInspection.Name = "lblLastInspection";
			this.lblLastInspection.Size = new System.Drawing.Size(133, 20);
			this.lblLastInspection.TabIndex = 36;
			this.lblLastInspection.Text = "Last Inspection";
			this.lblLastInspection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtComments
			// 
			this.txtComments.Location = new System.Drawing.Point(4, 278);
			this.txtComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtComments.Multiline = true;
			this.txtComments.Name = "txtComments";
			this.txtComments.Size = new System.Drawing.Size(363, 126);
			this.txtComments.TabIndex = 35;
			this.txtComments.Tag = "";
			this.txtComments.Text = "Insert Comments Here";
			// 
			// lblDemerits
			// 
			this.lblDemerits.AutoSize = true;
			this.lblDemerits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDemerits.Location = new System.Drawing.Point(189, 5);
			this.lblDemerits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDemerits.Name = "lblDemerits";
			this.lblDemerits.Size = new System.Drawing.Size(81, 20);
			this.lblDemerits.TabIndex = 34;
			this.lblDemerits.Text = "Demerits";
			// 
			// clbDemerits
			// 
			this.clbDemerits.CheckOnClick = true;
			this.clbDemerits.FormattingEnabled = true;
			this.clbDemerits.Location = new System.Drawing.Point(189, 32);
			this.clbDemerits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.clbDemerits.Name = "clbDemerits";
			this.clbDemerits.Size = new System.Drawing.Size(178, 235);
			this.clbDemerits.TabIndex = 33;
			// 
			// lblAutoFailures
			// 
			this.lblAutoFailures.AutoSize = true;
			this.lblAutoFailures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAutoFailures.Location = new System.Drawing.Point(0, 5);
			this.lblAutoFailures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAutoFailures.Name = "lblAutoFailures";
			this.lblAutoFailures.Size = new System.Drawing.Size(116, 20);
			this.lblAutoFailures.TabIndex = 32;
			this.lblAutoFailures.Text = "Auto Failures";
			// 
			// clbAutoFailures
			// 
			this.clbAutoFailures.CheckOnClick = true;
			this.clbAutoFailures.FormattingEnabled = true;
			this.clbAutoFailures.Location = new System.Drawing.Point(0, 32);
			this.clbAutoFailures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.clbAutoFailures.Name = "clbAutoFailures";
			this.clbAutoFailures.Size = new System.Drawing.Size(178, 235);
			this.clbAutoFailures.TabIndex = 0;
			// 
			// tabStudentData
			// 
			this.tabStudentData.Controls.Add(this.tabCurrentStudent);
			this.tabStudentData.Location = new System.Drawing.Point(9, 63);
			this.tabStudentData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabStudentData.Name = "tabStudentData";
			this.tabStudentData.SelectedIndex = 0;
			this.tabStudentData.Size = new System.Drawing.Size(582, 448);
			this.tabStudentData.TabIndex = 30;
			this.tabStudentData.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabStudentData_SelectStudent);
			// 
			// FrmStudentRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(598, 518);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.button24);
			this.Controls.Add(this.button25);
			this.Controls.Add(this.tabStudentData);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmStudentRoom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Student Room";
			this.tabCurrentStudent.ResumeLayout(false);
			this.tabCurrentStudent.PerformLayout();
			this.tabStudentData.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TabPage tabCurrentStudent;
		private System.Windows.Forms.Label lblInspectionStatus;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label lblLastInspection;
		private System.Windows.Forms.TextBox txtComments;
		private System.Windows.Forms.Label lblDemerits;
		private System.Windows.Forms.CheckedListBox clbDemerits;
		private System.Windows.Forms.Label lblAutoFailures;
		private System.Windows.Forms.CheckedListBox clbAutoFailures;
		private System.Windows.Forms.TabControl tabStudentData;
	}
}