namespace LMS
{
    partial class SignUp
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
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.PNTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.profRB = new System.Windows.Forms.RadioButton();
            this.stdRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Family:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone number:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(304, 67);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(226, 26);
            this.nameTB.TabIndex = 5;
            // 
            // familyTB
            // 
            this.familyTB.Location = new System.Drawing.Point(304, 114);
            this.familyTB.Name = "familyTB";
            this.familyTB.Size = new System.Drawing.Size(226, 26);
            this.familyTB.TabIndex = 6;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(304, 170);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(226, 26);
            this.EmailTB.TabIndex = 7;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(304, 223);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(226, 26);
            this.PassTB.TabIndex = 8;
            // 
            // PNTB
            // 
            this.PNTB.Location = new System.Drawing.Point(304, 273);
            this.PNTB.Name = "PNTB";
            this.PNTB.Size = new System.Drawing.Size(226, 26);
            this.PNTB.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // profRB
            // 
            this.profRB.AutoSize = true;
            this.profRB.Location = new System.Drawing.Point(304, 331);
            this.profRB.Name = "profRB";
            this.profRB.Size = new System.Drawing.Size(102, 24);
            this.profRB.TabIndex = 11;
            this.profRB.TabStop = true;
            this.profRB.Text = "Professor";
            this.profRB.UseVisualStyleBackColor = true;
            // 
            // stdRB
            // 
            this.stdRB.AutoSize = true;
            this.stdRB.Location = new System.Drawing.Point(439, 331);
            this.stdRB.Name = "stdRB";
            this.stdRB.Size = new System.Drawing.Size(91, 24);
            this.stdRB.TabIndex = 12;
            this.stdRB.TabStop = true;
            this.stdRB.Text = "Student";
            this.stdRB.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stdRB);
            this.Controls.Add(this.profRB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PNTB);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.familyTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
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
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox PNTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton profRB;
        private System.Windows.Forms.RadioButton stdRB;
    }
}