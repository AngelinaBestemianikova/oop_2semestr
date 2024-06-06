namespace Lab_2_final
{
    partial class AddressForm
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
            this.textBoxFlat = new System.Windows.Forms.TextBox();
            this.labelFlat = new System.Windows.Forms.Label();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.labelHouse = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.Location = new System.Drawing.Point(17, 396);
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.Size = new System.Drawing.Size(102, 26);
            this.textBoxFlat.TabIndex = 31;
            // 
            // labelFlat
            // 
            this.labelFlat.AutoSize = true;
            this.labelFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFlat.Location = new System.Drawing.Point(12, 350);
            this.labelFlat.Name = "labelFlat";
            this.labelFlat.Size = new System.Drawing.Size(123, 29);
            this.labelFlat.TabIndex = 30;
            this.labelFlat.Text = "Квартира";
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Location = new System.Drawing.Point(17, 310);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(102, 26);
            this.textBoxHouse.TabIndex = 29;
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHouse.Location = new System.Drawing.Point(12, 264);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(61, 29);
            this.labelHouse.TabIndex = 28;
            this.labelHouse.Text = "Дом";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(17, 223);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(102, 26);
            this.textBoxStreet.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Улица";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(17, 140);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(102, 26);
            this.textBoxIndex.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Индекс";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(17, 55);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(102, 26);
            this.textBoxCity.TabIndex = 23;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCity.Location = new System.Drawing.Point(12, 9);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(83, 29);
            this.labelCity.TabIndex = 22;
            this.labelCity.Text = "Город";
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.Location = new System.Drawing.Point(12, 484);
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.Size = new System.Drawing.Size(460, 46);
            this.buttonBackToHome.TabIndex = 32;
            this.buttonBackToHome.Text = "Вернуться на главную";
            this.buttonBackToHome.UseVisualStyleBackColor = true;
            this.buttonBackToHome.Click += new System.EventHandler(this.buttonBackToHome_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 542);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.textBoxFlat);
            this.Controls.Add(this.labelFlat);
            this.Controls.Add(this.textBoxHouse);
            this.Controls.Add(this.labelHouse);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Name = "AddressForm";
            this.Text = "Address Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFlat;
        private System.Windows.Forms.Label labelFlat;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button buttonBackToHome;
    }
}