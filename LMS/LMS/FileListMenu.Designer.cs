namespace LMS
{
    partial class FileListMenu
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
            this.fileListLV = new System.Windows.Forms.ListView();
            this.addFileBT = new System.Windows.Forms.Button();
            this.removeFileBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileListLV
            // 
            this.fileListLV.HideSelection = false;
            this.fileListLV.Location = new System.Drawing.Point(34, 42);
            this.fileListLV.Name = "fileListLV";
            this.fileListLV.Size = new System.Drawing.Size(728, 292);
            this.fileListLV.TabIndex = 0;
            this.fileListLV.UseCompatibleStateImageBehavior = false;
            // 
            // addFileBT
            // 
            this.addFileBT.Location = new System.Drawing.Point(453, 373);
            this.addFileBT.Name = "addFileBT";
            this.addFileBT.Size = new System.Drawing.Size(103, 44);
            this.addFileBT.TabIndex = 1;
            this.addFileBT.Text = "Add File";
            this.addFileBT.UseVisualStyleBackColor = true;
            this.addFileBT.Click += new System.EventHandler(this.addFileBT_Click);
            // 
            // removeFileBT
            // 
            this.removeFileBT.Location = new System.Drawing.Point(578, 373);
            this.removeFileBT.Name = "removeFileBT";
            this.removeFileBT.Size = new System.Drawing.Size(184, 44);
            this.removeFileBT.TabIndex = 2;
            this.removeFileBT.Text = "Remove Selected File";
            this.removeFileBT.UseVisualStyleBackColor = true;
            this.removeFileBT.Click += new System.EventHandler(this.removeFileBT_Click);
            // 
            // FileListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeFileBT);
            this.Controls.Add(this.addFileBT);
            this.Controls.Add(this.fileListLV);
            this.Name = "FileListMenu";
            this.Text = "FileListMenu";
            this.Load += new System.EventHandler(this.FileListMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView fileListLV;
        private System.Windows.Forms.Button addFileBT;
        private System.Windows.Forms.Button removeFileBT;
    }
}