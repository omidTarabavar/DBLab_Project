namespace LMS
{
    partial class Login
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
            this.emLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emTB = new System.Windows.Forms.TextBox();
            this.pwTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emLabel
            // 
            this.emLabel.AutoSize = true;
            this.emLabel.Location = new System.Drawing.Point(260, 166);
            this.emLabel.Name = "emLabel";
            this.emLabel.Size = new System.Drawing.Size(52, 20);
            this.emLabel.TabIndex = 0;
            this.emLabel.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // emTB
            // 
            this.emTB.Location = new System.Drawing.Point(344, 163);
            this.emTB.Name = "emTB";
            this.emTB.Size = new System.Drawing.Size(257, 26);
            this.emTB.TabIndex = 2;
            // 
            // pwTB
            // 
            this.pwTB.Location = new System.Drawing.Point(344, 218);
            this.pwTB.Name = "pwTB";
            this.pwTB.Size = new System.Drawing.Size(257, 26);
            this.pwTB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwTB);
            this.Controls.Add(this.emTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emTB;
        private System.Windows.Forms.TextBox pwTB;
        private System.Windows.Forms.Button button1;
    }
}