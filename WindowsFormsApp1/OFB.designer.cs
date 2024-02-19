
namespace FormaWFC
{
    partial class OFB
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
            this.ofbLabel = new System.Windows.Forms.Label();
            this.fileTbx = new System.Windows.Forms.TextBox();
            this.fileBtn = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.actionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofbLabel
            // 
            this.ofbLabel.AutoSize = true;
            this.ofbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ofbLabel.Location = new System.Drawing.Point(252, 26);
            this.ofbLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ofbLabel.Name = "ofbLabel";
            this.ofbLabel.Size = new System.Drawing.Size(70, 31);
            this.ofbLabel.TabIndex = 0;
            this.ofbLabel.Text = "OFB";
            // 
            // fileTbx
            // 
            this.fileTbx.Enabled = false;
            this.fileTbx.Location = new System.Drawing.Point(153, 149);
            this.fileTbx.Margin = new System.Windows.Forms.Padding(2);
            this.fileTbx.Name = "fileTbx";
            this.fileTbx.Size = new System.Drawing.Size(291, 20);
            this.fileTbx.TabIndex = 2;
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(230, 103);
            this.fileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(130, 19);
            this.fileBtn.TabIndex = 3;
            this.fileBtn.Text = "Select from file system...";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.FileBtn_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "Image file|*.bmp";
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialog_FileOk);
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(239, 214);
            this.actionButton.Margin = new System.Windows.Forms.Padding(2);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(103, 41);
            this.actionButton.TabIndex = 4;
            this.actionButton.Text = "Akcija";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // OFB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 309);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.fileTbx);
            this.Controls.Add(this.ofbLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OFB";
            this.Text = "OFB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ofbLabel;
        private System.Windows.Forms.TextBox fileTbx;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button actionButton;
    }
}