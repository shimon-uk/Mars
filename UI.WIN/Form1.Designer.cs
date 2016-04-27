namespace UI.WIN
{
    partial class Form1
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
            this.Reset = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.StartExplore = new System.Windows.Forms.Button();
            this.RobotResults = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RobotsAssigned = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Plateau_Y = new System.Windows.Forms.TextBox();
            this.Plateau_X = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Direction = new System.Windows.Forms.ComboBox();
            this.RoamCoords = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddRobot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YCoord = new System.Windows.Forms.TextBox();
            this.XCoord = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(877, 417);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 24;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(153, 424);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 17);
            this.Error.TabIndex = 23;
            // 
            // StartExplore
            // 
            this.StartExplore.Location = new System.Drawing.Point(522, 313);
            this.StartExplore.Name = "StartExplore";
            this.StartExplore.Size = new System.Drawing.Size(113, 23);
            this.StartExplore.TabIndex = 22;
            this.StartExplore.Text = "Start Explore";
            this.StartExplore.UseVisualStyleBackColor = true;
            this.StartExplore.Click += new System.EventHandler(this.StartExplore_Click);
            // 
            // RobotResults
            // 
            this.RobotResults.FormattingEnabled = true;
            this.RobotResults.ItemHeight = 16;
            this.RobotResults.Location = new System.Drawing.Point(695, 304);
            this.RobotResults.Name = "RobotResults";
            this.RobotResults.Size = new System.Drawing.Size(332, 84);
            this.RobotResults.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(692, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Robot Results";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Assigned Robots";
            // 
            // RobotsAssigned
            // 
            this.RobotsAssigned.FormattingEnabled = true;
            this.RobotsAssigned.ItemHeight = 16;
            this.RobotsAssigned.Location = new System.Drawing.Point(144, 304);
            this.RobotsAssigned.Name = "RobotsAssigned";
            this.RobotsAssigned.Size = new System.Drawing.Size(344, 84);
            this.RobotsAssigned.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Plateau_Y);
            this.groupBox2.Controls.Add(this.Plateau_X);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(144, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 87);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plateau Dimensions";
            // 
            // Plateau_Y
            // 
            this.Plateau_Y.Location = new System.Drawing.Point(101, 50);
            this.Plateau_Y.Name = "Plateau_Y";
            this.Plateau_Y.Size = new System.Drawing.Size(43, 22);
            this.Plateau_Y.TabIndex = 3;
            // 
            // Plateau_X
            // 
            this.Plateau_X.Location = new System.Drawing.Point(22, 53);
            this.Plateau_X.Name = "Plateau_X";
            this.Plateau_X.Size = new System.Drawing.Size(43, 22);
            this.Plateau_X.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Y Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "X Max";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Direction);
            this.groupBox1.Controls.Add(this.RoamCoords);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddRobot);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.YCoord);
            this.groupBox1.Controls.Add(this.XCoord);
            this.groupBox1.Location = new System.Drawing.Point(362, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 175);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Robot Instructions";
            // 
            // Direction
            // 
            this.Direction.FormattingEnabled = true;
            this.Direction.Items.AddRange(new object[] {
            "N",
            "E",
            "W",
            "S"});
            this.Direction.Location = new System.Drawing.Point(174, 51);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(121, 24);
            this.Direction.TabIndex = 15;
            // 
            // RoamCoords
            // 
            this.RoamCoords.Location = new System.Drawing.Point(27, 134);
            this.RoamCoords.Name = "RoamCoords";
            this.RoamCoords.Size = new System.Drawing.Size(175, 22);
            this.RoamCoords.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Roaming Coordinates";
            // 
            // AddRobot
            // 
            this.AddRobot.Location = new System.Drawing.Point(515, 128);
            this.AddRobot.Name = "AddRobot";
            this.AddRobot.Size = new System.Drawing.Size(101, 34);
            this.AddRobot.TabIndex = 12;
            this.AddRobot.Text = "Add Robot";
            this.AddRobot.UseVisualStyleBackColor = true;
            this.AddRobot.Click += new System.EventHandler(this.AddRobot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Direction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // YCoord
            // 
            this.YCoord.Location = new System.Drawing.Point(94, 52);
            this.YCoord.Name = "YCoord";
            this.YCoord.Size = new System.Drawing.Size(46, 22);
            this.YCoord.TabIndex = 7;
            // 
            // XCoord
            // 
            this.XCoord.Location = new System.Drawing.Point(27, 52);
            this.XCoord.Name = "XCoord";
            this.XCoord.Size = new System.Drawing.Size(38, 22);
            this.XCoord.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 495);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.StartExplore);
            this.Controls.Add(this.RobotResults);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RobotsAssigned);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button StartExplore;
        private System.Windows.Forms.ListBox RobotResults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox RobotsAssigned;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Plateau_Y;
        private System.Windows.Forms.TextBox Plateau_X;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Direction;
        private System.Windows.Forms.TextBox RoamCoords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddRobot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YCoord;
        private System.Windows.Forms.TextBox XCoord;
    }
}

