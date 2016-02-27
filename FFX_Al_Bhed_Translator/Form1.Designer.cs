namespace FFX_Al_Bhed_Translator
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
            this.informationLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.englishToAlBhedButton = new System.Windows.Forms.Button();
            this.alBhedToEnglishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(12, 31);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(201, 13);
            this.informationLabel.TabIndex = 0;
            this.informationLabel.Text = "Enter the sentence you want to translate:";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(219, 28);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(175, 20);
            this.inputBox.TabIndex = 1;
            // 
            // englishToAlBhedButton
            // 
            this.englishToAlBhedButton.Location = new System.Drawing.Point(15, 90);
            this.englishToAlBhedButton.Name = "englishToAlBhedButton";
            this.englishToAlBhedButton.Size = new System.Drawing.Size(158, 23);
            this.englishToAlBhedButton.TabIndex = 2;
            this.englishToAlBhedButton.Text = "Translate English to Al Bhed";
            this.englishToAlBhedButton.UseVisualStyleBackColor = true;
            this.englishToAlBhedButton.Click += new System.EventHandler(this.englishToAlBhedButton_Click);
            // 
            // alBhedToEnglishButton
            // 
            this.alBhedToEnglishButton.Location = new System.Drawing.Point(234, 90);
            this.alBhedToEnglishButton.Name = "alBhedToEnglishButton";
            this.alBhedToEnglishButton.Size = new System.Drawing.Size(160, 23);
            this.alBhedToEnglishButton.TabIndex = 3;
            this.alBhedToEnglishButton.Text = "Translate Al Bhed to English";
            this.alBhedToEnglishButton.UseVisualStyleBackColor = true;
            this.alBhedToEnglishButton.Click += new System.EventHandler(this.alBhedToEnglishButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 137);
            this.Controls.Add(this.alBhedToEnglishButton);
            this.Controls.Add(this.englishToAlBhedButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.informationLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button englishToAlBhedButton;
        private System.Windows.Forms.Button alBhedToEnglishButton;
    }
}

