namespace TestAssignment2
{
    partial class GeneralFitnessForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            grpFemaleInputs = new GroupBox();
            txtForearm = new TextBox();
            txtHip = new TextBox();
            txtWrist = new TextBox();
            label26 = new Label();
            label25 = new Label();
            label14 = new Label();
            groupBox2 = new GroupBox();
            cmbActivityLevel = new ComboBox();
            cmbGender = new ComboBox();
            waistlbl = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            txtWaist = new TextBox();
            txtAge = new TextBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtName = new TextBox();
            groupBox3 = new GroupBox();
            lblOutputName = new Label();
            lblOutputHeight = new Label();
            lblOutputWeight = new Label();
            lblOutputAge = new Label();
            lblOutputGender = new Label();
            lblOutputBMR = new Label();
            lblOutputActivityBMR = new Label();
            lblOutputActivityLevel = new Label();
            lblOutputBodyFat = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            btnCalculateFitness = new Button();
            btnClear = new Button();
            label15 = new Label();
            listBoxUsers = new ListBox();
            btnCreateUser = new Button();
            chkDeleteUser = new CheckBox();
            grpFemaleInputs.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 46);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 75);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Height (inches):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 110);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "Weight (lbs):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 144);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 190);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 239);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 6;
            label7.Text = "Actvity Level:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 312);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 7;
            label8.Text = "Waist (inches):";
            // 
            // grpFemaleInputs
            // 
            grpFemaleInputs.Controls.Add(txtForearm);
            grpFemaleInputs.Controls.Add(txtHip);
            grpFemaleInputs.Controls.Add(txtWrist);
            grpFemaleInputs.Controls.Add(label26);
            grpFemaleInputs.Controls.Add(label25);
            grpFemaleInputs.Controls.Add(label14);
            grpFemaleInputs.Font = new Font("Segoe UI", 9F);
            grpFemaleInputs.Location = new Point(12, 415);
            grpFemaleInputs.Name = "grpFemaleInputs";
            grpFemaleInputs.Size = new Size(257, 174);
            grpFemaleInputs.TabIndex = 9;
            grpFemaleInputs.TabStop = false;
            grpFemaleInputs.Text = "Female - Body Fat Calculation";
            // 
            // txtForearm
            // 
            txtForearm.Location = new Point(119, 132);
            txtForearm.Name = "txtForearm";
            txtForearm.Size = new Size(132, 23);
            txtForearm.TabIndex = 5;
            // 
            // txtHip
            // 
            txtHip.Location = new Point(119, 81);
            txtHip.Name = "txtHip";
            txtHip.Size = new Size(132, 23);
            txtHip.TabIndex = 4;
            // 
            // txtWrist
            // 
            txtWrist.Location = new Point(120, 31);
            txtWrist.Name = "txtWrist";
            txtWrist.Size = new Size(131, 23);
            txtWrist.TabIndex = 3;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(32, 35);
            label26.Name = "label26";
            label26.Size = new Size(82, 15);
            label26.TabIndex = 2;
            label26.Text = "Wrist (inches):";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(15, 135);
            label25.Name = "label25";
            label25.Size = new Size(99, 15);
            label25.TabIndex = 1;
            label25.Text = "Forearm (inches):";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(40, 84);
            label14.Name = "label14";
            label14.Size = new Size(74, 15);
            label14.TabIndex = 0;
            label14.Text = "Hip (inches):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbActivityLevel);
            groupBox2.Controls.Add(cmbGender);
            groupBox2.Controls.Add(waistlbl);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtWaist);
            groupBox2.Controls.Add(txtAge);
            groupBox2.Controls.Add(txtWeight);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(txtName);
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(455, 397);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "General Information";
            // 
            // cmbActivityLevel
            // 
            cmbActivityLevel.FormattingEnabled = true;
            cmbActivityLevel.Location = new Point(156, 289);
            cmbActivityLevel.Name = "cmbActivityLevel";
            cmbActivityLevel.Size = new Size(248, 23);
            cmbActivityLevel.TabIndex = 27;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(156, 247);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(248, 23);
            cmbGender.TabIndex = 26;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // waistlbl
            // 
            waistlbl.AutoSize = true;
            waistlbl.Location = new Point(30, 344);
            waistlbl.Name = "waistlbl";
            waistlbl.Size = new Size(84, 15);
            waistlbl.TabIndex = 25;
            waistlbl.Text = "Waist (inches):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(34, 297);
            label13.Name = "label13";
            label13.Size = new Size(80, 15);
            label13.TabIndex = 24;
            label13.Text = "Activity Level:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(66, 250);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 23;
            label12.Text = "Gender:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(83, 209);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 22;
            label11.Text = "Age:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 152);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 21;
            label10.Text = "Weight (lbs):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 90);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 20;
            label9.Text = "Height (inches):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 37);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 19;
            label1.Text = "Name:";
            // 
            // txtWaist
            // 
            txtWaist.Location = new Point(156, 341);
            txtWaist.Name = "txtWaist";
            txtWaist.Size = new Size(248, 23);
            txtWaist.TabIndex = 18;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(156, 206);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(248, 23);
            txtAge.TabIndex = 17;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(156, 149);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(248, 23);
            txtWeight.TabIndex = 16;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(156, 87);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(248, 23);
            txtHeight.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(156, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(248, 23);
            txtName.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblOutputName);
            groupBox3.Controls.Add(lblOutputHeight);
            groupBox3.Controls.Add(lblOutputWeight);
            groupBox3.Controls.Add(lblOutputAge);
            groupBox3.Controls.Add(lblOutputGender);
            groupBox3.Controls.Add(lblOutputBMR);
            groupBox3.Controls.Add(lblOutputActivityBMR);
            groupBox3.Controls.Add(lblOutputActivityLevel);
            groupBox3.Controls.Add(lblOutputBodyFat);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label24);
            groupBox3.Location = new Point(473, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 577);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Current User Report";
            // 
            // lblOutputName
            // 
            lblOutputName.AutoSize = true;
            lblOutputName.Location = new Point(98, 61);
            lblOutputName.Name = "lblOutputName";
            lblOutputName.Size = new Size(10, 15);
            lblOutputName.TabIndex = 29;
            lblOutputName.Text = " ";
            // 
            // lblOutputHeight
            // 
            lblOutputHeight.AutoSize = true;
            lblOutputHeight.Location = new Point(98, 119);
            lblOutputHeight.Name = "lblOutputHeight";
            lblOutputHeight.Size = new Size(10, 15);
            lblOutputHeight.TabIndex = 30;
            lblOutputHeight.Text = " ";
            // 
            // lblOutputWeight
            // 
            lblOutputWeight.AutoSize = true;
            lblOutputWeight.Location = new Point(98, 173);
            lblOutputWeight.Name = "lblOutputWeight";
            lblOutputWeight.Size = new Size(10, 15);
            lblOutputWeight.TabIndex = 31;
            lblOutputWeight.Text = " ";
            // 
            // lblOutputAge
            // 
            lblOutputAge.AutoSize = true;
            lblOutputAge.Location = new Point(98, 225);
            lblOutputAge.Name = "lblOutputAge";
            lblOutputAge.Size = new Size(10, 15);
            lblOutputAge.TabIndex = 32;
            lblOutputAge.Text = " ";
            // 
            // lblOutputGender
            // 
            lblOutputGender.AutoSize = true;
            lblOutputGender.Location = new Point(98, 268);
            lblOutputGender.Name = "lblOutputGender";
            lblOutputGender.Size = new Size(10, 15);
            lblOutputGender.TabIndex = 33;
            lblOutputGender.Text = " ";
            // 
            // lblOutputBMR
            // 
            lblOutputBMR.AutoSize = true;
            lblOutputBMR.Location = new Point(98, 315);
            lblOutputBMR.Name = "lblOutputBMR";
            lblOutputBMR.Size = new Size(10, 15);
            lblOutputBMR.TabIndex = 34;
            lblOutputBMR.Text = " ";
            // 
            // lblOutputActivityBMR
            // 
            lblOutputActivityBMR.AutoSize = true;
            lblOutputActivityBMR.Location = new Point(98, 365);
            lblOutputActivityBMR.Name = "lblOutputActivityBMR";
            lblOutputActivityBMR.Size = new Size(10, 15);
            lblOutputActivityBMR.TabIndex = 35;
            lblOutputActivityBMR.Text = " ";
            // 
            // lblOutputActivityLevel
            // 
            lblOutputActivityLevel.AutoSize = true;
            lblOutputActivityLevel.Location = new Point(98, 414);
            lblOutputActivityLevel.Name = "lblOutputActivityLevel";
            lblOutputActivityLevel.Size = new Size(10, 15);
            lblOutputActivityLevel.TabIndex = 36;
            lblOutputActivityLevel.Text = " ";
            // 
            // lblOutputBodyFat
            // 
            lblOutputBodyFat.AutoSize = true;
            lblOutputBodyFat.Location = new Point(98, 468);
            lblOutputBodyFat.Name = "lblOutputBodyFat";
            lblOutputBodyFat.Size = new Size(10, 15);
            lblOutputBodyFat.TabIndex = 37;
            lblOutputBodyFat.Text = " ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(50, 61);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 15;
            label16.Text = "Name:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(46, 119);
            label17.Name = "label17";
            label17.Size = new Size(46, 15);
            label17.TabIndex = 16;
            label17.Text = "Height:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(44, 176);
            label18.Name = "label18";
            label18.Size = new Size(48, 15);
            label18.TabIndex = 17;
            label18.Text = "Weight:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(61, 225);
            label19.Name = "label19";
            label19.Size = new Size(31, 15);
            label19.TabIndex = 18;
            label19.Text = "Age:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(44, 268);
            label20.Name = "label20";
            label20.Size = new Size(48, 15);
            label20.TabIndex = 19;
            label20.Text = "Gender:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(57, 315);
            label21.Name = "label21";
            label21.Size = new Size(35, 15);
            label21.TabIndex = 20;
            label21.Text = "BMR:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(21, 365);
            label22.Name = "label22";
            label22.Size = new Size(71, 15);
            label22.TabIndex = 21;
            label22.Text = "Activity MR:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(42, 414);
            label23.Name = "label23";
            label23.Size = new Size(50, 15);
            label23.TabIndex = 22;
            label23.Text = "Activity:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(23, 468);
            label24.Name = "label24";
            label24.Size = new Size(69, 15);
            label24.TabIndex = 23;
            label24.Text = "Body Fat %:";
            // 
            // btnCalculateFitness
            // 
            btnCalculateFitness.Location = new Point(374, 415);
            btnCalculateFitness.Name = "btnCalculateFitness";
            btnCalculateFitness.Size = new Size(93, 23);
            btnCalculateFitness.TabIndex = 12;
            btnCalculateFitness.Text = "Load User";
            btnCalculateFitness.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(374, 439);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(275, 461);
            label15.Name = "label15";
            label15.Size = new Size(46, 19);
            label15.TabIndex = 14;
            label15.Text = "Users:";
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 15;
            listBoxUsers.Location = new Point(275, 483);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(192, 109);
            listBoxUsers.TabIndex = 26;
            listBoxUsers.SelectedIndexChanged += listBoxUsers_SelectedIndexChanged;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(275, 415);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(93, 23);
            btnCreateUser.TabIndex = 27;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // chkDeleteUser
            // 
            chkDeleteUser.AutoSize = true;
            chkDeleteUser.Location = new Point(275, 439);
            chkDeleteUser.Name = "chkDeleteUser";
            chkDeleteUser.Size = new Size(85, 19);
            chkDeleteUser.TabIndex = 28;
            chkDeleteUser.Text = "Delete User";
            chkDeleteUser.UseVisualStyleBackColor = true;
            chkDeleteUser.CheckedChanged += chkDeleteUser_CheckedChanged;
            // 
            // GeneralFitnessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 601);
            Controls.Add(chkDeleteUser);
            Controls.Add(btnCreateUser);
            Controls.Add(listBoxUsers);
            Controls.Add(label15);
            Controls.Add(btnClear);
            Controls.Add(btnCalculateFitness);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(grpFemaleInputs);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "GeneralFitnessForm";
            Text = "General Fitness Form";
            grpFemaleInputs.ResumeLayout(false);
            grpFemaleInputs.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox grpFemaleInputs;
        private GroupBox groupBox2;
        private Label waistlbl;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label1;
        private TextBox txtWaist;
        private TextBox txtAge;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtName;
        private GroupBox groupBox3;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Button btnCalculateFitness;
        private Button btnClear;
        private Label label15;
        private ComboBox cmbActivityLevel;
        private ComboBox cmbGender;
        private ListBox listBoxUsers;
        private TextBox txtForearm;
        private TextBox txtHip;
        private TextBox txtWrist;
        private Label label26;
        private Label label25;
        private Label label14;
        private Label lblOutputName;
        private Label lblOutputHeight;
        private Label lblOutputWeight;
        private Label lblOutputAge;
        private Label lblOutputGender;
        private Label lblOutputBMR;
        private Label lblOutputActivityBMR;
        private Label lblOutputActivityLevel;
        private Label lblOutputBodyFat;
        private Button btnCreateUser;
        private CheckBox chkDeleteUser;
    }
}
