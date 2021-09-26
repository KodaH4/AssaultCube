
namespace AssaultCube
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
            this.ammoTxtBox = new System.Windows.Forms.TextBox();
            this.ammoButton = new System.Windows.Forms.Button();
            this.attachButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ammoTxtBox
            // 
            this.ammoTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ammoTxtBox.Location = new System.Drawing.Point(12, 47);
            this.ammoTxtBox.Name = "ammoTxtBox";
            this.ammoTxtBox.Size = new System.Drawing.Size(155, 20);
            this.ammoTxtBox.TabIndex = 5;
            // 
            // ammoButton
            // 
            this.ammoButton.Location = new System.Drawing.Point(173, 47);
            this.ammoButton.Name = "ammoButton";
            this.ammoButton.Size = new System.Drawing.Size(107, 20);
            this.ammoButton.TabIndex = 4;
            this.ammoButton.Text = "Set MTP-57 Ammo";
            this.ammoButton.UseVisualStyleBackColor = true;
            // 
            // attachButton
            // 
            this.attachButton.Location = new System.Drawing.Point(12, 12);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(268, 29);
            this.attachButton.TabIndex = 3;
            this.attachButton.Text = "Attach";
            this.attachButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 78);
            this.Controls.Add(this.ammoTxtBox);
            this.Controls.Add(this.ammoButton);
            this.Controls.Add(this.attachButton);
            this.Name = "Form1";
            this.Text = "Assault Cube";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ammoTxtBox;
        private System.Windows.Forms.Button ammoButton;
        private System.Windows.Forms.Button attachButton;
    }
}

