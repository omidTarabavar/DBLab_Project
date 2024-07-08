namespace LMS
{
    partial class AddFileMenu
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
            this.addFBT = new System.Windows.Forms.Button();
            this.linkTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addFBT
            // 
            this.addFBT.Location = new System.Drawing.Point(332, 307);
            this.addFBT.Name = "addFBT";
            this.addFBT.Size = new System.Drawing.Size(123, 34);
            this.addFBT.TabIndex = 17;
            this.addFBT.Text = "Add File";
            this.addFBT.UseVisualStyleBackColor = true;
            this.addFBT.Click += new System.EventHandler(this.addFBT_Click);
            // 
            // linkTB
            // 
            this.linkTB.Location = new System.Drawing.Point(319, 220);
            this.linkTB.Name = "linkTB";
            this.linkTB.Size = new System.Drawing.Size(169, 26);
            this.linkTB.TabIndex = 14;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(319, 157);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(169, 26);
            this.titleTB.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Link";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title";
            // 
            // AddFileMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addFBT);
            this.Controls.Add(this.linkTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFileMenu";
            this.Text = "AddFileMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFBT;
        private System.Windows.Forms.TextBox linkTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}