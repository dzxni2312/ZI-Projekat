
namespace FormaWFC
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
            this.actionLabel = new System.Windows.Forms.Label();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.actionBox = new System.Windows.Forms.ComboBox();
            this.algorithmBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.actionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionLabel.Location = new System.Drawing.Point(238, 83);
            this.actionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(125, 25);
            this.actionLabel.TabIndex = 1;
            this.actionLabel.Text = "Izaberi akciju";
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.AutoSize = true;
            this.algorithmLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.algorithmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmLabel.Location = new System.Drawing.Point(227, 180);
            this.algorithmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(154, 25);
            this.algorithmLabel.TabIndex = 2;
            this.algorithmLabel.Text = "Izaberi algoritam";
            // 
            // actionBox
            // 
            this.actionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionBox.FormattingEnabled = true;
            this.actionBox.Items.AddRange(new object[] {
            "Encryption",
            "Decryption"});
            this.actionBox.Location = new System.Drawing.Point(147, 132);
            this.actionBox.Margin = new System.Windows.Forms.Padding(2);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(324, 33);
            this.actionBox.TabIndex = 3;
            this.actionBox.SelectedIndexChanged += new System.EventHandler(this.ActionBox_SelectedIndexChanged);
            // 
            // algorithmBox
            // 
            this.algorithmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmBox.FormattingEnabled = true;
            this.algorithmBox.Items.AddRange(new object[] {
            "One-time-pad",
            "Four-Square Cipher",
            "XXTEA",
            "OFB"});
            this.algorithmBox.Location = new System.Drawing.Point(147, 238);
            this.algorithmBox.Margin = new System.Windows.Forms.Padding(2);
            this.algorithmBox.Name = "algorithmBox";
            this.algorithmBox.Size = new System.Drawing.Size(324, 33);
            this.algorithmBox.TabIndex = 4;
            this.algorithmBox.SelectedIndexChanged += new System.EventHandler(this.AlgorithmBox_SelectedIndexChanged);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(232, 301);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(162, 44);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Dalje";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 375);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.algorithmBox);
            this.Controls.Add(this.actionBox);
            this.Controls.Add(this.algorithmLabel);
            this.Controls.Add(this.actionLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.ComboBox actionBox;
        private System.Windows.Forms.ComboBox algorithmBox;
        private System.Windows.Forms.Button okButton;
    }
}

