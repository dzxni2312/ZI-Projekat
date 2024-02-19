
namespace FormaWFC
{
    partial class Foursquare
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
            this.FourSquareLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FourSquareLabel
            // 
            this.FourSquareLabel.AutoSize = true;
            this.FourSquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourSquareLabel.Location = new System.Drawing.Point(173, 27);
            this.FourSquareLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FourSquareLabel.Name = "FourSquareLabel";
            this.FourSquareLabel.Size = new System.Drawing.Size(253, 31);
            this.FourSquareLabel.TabIndex = 0;
            this.FourSquareLabel.Text = "Four-Square Cipher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tekst";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(137, 140);
            this.InputBox.Margin = new System.Windows.Forms.Padding(2);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(380, 20);
            this.InputBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rezultat";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(137, 217);
            this.ResultBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(380, 20);
            this.ResultBox.TabIndex = 5;
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(228, 266);
            this.actionButton.Margin = new System.Windows.Forms.Padding(2);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(129, 55);
            this.actionButton.TabIndex = 6;
            this.actionButton.Text = "Akcija";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // Foursquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FourSquareLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Foursquare";
            this.Text = "Foursquare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FourSquareLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button actionButton;
    }
}