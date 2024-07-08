namespace LMS
{
    partial class CourseMenuStd
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
            this.pidTB = new System.Windows.Forms.TextBox();
            this.depTB = new System.Windows.Forms.TextBox();
            this.semTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileLV = new System.Windows.Forms.ListView();
            this.examBT = new System.Windows.Forms.Button();
            this.viewFileBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pidTB
            // 
            this.pidTB.Location = new System.Drawing.Point(150, 223);
            this.pidTB.Name = "pidTB";
            this.pidTB.Size = new System.Drawing.Size(147, 26);
            this.pidTB.TabIndex = 20;
            // 
            // depTB
            // 
            this.depTB.Location = new System.Drawing.Point(150, 174);
            this.depTB.Name = "depTB";
            this.depTB.Size = new System.Drawing.Size(147, 26);
            this.depTB.TabIndex = 19;
            // 
            // semTB
            // 
            this.semTB.Location = new System.Drawing.Point(150, 128);
            this.semTB.Name = "semTB";
            this.semTB.Size = new System.Drawing.Size(147, 26);
            this.semTB.TabIndex = 18;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(150, 78);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(147, 26);
            this.titleTB.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "pId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Title";
            // 
            // fileLV
            // 
            this.fileLV.HideSelection = false;
            this.fileLV.Location = new System.Drawing.Point(395, 22);
            this.fileLV.Name = "fileLV";
            this.fileLV.Size = new System.Drawing.Size(383, 284);
            this.fileLV.TabIndex = 21;
            this.fileLV.UseCompatibleStateImageBehavior = false;
            // 
            // examBT
            // 
            this.examBT.Location = new System.Drawing.Point(38, 350);
            this.examBT.Name = "examBT";
            this.examBT.Size = new System.Drawing.Size(134, 47);
            this.examBT.TabIndex = 23;
            this.examBT.Text = "View Exams";
            this.examBT.UseVisualStyleBackColor = true;
            // 
            // viewFileBT
            // 
            this.viewFileBT.Location = new System.Drawing.Point(612, 361);
            this.viewFileBT.Name = "viewFileBT";
            this.viewFileBT.Size = new System.Drawing.Size(166, 47);
            this.viewFileBT.TabIndex = 22;
            this.viewFileBT.Text = "View Selected File";
            this.viewFileBT.UseVisualStyleBackColor = true;
            this.viewFileBT.Click += new System.EventHandler(this.viewFileBT_Click);
            // 
            // CourseMenuStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.examBT);
            this.Controls.Add(this.viewFileBT);
            this.Controls.Add(this.fileLV);
            this.Controls.Add(this.pidTB);
            this.Controls.Add(this.depTB);
            this.Controls.Add(this.semTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CourseMenuStd";
            this.Text = "CourseMenuStd";
            this.Load += new System.EventHandler(this.CourseMenuStd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pidTB;
        private System.Windows.Forms.TextBox depTB;
        private System.Windows.Forms.TextBox semTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView fileLV;
        private System.Windows.Forms.Button examBT;
        private System.Windows.Forms.Button viewFileBT;
    }
}