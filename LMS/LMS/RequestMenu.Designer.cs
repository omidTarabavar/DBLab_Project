namespace LMS
{
    partial class RequestMenu
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
            this.accBT = new System.Windows.Forms.Button();
            this.rejBT = new System.Windows.Forms.Button();
            this.reqLV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // accBT
            // 
            this.accBT.Location = new System.Drawing.Point(496, 376);
            this.accBT.Name = "accBT";
            this.accBT.Size = new System.Drawing.Size(114, 40);
            this.accBT.TabIndex = 1;
            this.accBT.Text = "Accept";
            this.accBT.UseVisualStyleBackColor = true;
            this.accBT.Click += new System.EventHandler(this.accBT_Click);
            // 
            // rejBT
            // 
            this.rejBT.Location = new System.Drawing.Point(642, 376);
            this.rejBT.Name = "rejBT";
            this.rejBT.Size = new System.Drawing.Size(114, 40);
            this.rejBT.TabIndex = 2;
            this.rejBT.Text = "Reject";
            this.rejBT.UseVisualStyleBackColor = true;
            this.rejBT.Click += new System.EventHandler(this.rejBT_Click);
            // 
            // reqLV
            // 
            this.reqLV.HideSelection = false;
            this.reqLV.Location = new System.Drawing.Point(45, 52);
            this.reqLV.Name = "reqLV";
            this.reqLV.Size = new System.Drawing.Size(711, 301);
            this.reqLV.TabIndex = 3;
            this.reqLV.UseCompatibleStateImageBehavior = false;
            // 
            // RequestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reqLV);
            this.Controls.Add(this.rejBT);
            this.Controls.Add(this.accBT);
            this.Name = "RequestMenu";
            this.Text = "RequestMenu";
            this.Load += new System.EventHandler(this.RequestMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button accBT;
        private System.Windows.Forms.Button rejBT;
        private System.Windows.Forms.ListView reqLV;
    }
}