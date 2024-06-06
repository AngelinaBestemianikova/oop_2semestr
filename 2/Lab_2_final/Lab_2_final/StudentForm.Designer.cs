namespace Lab_2_final
{
    partial class StudentForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMath = new System.Windows.Forms.CheckBox();
            this.checkBoxRussian = new System.Windows.Forms.CheckBox();
            this.checkBoxHistory = new System.Windows.Forms.CheckBox();
            this.comboBoxSpec = new System.Windows.Forms.ComboBox();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAddress = new System.Windows.Forms.Button();
            this.labelAverage = new System.Windows.Forms.Label();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.trackBarCourse = new System.Windows.Forms.TrackBar();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelSpec = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.buttonJob = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelForCourse = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCourse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMath);
            this.groupBox1.Controls.Add(this.checkBoxRussian);
            this.groupBox1.Controls.Add(this.checkBoxHistory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(227, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 132);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Предметы";
            // 
            // checkBoxMath
            // 
            this.checkBoxMath.AutoSize = true;
            this.checkBoxMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBoxMath.Location = new System.Drawing.Point(6, 71);
            this.checkBoxMath.Name = "checkBoxMath";
            this.checkBoxMath.Size = new System.Drawing.Size(130, 24);
            this.checkBoxMath.TabIndex = 26;
            this.checkBoxMath.Text = "Математика";
            this.checkBoxMath.UseVisualStyleBackColor = true;
            // 
            // checkBoxRussian
            // 
            this.checkBoxRussian.AutoSize = true;
            this.checkBoxRussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBoxRussian.Location = new System.Drawing.Point(6, 40);
            this.checkBoxRussian.Name = "checkBoxRussian";
            this.checkBoxRussian.Size = new System.Drawing.Size(94, 24);
            this.checkBoxRussian.TabIndex = 25;
            this.checkBoxRussian.Text = "Русский";
            this.checkBoxRussian.UseVisualStyleBackColor = true;
            // 
            // checkBoxHistory
            // 
            this.checkBoxHistory.AutoSize = true;
            this.checkBoxHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBoxHistory.Location = new System.Drawing.Point(6, 101);
            this.checkBoxHistory.Name = "checkBoxHistory";
            this.checkBoxHistory.Size = new System.Drawing.Size(99, 24);
            this.checkBoxHistory.TabIndex = 28;
            this.checkBoxHistory.Text = "История";
            this.checkBoxHistory.UseVisualStyleBackColor = true;
            // 
            // comboBoxSpec
            // 
            this.comboBoxSpec.FormattingEnabled = true;
            this.comboBoxSpec.Items.AddRange(new object[] {
            "Военный",
            "Исторический",
            "Экономический",
            "Химический"});
            this.comboBoxSpec.Location = new System.Drawing.Point(474, 103);
            this.comboBoxSpec.Name = "comboBoxSpec";
            this.comboBoxSpec.Size = new System.Drawing.Size(112, 28);
            this.comboBoxSpec.TabIndex = 58;
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(942, 546);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(171, 46);
            this.buttonOutput.TabIndex = 57;
            this.buttonOutput.Text = "Вывести данные";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Location = new System.Drawing.Point(766, 292);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(268, 46);
            this.buttonPhoto.TabIndex = 56;
            this.buttonPhoto.Text = "Закрузить фото";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(766, 65);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(268, 201);
            this.pictureBox.TabIndex = 55;
            this.pictureBox.TabStop = false;
            // 
            // buttonAddress
            // 
            this.buttonAddress.Location = new System.Drawing.Point(551, 546);
            this.buttonAddress.Name = "buttonAddress";
            this.buttonAddress.Size = new System.Drawing.Size(182, 46);
            this.buttonAddress.TabIndex = 54;
            this.buttonAddress.Text = "Заполнить адрес";
            this.buttonAddress.UseVisualStyleBackColor = true;
            this.buttonAddress.Click += new System.EventHandler(this.buttonAddress_Click);
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAverage.Location = new System.Drawing.Point(228, 342);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(180, 29);
            this.labelAverage.TabIndex = 53;
            this.labelAverage.Text = "Средний балл";
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(233, 388);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.Size = new System.Drawing.Size(102, 26);
            this.textBoxAverage.TabIndex = 52;
            // 
            // trackBarCourse
            // 
            this.trackBarCourse.Location = new System.Drawing.Point(472, 264);
            this.trackBarCourse.Maximum = 5;
            this.trackBarCourse.Minimum = 1;
            this.trackBarCourse.Name = "trackBarCourse";
            this.trackBarCourse.Size = new System.Drawing.Size(104, 69);
            this.trackBarCourse.TabIndex = 51;
            this.trackBarCourse.Value = 1;
            this.trackBarCourse.Scroll += new System.EventHandler(this.trackBarCourse_Scroll);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(753, 546);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(166, 46);
            this.buttonSaveToFile.TabIndex = 50;
            this.buttonSaveToFile.Text = "Сохранить в файл";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(17, 292);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMale.TabIndex = 48;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(17, 258);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(87, 24);
            this.radioButtonFemale.TabIndex = 47;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Пол";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(233, 264);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(102, 26);
            this.textBoxGroup.TabIndex = 44;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(17, 388);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(102, 26);
            this.textBoxAge.TabIndex = 43;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelGroup.Location = new System.Drawing.Point(228, 218);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(95, 29);
            this.labelGroup.TabIndex = 42;
            this.labelGroup.Text = "Группа";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCourse.Location = new System.Drawing.Point(467, 218);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(66, 29);
            this.labelCourse.TabIndex = 41;
            this.labelCourse.Text = "Курс";
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSpec.Location = new System.Drawing.Point(467, 65);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(119, 29);
            this.labelSpec.TabIndex = 40;
            this.labelSpec.Text = "Спец-сть";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAge.Location = new System.Drawing.Point(12, 342);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(107, 29);
            this.labelAge.TabIndex = 39;
            this.labelAge.Text = "Возраст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "ФИО";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(12, 171);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(173, 26);
            this.textBoxLastname.TabIndex = 37;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 133);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(173, 26);
            this.textBoxName.TabIndex = 36;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(12, 98);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(173, 26);
            this.textBoxFirstname.TabIndex = 35;
            // 
            // buttonJob
            // 
            this.buttonJob.Location = new System.Drawing.Point(353, 546);
            this.buttonJob.Name = "buttonJob";
            this.buttonJob.Size = new System.Drawing.Size(182, 46);
            this.buttonJob.TabIndex = 60;
            this.buttonJob.Text = "Заполнить работу";
            this.buttonJob.UseVisualStyleBackColor = true;
            this.buttonJob.Click += new System.EventHandler(this.buttonJob_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 36);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormToolStripMenuItem
            // 
            this.FormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.jobToolStripMenuItem,
            this.addressToolStripMenuItem});
            this.FormToolStripMenuItem.Name = "FormToolStripMenuItem";
            this.FormToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.FormToolStripMenuItem.Text = "Формы";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.studentToolStripMenuItem.Text = "студент";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // jobToolStripMenuItem
            // 
            this.jobToolStripMenuItem.Name = "jobToolStripMenuItem";
            this.jobToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.jobToolStripMenuItem.Text = "работа";
            this.jobToolStripMenuItem.Click += new System.EventHandler(this.jobToolStripMenuItem_Click);
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.CheckOnClick = true;
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addressToolStripMenuItem.Text = "адрес";
            this.addressToolStripMenuItem.Click += new System.EventHandler(this.addressToolStripMenuItem_Click);
            // 
            // labelForCourse
            // 
            this.labelForCourse.AutoSize = true;
            this.labelForCourse.Location = new System.Drawing.Point(593, 269);
            this.labelForCourse.Name = "labelForCourse";
            this.labelForCourse.Size = new System.Drawing.Size(0, 20);
            this.labelForCourse.TabIndex = 64;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 628);
            this.Controls.Add(this.labelForCourse);
            this.Controls.Add(this.buttonJob);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSpec);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonAddress);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.textBoxAverage);
            this.Controls.Add(this.trackBarCourse);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCourse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxMath;
        private System.Windows.Forms.CheckBox checkBoxRussian;
        private System.Windows.Forms.CheckBox checkBoxHistory;
        private System.Windows.Forms.ComboBox comboBoxSpec;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonAddress;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.TrackBar trackBarCourse;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Button buttonJob;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.Label labelForCourse;
    }
}

