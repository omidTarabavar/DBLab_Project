namespace LMS
{
    partial class AddCourse
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
            this.titleTB = new System.Windows.Forms.TextBox();
            this.semTB = new System.Windows.Forms.TextBox();
            this.depTB = new System.Windows.Forms.TextBox();
            this.pidTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Professor Id";
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(366, 94);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(132, 26);
            this.titleTB.TabIndex = 4;
            // 
            // semTB
            // 
            this.semTB.Location = new System.Drawing.Point(366, 157);
            this.semTB.Name = "semTB";
            this.semTB.Size = new System.Drawing.Size(132, 26);
            this.semTB.TabIndex = 5;
            // 
            // depTB
            // 
            this.depTB.Location = new System.Drawing.Point(366, 213);
            this.depTB.Name = "depTB";
            this.depTB.Size = new System.Drawing.Size(132, 26);
            this.depTB.TabIndex = 6;
            // 
            // pidTB
            // 
            this.pidTB.Location = new System.Drawing.Point(366, 280);
            this.pidTB.Name = "pidTB";
            this.pidTB.Size = new System.Drawing.Size(132, 26);
            this.pidTB.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pidTB);
            this.Controls.Add(this.depTB);
            this.Controls.Add(this.semTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox semTB;
        private System.Windows.Forms.TextBox depTB;
        private System.Windows.Forms.TextBox pidTB;
        private System.Windows.Forms.Button button1;
    }
}