namespace Lab_2_final
{
    partial class JobForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonBackToHome2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(971, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(50, 335);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(208, 26);
            this.textBoxYear.TabIndex = 2;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(50, 224);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(208, 26);
            this.textBoxPosition.TabIndex = 3;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(50, 114);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(208, 26);
            this.textBoxCompany.TabIndex = 4;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCompany.Location = new System.Drawing.Point(44, 61);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(133, 29);
            this.labelCompany.TabIndex = 5;
            this.labelCompany.Text = "Компания";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPosition.Location = new System.Drawing.Point(44, 170);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(142, 29);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "Должность";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelYear.Location = new System.Drawing.Point(44, 281);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(73, 29);
            this.labelYear.TabIndex = 7;
            this.labelYear.Text = "Стаж";
            // 
            // buttonBackToHome2
            // 
            this.buttonBackToHome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonBackToHome2.Location = new System.Drawing.Point(60, 459);
            this.buttonBackToHome2.Name = "buttonBackToHome2";
            this.buttonBackToHome2.Size = new System.Drawing.Size(304, 45);
            this.buttonBackToHome2.TabIndex = 8;
            this.buttonBackToHome2.Text = "Вернуться на главную";
            this.buttonBackToHome2.UseVisualStyleBackColor = true;
            this.buttonBackToHome2.Click += new System.EventHandler(this.buttonBackToHome2_Click);
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 551);
            this.Controls.Add(this.buttonBackToHome2);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.button1);
            this.Name = "JobForm";
            this.Text = "JobForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonBackToHome2;
    }
}