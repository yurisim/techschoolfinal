namespace RoomInspections
{
	internal sealed partial class FrmRoomInspection
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.cboBuilding = new System.Windows.Forms.ComboBox();
			this.lblBuilding = new System.Windows.Forms.Label();
			this.lblFloor = new System.Windows.Forms.Label();
			this.cboFloor = new System.Windows.Forms.ComboBox();
			this.button22 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.BtnRM01 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.btnSA100 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.grpKey = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnPassed = new System.Windows.Forms.Button();
			this.btnEmpty = new System.Windows.Forms.Button();
			this.btnNeeded = new System.Windows.Forms.Button();
			this.btnFailed = new System.Windows.Forms.Button();
			this.grpFloorPlan = new System.Windows.Forms.GroupBox();
			this.lblDaysPerInspection = new System.Windows.Forms.Label();
			this.txtMaskInterval = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblBayB = new System.Windows.Forms.Label();
			this.button15 = new System.Windows.Forms.Button();
			this.grpKey.SuspendLayout();
			this.grpFloorPlan.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// cboBuilding
			// 
			this.cboBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBuilding.FormattingEnabled = true;
			this.cboBuilding.Location = new System.Drawing.Point(94, 8);
			this.cboBuilding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboBuilding.Name = "cboBuilding";
			this.cboBuilding.Size = new System.Drawing.Size(48, 28);
			this.cboBuilding.Sorted = true;
			this.cboBuilding.TabIndex = 24;
			this.cboBuilding.SelectedIndexChanged += new System.EventHandler(this.CboBuilding_SelectedIndexChanged);
			// 
			// lblBuilding
			// 
			this.lblBuilding.AutoSize = true;
			this.lblBuilding.Location = new System.Drawing.Point(15, 13);
			this.lblBuilding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBuilding.Name = "lblBuilding";
			this.lblBuilding.Size = new System.Drawing.Size(69, 20);
			this.lblBuilding.TabIndex = 25;
			this.lblBuilding.Text = "Building:";
			// 
			// lblFloor
			// 
			this.lblFloor.AutoSize = true;
			this.lblFloor.Location = new System.Drawing.Point(150, 13);
			this.lblFloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFloor.Name = "lblFloor";
			this.lblFloor.Size = new System.Drawing.Size(49, 20);
			this.lblFloor.TabIndex = 27;
			this.lblFloor.Text = "Floor:";
			// 
			// cboFloor
			// 
			this.cboFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFloor.FormattingEnabled = true;
			this.cboFloor.Location = new System.Drawing.Point(207, 9);
			this.cboFloor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboFloor.Name = "cboFloor";
			this.cboFloor.Size = new System.Drawing.Size(48, 28);
			this.cboFloor.Sorted = true;
			this.cboFloor.TabIndex = 26;
			this.cboFloor.SelectedIndexChanged += new System.EventHandler(this.CboFloor_SelectedIndexChanged);
			// 
			// button22
			// 
			this.button22.Location = new System.Drawing.Point(129, 233);
			this.button22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(49, 33);
			this.button22.TabIndex = 17;
			this.button22.Tag = "xBx02";
			this.button22.Text = "02";
			this.button22.UseVisualStyleBackColor = true;
			this.button22.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(242, 109);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(49, 33);
			this.button1.TabIndex = 1;
			this.button1.Tag = "xCx02";
			this.button1.Text = "02";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(242, 68);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(49, 33);
			this.button2.TabIndex = 2;
			this.button2.Tag = "xCx04";
			this.button2.Text = "04";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button21
			// 
			this.button21.Location = new System.Drawing.Point(75, 233);
			this.button21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(49, 33);
			this.button21.TabIndex = 18;
			this.button21.Tag = "xBx04";
			this.button21.Text = "04";
			this.button21.UseVisualStyleBackColor = true;
			this.button21.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button23
			// 
			this.button23.Location = new System.Drawing.Point(185, 233);
			this.button23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(49, 33);
			this.button23.TabIndex = 16;
			this.button23.Tag = "xBx00";
			this.button23.Text = "00";
			this.button23.UseVisualStyleBackColor = true;
			this.button23.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// BtnRM01
			// 
			this.BtnRM01.Location = new System.Drawing.Point(242, 151);
			this.BtnRM01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.BtnRM01.Name = "BtnRM01";
			this.BtnRM01.Size = new System.Drawing.Size(49, 33);
			this.BtnRM01.TabIndex = 0;
			this.BtnRM01.Tag = "xCx00";
			this.BtnRM01.Text = "00";
			this.BtnRM01.UseVisualStyleBackColor = true;
			this.BtnRM01.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(298, 151);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(49, 33);
			this.button4.TabIndex = 4;
			this.button4.Tag = "xCx01";
			this.button4.Text = "01";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button20
			// 
			this.button20.Location = new System.Drawing.Point(18, 233);
			this.button20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(49, 33);
			this.button20.TabIndex = 19;
			this.button20.Tag = "xBx06";
			this.button20.Text = "06";
			this.button20.UseVisualStyleBackColor = true;
			this.button20.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(525, 233);
			this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(49, 33);
			this.button8.TabIndex = 15;
			this.button8.Tag = "xAx07";
			this.button8.Text = "07";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(298, 109);
			this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(49, 33);
			this.button5.TabIndex = 5;
			this.button5.Tag = "xCx03";
			this.button5.Text = "03";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button19
			// 
			this.button19.Location = new System.Drawing.Point(185, 192);
			this.button19.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(49, 33);
			this.button19.TabIndex = 20;
			this.button19.Tag = "xBx01";
			this.button19.Text = "01";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(468, 233);
			this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(49, 33);
			this.button9.TabIndex = 14;
			this.button9.Tag = "xAx05";
			this.button9.Text = "05";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(298, 68);
			this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(49, 33);
			this.button6.TabIndex = 6;
			this.button6.Tag = "xCx05";
			this.button6.Text = "05";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(129, 192);
			this.button18.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(49, 33);
			this.button18.TabIndex = 21;
			this.button18.Tag = "xBx03";
			this.button18.Text = "03";
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(411, 233);
			this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(49, 33);
			this.button10.TabIndex = 13;
			this.button10.Tag = "xAx03";
			this.button10.Text = "03";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(298, 27);
			this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(49, 33);
			this.button7.TabIndex = 7;
			this.button7.Tag = "xCx07";
			this.button7.Text = "07";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(75, 192);
			this.button17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(49, 33);
			this.button17.TabIndex = 22;
			this.button17.Tag = "xBx05";
			this.button17.Text = "05";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(355, 233);
			this.button11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(49, 33);
			this.button11.TabIndex = 12;
			this.button11.Tag = "xAx01";
			this.button11.Text = "01";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(18, 192);
			this.button16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(49, 33);
			this.button16.TabIndex = 23;
			this.button16.Tag = "xBx07";
			this.button16.Text = "07";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// btnSA100
			// 
			this.btnSA100.Location = new System.Drawing.Point(355, 192);
			this.btnSA100.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSA100.Name = "btnSA100";
			this.btnSA100.Size = new System.Drawing.Size(49, 33);
			this.btnSA100.TabIndex = 8;
			this.btnSA100.Tag = "xAx00";
			this.btnSA100.Text = "00";
			this.btnSA100.UseVisualStyleBackColor = true;
			this.btnSA100.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(525, 192);
			this.button12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(49, 33);
			this.button12.TabIndex = 11;
			this.button12.Tag = "xAx06";
			this.button12.Text = "06";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(411, 192);
			this.button14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(49, 33);
			this.button14.TabIndex = 9;
			this.button14.Tag = "xAx02";
			this.button14.Text = "02";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(468, 192);
			this.button13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(49, 33);
			this.button13.TabIndex = 10;
			this.button13.Tag = "xAx04";
			this.button13.Text = "04";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(242, 27);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(49, 33);
			this.button3.TabIndex = 3;
			this.button3.Tag = "xCx06";
			this.button3.Text = "06";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.BtnRoom_Click);
			// 
			// grpKey
			// 
			this.grpKey.Controls.Add(this.label7);
			this.grpKey.Controls.Add(this.label6);
			this.grpKey.Controls.Add(this.label5);
			this.grpKey.Controls.Add(this.label4);
			this.grpKey.Controls.Add(this.btnPassed);
			this.grpKey.Controls.Add(this.btnEmpty);
			this.grpKey.Controls.Add(this.btnNeeded);
			this.grpKey.Controls.Add(this.btnFailed);
			this.grpKey.Location = new System.Drawing.Point(18, 291);
			this.grpKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grpKey.Name = "grpKey";
			this.grpKey.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grpKey.Size = new System.Drawing.Size(410, 115);
			this.grpKey.TabIndex = 29;
			this.grpKey.TabStop = false;
			this.grpKey.Text = "Key";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(266, 71);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label7.Size = new System.Drawing.Size(101, 20);
			this.label7.TabIndex = 37;
			this.label7.Text = "Empty Room";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Location = new System.Drawing.Point(266, 32);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(140, 20);
			this.label6.TabIndex = 36;
			this.label6.Text = "Inspection Passed";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(64, 71);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(140, 20);
			this.label5.TabIndex = 35;
			this.label5.Text = "Inspected Needed";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(64, 32);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(130, 20);
			this.label4.TabIndex = 34;
			this.label4.Text = "Inspection Failed";
			// 
			// btnPassed
			// 
			this.btnPassed.BackColor = System.Drawing.Color.PaleGreen;
			this.btnPassed.Location = new System.Drawing.Point(210, 27);
			this.btnPassed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPassed.Name = "btnPassed";
			this.btnPassed.Size = new System.Drawing.Size(49, 31);
			this.btnPassed.TabIndex = 33;
			this.btnPassed.UseVisualStyleBackColor = false;
			// 
			// btnEmpty
			// 
			this.btnEmpty.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnEmpty.Location = new System.Drawing.Point(210, 65);
			this.btnEmpty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEmpty.Name = "btnEmpty";
			this.btnEmpty.Size = new System.Drawing.Size(49, 31);
			this.btnEmpty.TabIndex = 32;
			this.btnEmpty.UseVisualStyleBackColor = false;
			// 
			// btnNeeded
			// 
			this.btnNeeded.BackColor = System.Drawing.Color.LightSalmon;
			this.btnNeeded.Location = new System.Drawing.Point(8, 65);
			this.btnNeeded.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnNeeded.Name = "btnNeeded";
			this.btnNeeded.Size = new System.Drawing.Size(49, 31);
			this.btnNeeded.TabIndex = 31;
			this.btnNeeded.UseVisualStyleBackColor = false;
			// 
			// btnFailed
			// 
			this.btnFailed.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnFailed.Location = new System.Drawing.Point(8, 27);
			this.btnFailed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnFailed.Name = "btnFailed";
			this.btnFailed.Size = new System.Drawing.Size(49, 31);
			this.btnFailed.TabIndex = 30;
			this.btnFailed.UseVisualStyleBackColor = false;
			// 
			// grpFloorPlan
			// 
			this.grpFloorPlan.Controls.Add(this.lblDaysPerInspection);
			this.grpFloorPlan.Controls.Add(this.txtMaskInterval);
			this.grpFloorPlan.Controls.Add(this.label3);
			this.grpFloorPlan.Controls.Add(this.label1);
			this.grpFloorPlan.Controls.Add(this.lblBayB);
			this.grpFloorPlan.Controls.Add(this.grpKey);
			this.grpFloorPlan.Controls.Add(this.button3);
			this.grpFloorPlan.Controls.Add(this.button13);
			this.grpFloorPlan.Controls.Add(this.button14);
			this.grpFloorPlan.Controls.Add(this.button12);
			this.grpFloorPlan.Controls.Add(this.btnSA100);
			this.grpFloorPlan.Controls.Add(this.button16);
			this.grpFloorPlan.Controls.Add(this.button11);
			this.grpFloorPlan.Controls.Add(this.button17);
			this.grpFloorPlan.Controls.Add(this.button7);
			this.grpFloorPlan.Controls.Add(this.button10);
			this.grpFloorPlan.Controls.Add(this.button18);
			this.grpFloorPlan.Controls.Add(this.button6);
			this.grpFloorPlan.Controls.Add(this.button9);
			this.grpFloorPlan.Controls.Add(this.button19);
			this.grpFloorPlan.Controls.Add(this.button5);
			this.grpFloorPlan.Controls.Add(this.button8);
			this.grpFloorPlan.Controls.Add(this.button20);
			this.grpFloorPlan.Controls.Add(this.button4);
			this.grpFloorPlan.Controls.Add(this.BtnRM01);
			this.grpFloorPlan.Controls.Add(this.button23);
			this.grpFloorPlan.Controls.Add(this.button21);
			this.grpFloorPlan.Controls.Add(this.button2);
			this.grpFloorPlan.Controls.Add(this.button1);
			this.grpFloorPlan.Controls.Add(this.button22);
			this.grpFloorPlan.Location = new System.Drawing.Point(15, 55);
			this.grpFloorPlan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grpFloorPlan.Name = "grpFloorPlan";
			this.grpFloorPlan.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grpFloorPlan.Size = new System.Drawing.Size(593, 421);
			this.grpFloorPlan.TabIndex = 28;
			this.grpFloorPlan.TabStop = false;
			this.grpFloorPlan.Text = "BuildingName: FloorNum";
			// 
			// lblDaysPerInspection
			// 
			this.lblDaysPerInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDaysPerInspection.Location = new System.Drawing.Point(436, 353);
			this.lblDaysPerInspection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDaysPerInspection.Name = "lblDaysPerInspection";
			this.lblDaysPerInspection.Size = new System.Drawing.Size(96, 52);
			this.lblDaysPerInspection.TabIndex = 34;
			this.lblDaysPerInspection.Text = "Days per Inspection";
			// 
			// txtMaskInterval
			// 
			this.txtMaskInterval.Location = new System.Drawing.Point(540, 365);
			this.txtMaskInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaskInterval.Mask = "00";
			this.txtMaskInterval.Name = "txtMaskInterval";
			this.txtMaskInterval.PromptChar = ' ';
			this.txtMaskInterval.Size = new System.Drawing.Size(32, 26);
			this.txtMaskInterval.TabIndex = 33;
			this.txtMaskInterval.Text = "14";
			this.txtMaskInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtMaskInterval.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txtMaskInterval.ValidatingType = typeof(int);
			this.txtMaskInterval.TextChanged += new System.EventHandler(this.DaysBetweenInspection_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(355, 27);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 20);
			this.label3.TabIndex = 32;
			this.label3.Text = "Bay C";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(519, 164);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 31;
			this.label1.Text = "Bay A";
			// 
			// lblBayB
			// 
			this.lblBayB.AutoSize = true;
			this.lblBayB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBayB.Location = new System.Drawing.Point(18, 164);
			this.lblBayB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBayB.Name = "lblBayB";
			this.lblBayB.Size = new System.Drawing.Size(56, 20);
			this.lblBayB.TabIndex = 30;
			this.lblBayB.Text = "Bay B";
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(478, 9);
			this.button15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(130, 31);
			this.button15.TabIndex = 30;
			this.button15.Text = "Export Failures";
			this.button15.UseVisualStyleBackColor = true;
			// 
			// FrmRoomInspection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(629, 489);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.grpFloorPlan);
			this.Controls.Add(this.lblFloor);
			this.Controls.Add(this.cboFloor);
			this.Controls.Add(this.lblBuilding);
			this.Controls.Add(this.cboBuilding);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmRoomInspection";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Room Inspections";
			this.Load += new System.EventHandler(this.FrmRoomInspection_Load);
			this.grpKey.ResumeLayout(false);
			this.grpKey.PerformLayout();
			this.grpFloorPlan.ResumeLayout(false);
			this.grpFloorPlan.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ComboBox cboBuilding;
		private System.Windows.Forms.Label lblBuilding;
		private System.Windows.Forms.Label lblFloor;
		private System.Windows.Forms.ComboBox cboFloor;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button BtnRM01;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button btnSA100;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox grpKey;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnPassed;
		private System.Windows.Forms.Button btnEmpty;
		private System.Windows.Forms.Button btnNeeded;
		private System.Windows.Forms.Button btnFailed;
		private System.Windows.Forms.GroupBox grpFloorPlan;
		private System.Windows.Forms.Label lblBayB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox txtMaskInterval;
		private System.Windows.Forms.Label lblDaysPerInspection;
		private System.Windows.Forms.Button button15;
	}
}

