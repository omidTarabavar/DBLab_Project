namespace LMS
{
    partial class ProfessorMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.familyTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.pwTB = new System.Windows.Forms.TextBox();
            this.pnTB = new System.Windows.Forms.TextBox();
            this.chngProf = new System.Windows.Forms.Button();
            this.addCrsBT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.crsLV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Family";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(138, 88);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(135, 26);
            this.nameTB.TabIndex = 6;
            // 
            // familyTB
            // 
            this.familyTB.Location = new System.Drawing.Point(138, 129);
            this.familyTB.Name = "familyTB";
            this.familyTB.ReadOnly = true;
            this.familyTB.Size = new System.Drawing.Size(135, 26);
            this.familyTB.TabIndex = 7;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(138, 182);
            this.emailTB.Name = "emailTB";
            this.emailTB.ReadOnly = true;
            this.emailTB.Size = new System.Drawing.Size(135, 26);
            this.emailTB.TabIndex = 8;
            // 
            // pwTB
            // 
            this.pwTB.Location = new System.Drawing.Point(138, 226);
            this.pwTB.Name = "pwTB";
            this.pwTB.ReadOnly = true;
            this.pwTB.Size = new System.Drawing.Size(135, 26);
            this.pwTB.TabIndex = 9;
            // 
            // pnTB
            // 
            this.pnTB.Location = new System.Drawing.Point(138, 269);
            this.pnTB.Name = "pnTB";
            this.pnTB.ReadOnly = true;
            this.pnTB.Size = new System.Drawing.Size(135, 26);
            this.pnTB.TabIndex = 10;
            // 
            // chngProf
            // 
            this.chngProf.Location = new System.Drawing.Point(22, 373);
            this.chngProf.Name = "chngProf";
            this.chngProf.Size = new System.Drawing.Size(126, 37);
            this.chngProf.TabIndex = 11;
            this.chngProf.Text = "Change Profile";
            this.chngProf.UseVisualStyleBackColor = true;
            this.chngProf.Click += new System.EventHandler(this.chngProf_Click);
            // 
            // addCrsBT
            // 
            this.addCrsBT.Location = new System.Drawing.Point(365, 372);
            this.addCrsBT.Name = "addCrsBT";
            this.addCrsBT.Size = new System.Drawing.Size(116, 38);
            this.addCrsBT.TabIndex = 12;
            this.addCrsBT.Text = "Add Course";
            this.addCrsBT.UseVisualStyleBackColor = true;
            this.addCrsBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "View Selected Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveBT
            // 
            this.saveBT.Location = new System.Drawing.Point(189, 372);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(84, 38);
            this.saveBT.TabIndex = 14;
            this.saveBT.Text = "Save";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Visible = false;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // crsLV
            // 
            this.crsLV.HideSelection = false;
            this.crsLV.Location = new System.Drawing.Point(365, 33);
            this.crsLV.Name = "crsLV";
            this.crsLV.Size = new System.Drawing.Size(423, 305);
            this.crsLV.TabIndex = 15;
            this.crsLV.UseCompatibleStateImageBehavior = false;
            // 
            // ProfessorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.crsLV);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addCrsBT);
            this.Controls.Add(this.chngProf);
            this.Controls.Add(this.pnTB);
            this.Controls.Add(this.pwTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.familyTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProfessorMenu";
            this.Text = "ProfessorMenu";
            this.Load += new System.EventHandler(this.ProfessorMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox familyTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox pwTB;
        private System.Windows.Forms.TextBox pnTB;
        private System.Windows.Forms.Button chngProf;
        private System.Windows.Forms.Button addCrsBT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.ListView crsLV;
    }
}