
namespace FormaWFC
{
    partial class XXTEA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTbx = new System.Windows.Forms.TextBox();
            this.resultTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.actionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(248, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "XXTEA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tekst";
            // 
            // inputTbx
            // 
            this.inputTbx.Location = new System.Drawing.Point(55, 103);
            this.inputTbx.Margin = new System.Windows.Forms.Padding(2);
            this.inputTbx.Multiline = true;
            this.inputTbx.Name = "inputTbx";
            this.inputTbx.Size = new System.Drawing.Size(488, 162);
            this.inputTbx.TabIndex = 2;
            // 
            // resultTbx
            // 
            this.resultTbx.Location = new System.Drawing.Point(55, 387);
            this.resultTbx.Margin = new System.Windows.Forms.Padding(2);
            this.resultTbx.Multiline = true;
            this.resultTbx.Name = "resultTbx";
            this.resultTbx.Size = new System.Drawing.Size(488, 162);
            this.resultTbx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rezultat";
            // 
            // actionButton
            // 
            this.actionButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.actionButton.Location = new System.Drawing.Point(195, 288);
            this.actionButton.Margin = new System.Windows.Forms.Padding(2);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(188, 66);
            this.actionButton.TabIndex = 6;
            this.actionButton.Text = "Akcija";
            this.actionButton.UseVisualStyleBackColor = false;
            this.actionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // XXTEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 560);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultTbx);
            this.Controls.Add(this.inputTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "XXTEA";
            this.Text = "XXTEA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTbx;
        private System.Windows.Forms.TextBox resultTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button actionButton;
    }
}