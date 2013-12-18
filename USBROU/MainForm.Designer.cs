namespace USBROU
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.devLabel = new System.Windows.Forms.Label();
            this.disableButton = new System.Windows.Forms.Button();
            this.enableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(55, 135);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(178, 35);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Disabled";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoLabel
            // 
            this.logoLabel.Image = global::USBROU.Properties.Resources.USB_Logo;
            this.logoLabel.Location = new System.Drawing.Point(52, 20);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(181, 113);
            this.logoLabel.TabIndex = 8;
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devLabel
            // 
            this.devLabel.AutoSize = true;
            this.devLabel.Location = new System.Drawing.Point(82, 254);
            this.devLabel.Name = "devLabel";
            this.devLabel.Size = new System.Drawing.Size(123, 13);
            this.devLabel.TabIndex = 7;
            this.devLabel.Text = "Developed by A7maDev";
            this.devLabel.Click += new System.EventHandler(this.devLabel_Click);
            // 
            // disableButton
            // 
            this.disableButton.Location = new System.Drawing.Point(158, 208);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(75, 23);
            this.disableButton.TabIndex = 6;
            this.disableButton.Text = "Disable";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(55, 208);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(75, 23);
            this.enableButton.TabIndex = 5;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.devLabel);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.enableButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Read Only Utility v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label devLabel;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.Button enableButton;
    }
}

