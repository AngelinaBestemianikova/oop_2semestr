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
            this.labelForCourse = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фиоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийБаллToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диапазонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.годToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.стажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCourse)).BeginInit();
            this.menuStrip2.SuspendLayout();
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
            this.buttonAddress.Location = new System.Drawing.Point(205, 475);
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
            this.buttonSaveToFile.Location = new System.Drawing.Point(393, 475);
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
            this.textBoxFirstname.Location = new System.Drawing.Point(12, 101);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(173, 26);
            this.textBoxFirstname.TabIndex = 35;
            // 
            // buttonJob
            // 
            this.buttonJob.Location = new System.Drawing.Point(17, 475);
            this.buttonJob.Name = "buttonJob";
            this.buttonJob.Size = new System.Drawing.Size(182, 46);
            this.buttonJob.TabIndex = 60;
            this.buttonJob.Text = "Заполнить работу";
            this.buttonJob.UseVisualStyleBackColor = true;
            this.buttonJob.Click += new System.EventHandler(this.buttonJob_Click);
            // 
            // labelForCourse
            // 
            this.labelForCourse.AutoSize = true;
            this.labelForCourse.Location = new System.Drawing.Point(593, 269);
            this.labelForCourse.Name = "labelForCourse";
            this.labelForCourse.Size = new System.Drawing.Size(0, 20);
            this.labelForCourse.TabIndex = 64;
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.сортировкаПоToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1055, 33);
            this.menuStrip2.TabIndex = 65;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фиоToolStripMenuItem,
            this.специальностьToolStripMenuItem,
            this.курсToolStripMenuItem,
            this.среднийБаллToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.menuToolStripMenuItem.Text = "поиск";
            // 
            // фиоToolStripMenuItem
            // 
            this.фиоToolStripMenuItem.Name = "фиоToolStripMenuItem";
            this.фиоToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.фиоToolStripMenuItem.Text = "фио";
            // 
            // специальностьToolStripMenuItem
            // 
            this.специальностьToolStripMenuItem.Name = "специальностьToolStripMenuItem";
            this.специальностьToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.специальностьToolStripMenuItem.Text = "специальность";
            // 
            // курсToolStripMenuItem
            // 
            this.курсToolStripMenuItem.Name = "курсToolStripMenuItem";
            this.курсToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.курсToolStripMenuItem.Text = "курс";
            // 
            // среднийБаллToolStripMenuItem
            // 
            this.среднийБаллToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nToolStripMenuItem,
            this.диапазонToolStripMenuItem});
            this.среднийБаллToolStripMenuItem.Name = "среднийБаллToolStripMenuItem";
            this.среднийБаллToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.среднийБаллToolStripMenuItem.Text = "средний балл";
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.nToolStripMenuItem.Text = "> n";
            // 
            // диапазонToolStripMenuItem
            // 
            this.диапазонToolStripMenuItem.Name = "диапазонToolStripMenuItem";
            this.диапазонToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.диапазонToolStripMenuItem.Text = "диапазон";
            // 
            // сортировкаПоToolStripMenuItem
            // 
            this.сортировкаПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.годToolStripMenuItem,
            this.фамилияToolStripMenuItem,
            this.специальностьToolStripMenuItem1,
            this.стажToolStripMenuItem,
            this.группаToolStripMenuItem,
            this.курсToolStripMenuItem1});
            this.сортировкаПоToolStripMenuItem.Name = "сортировкаПоToolStripMenuItem";
            this.сортировкаПоToolStripMenuItem.Size = new System.Drawing.Size(151, 29);
            this.сортировкаПоToolStripMenuItem.Text = "сортировка по";
            // 
            // годToolStripMenuItem
            // 
            this.годToolStripMenuItem.Name = "годToolStripMenuItem";
            this.годToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.годToolStripMenuItem.Text = "год";
            // 
            // фамилияToolStripMenuItem
            // 
            this.фамилияToolStripMenuItem.Name = "фамилияToolStripMenuItem";
            this.фамилияToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.фамилияToolStripMenuItem.Text = "фамилия";
            // 
            // специальностьToolStripMenuItem1
            // 
            this.специальностьToolStripMenuItem1.Name = "специальностьToolStripMenuItem1";
            this.специальностьToolStripMenuItem1.Size = new System.Drawing.Size(234, 34);
            this.специальностьToolStripMenuItem1.Text = "специальность";
            // 
            // стажToolStripMenuItem
            // 
            this.стажToolStripMenuItem.Name = "стажToolStripMenuItem";
            this.стажToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.стажToolStripMenuItem.Text = "стаж";
            // 
            // группаToolStripMenuItem
            // 
            this.группаToolStripMenuItem.Name = "группаToolStripMenuItem";
            this.группаToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.группаToolStripMenuItem.Text = "группа";
            // 
            // курсToolStripMenuItem1
            // 
            this.курсToolStripMenuItem1.Name = "курсToolStripMenuItem1";
            this.курсToolStripMenuItem1.Size = new System.Drawing.Size(234, 34);
            this.курсToolStripMenuItem1.Text = "курс";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.сохранитьToolStripMenuItem.Text = "сохранить";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.оПрограммеToolStripMenuItem.Text = "о программе";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 533);
            this.Controls.Add(this.labelForCourse);
            this.Controls.Add(this.buttonJob);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSpec);
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
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "StudentForm";
            this.Text = "Student Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCourse)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxMath;
        private System.Windows.Forms.CheckBox checkBoxRussian;
        private System.Windows.Forms.CheckBox checkBoxHistory;
        private System.Windows.Forms.ComboBox comboBoxSpec;
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
        private System.Windows.Forms.Label labelForCourse;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фиоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийБаллToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диапазонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фамилияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem стажToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

