namespace LMS
{
    partial class FileMenuStd
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
            this.linkTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.downBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkTB
            // 
            this.linkTB.Location = new System.Drawing.Point(353, 244);
            this.linkTB.Name = "linkTB";
            this.linkTB.Size = new System.Drawing.Size(169, 26);
            this.linkTB.TabIndex = 18;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(353, 181);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(169, 26);
            this.titleTB.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Link";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Title";
            // 
            // downBT
            // 
            this.downBT.Location = new System.Drawing.Point(336, 324);
            this.downBT.Name = "downBT";
            this.downBT.Size = new System.Drawing.Size(109, 33);
            this.downBT.TabIndex = 19;
            this.downBT.Text = "Download";
            this.downBT.UseVisualStyleBackColor = true;
            this.downBT.Click += new System.EventHandler(this.downBT_Click);
            // 
            // FileMenuStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.downBT);
            this.Controls.Add(this.linkTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FileMenuStd";
            this.Text = "FileMenuStd";
            this.Load += new System.EventHandler(this.FileMenuStd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox linkTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button downBT;
    }
}