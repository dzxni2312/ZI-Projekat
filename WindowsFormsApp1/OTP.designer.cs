
namespace FormaWFC
{
    partial class OTP
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
            this.OTPLabel = new System.Windows.Forms.Label();
            this.OTPFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileTbx = new System.Windows.Forms.TextBox();
            this.fileButton = new System.Windows.Forms.Button();
            this.actionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OTPLabel
            // 
            this.OTPLabel.AutoSize = true;
            this.OTPLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OTPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.OTPLabel.Location = new System.Drawing.Point(260, 57);
            this.OTPLabel.Name = "OTPLabel";
            this.OTPLabel.Size = new System.Drawing.Size(191, 31);
            this.OTPLabel.TabIndex = 0;
            this.OTPLabel.Text = "One-Time-Pad";
            // 
            // OTPFileDialog
            // 
            this.OTPFileDialog.DefaultExt = "txt";
            this.OTPFileDialog.Filter = "Text files(*.txt)|*.txt";
            this.OTPFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OTPFileDialog_FileOk);
            // 
            // fileTbx
            // 
            this.fileTbx.Enabled = false;
            this.fileTbx.Location = new System.Drawing.Point(174, 210);
            this.fileTbx.Name = "fileTbx";
            this.fileTbx.Size = new System.Drawing.Size(348, 20);
            this.fileTbx.TabIndex = 1;
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(268, 144);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(183, 25);
            this.fileButton.TabIndex = 3;
            this.fileButton.Text = "Izaberi fajl";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(268, 259);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(172, 33);
            this.actionButton.TabIndex = 4;
            this.actionButton.Text = "Akcija";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // OTP
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(806, 335);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.fileTbx);
            this.Controls.Add(this.OTPLabel);
            this.Name = "OTP";
            this.Text = "OTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OTPLabel;
        private System.Windows.Forms.OpenFileDialog OTPFileDialog;
        private System.Windows.Forms.TextBox fileTbx;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Button actionButton;
    }
}
