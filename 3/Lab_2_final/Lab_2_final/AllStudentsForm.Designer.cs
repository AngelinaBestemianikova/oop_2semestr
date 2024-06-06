namespace Lab_2_final
{
    partial class AllStudentsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllStudentsForm));
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonOutputStudents = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOutputFormattedStudents = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSort = new System.Windows.Forms.ToolStripButton();
            this.toolStripClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripFarward = new System.Windows.Forms.ToolStripButton();
            this.toolStripBack = new System.Windows.Forms.ToolStripButton();
            this.buttonShowCloseTools = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsNumberOfStudents = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 20;
            this.lbStudents.Location = new System.Drawing.Point(12, 112);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(638, 604);
            this.lbStudents.TabIndex = 0;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(656, 114);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(191, 50);
            this.buttonAddStudent.TabIndex = 1;
            this.buttonAddStudent.Text = "Добавить студента";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonOutputStudents
            // 
            this.buttonOutputStudents.Location = new System.Drawing.Point(656, 170);
            this.buttonOutputStudents.Name = "buttonOutputStudents";
            this.buttonOutputStudents.Size = new System.Drawing.Size(191, 50);
            this.buttonOutputStudents.TabIndex = 2;
            this.buttonOutputStudents.Text = "Вывести данные";
            this.buttonOutputStudents.UseVisualStyleBackColor = true;
            this.buttonOutputStudents.Click += new System.EventHandler(this.buttonOutputStudents_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.sortingToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.aboutProgrammToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(859, 33);
            this.menuStrip2.TabIndex = 66;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.searchToolStripMenuItem.Text = "поиск";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // sortingToolStripMenuItem
            // 
            this.sortingToolStripMenuItem.Name = "sortingToolStripMenuItem";
            this.sortingToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.sortingToolStripMenuItem.Text = "сортировка";
            this.sortingToolStripMenuItem.Click += new System.EventHandler(this.sortingToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.saveToFileToolStripMenuItem.Text = "сохранить";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // aboutProgrammToolStripMenuItem
            // 
            this.aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            this.aboutProgrammToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.aboutProgrammToolStripMenuItem.Text = "о программе";
            this.aboutProgrammToolStripMenuItem.Click += new System.EventHandler(this.aboutProgrammToolStripMenuItem_Click);
            // 
            // buttonOutputFormattedStudents
            // 
            this.buttonOutputFormattedStudents.Location = new System.Drawing.Point(656, 226);
            this.buttonOutputFormattedStudents.Name = "buttonOutputFormattedStudents";
            this.buttonOutputFormattedStudents.Size = new System.Drawing.Size(191, 76);
            this.buttonOutputFormattedStudents.TabIndex = 68;
            this.buttonOutputFormattedStudents.Text = "Вывести отформатированные данные";
            this.buttonOutputFormattedStudents.UseVisualStyleBackColor = true;
            this.buttonOutputFormattedStudents.Click += new System.EventHandler(this.buttonOutputFormattedStudents_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSearch,
            this.toolStripSort,
            this.toolStripClear,
            this.toolStripDelete,
            this.toolStripFarward,
            this.toolStripBack});
            this.toolStrip.Location = new System.Drawing.Point(0, 33);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(859, 33);
            this.toolStrip.TabIndex = 69;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSearch.Image")));
            this.toolStripSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(34, 28);
            this.toolStripSearch.Text = "поиск";
            this.toolStripSearch.Click += new System.EventHandler(this.toolStripSearch_Click);
            // 
            // toolStripSort
            // 
            this.toolStripSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSort.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSort.Image")));
            this.toolStripSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSort.Name = "toolStripSort";
            this.toolStripSort.Size = new System.Drawing.Size(34, 28);
            this.toolStripSort.Text = "сортировка";
            this.toolStripSort.Click += new System.EventHandler(this.toolStripSort_Click);
            // 
            // toolStripClear
            // 
            this.toolStripClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripClear.Image")));
            this.toolStripClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClear.Name = "toolStripClear";
            this.toolStripClear.Size = new System.Drawing.Size(34, 28);
            this.toolStripClear.Text = "очистить";
            this.toolStripClear.Click += new System.EventHandler(this.toolStripClear_Click);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDelete.Image")));
            this.toolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(34, 28);
            this.toolStripDelete.Text = "удалить";
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // toolStripFarward
            // 
            this.toolStripFarward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFarward.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFarward.Image")));
            this.toolStripFarward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFarward.Name = "toolStripFarward";
            this.toolStripFarward.Size = new System.Drawing.Size(34, 28);
            this.toolStripFarward.Text = "вперед";
            this.toolStripFarward.Click += new System.EventHandler(this.toolStripFarward_Click);
            // 
            // toolStripBack
            // 
            this.toolStripBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBack.Image")));
            this.toolStripBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBack.Name = "toolStripBack";
            this.toolStripBack.Size = new System.Drawing.Size(34, 28);
            this.toolStripBack.Text = "назад";
            this.toolStripBack.Click += new System.EventHandler(this.toolStripBack_Click);
            // 
            // buttonShowCloseTools
            // 
            this.buttonShowCloseTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowCloseTools.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowCloseTools.Image")));
            this.buttonShowCloseTools.Location = new System.Drawing.Point(797, 40);
            this.buttonShowCloseTools.Name = "buttonShowCloseTools";
            this.buttonShowCloseTools.Size = new System.Drawing.Size(48, 48);
            this.buttonShowCloseTools.TabIndex = 70;
            this.buttonShowCloseTools.UseVisualStyleBackColor = true;
            this.buttonShowCloseTools.Click += new System.EventHandler(this.buttonShowCloseTools_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNumberOfStudents,
            this.tsLastAction,
            this.tsDateTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 714);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(859, 32);
            this.statusStrip.TabIndex = 71;
            this.statusStrip.Text = "statusStrip";
            // 
            // tsNumberOfStudents
            // 
            this.tsNumberOfStudents.Name = "tsNumberOfStudents";
            this.tsNumberOfStudents.Size = new System.Drawing.Size(180, 25);
            this.tsNumberOfStudents.Text = "tsNumberOfStudents";
            // 
            // tsLastAction
            // 
            this.tsLastAction.Name = "tsLastAction";
            this.tsLastAction.Size = new System.Drawing.Size(179, 25);
            this.tsLastAction.Text = "toolStripStatusLabel2";
            // 
            // tsDateTime
            // 
            this.tsDateTime.Name = "tsDateTime";
            this.tsDateTime.Size = new System.Drawing.Size(179, 25);
            this.tsDateTime.Text = "toolStripStatusLabel3";
            this.tsDateTime.Click += new System.EventHandler(this.tsDateTime_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AllStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 746);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonShowCloseTools);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.buttonOutputFormattedStudents);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.buttonOutputStudents);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.lbStudents);
            this.Name = "AllStudentsForm";
            this.Text = "Students Form";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonOutputStudents;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingToolStripMenuItem;
        private System.Windows.Forms.Button buttonOutputFormattedStudents;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripSearch;
        private System.Windows.Forms.ToolStripButton toolStripSort;
        private System.Windows.Forms.ToolStripButton toolStripClear;
        private System.Windows.Forms.ToolStripButton toolStripDelete;
        private System.Windows.Forms.ToolStripButton toolStripFarward;
        private System.Windows.Forms.ToolStripButton toolStripBack;
        private System.Windows.Forms.Button buttonShowCloseTools;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsNumberOfStudents;
        private System.Windows.Forms.ToolStripStatusLabel tsLastAction;
        private System.Windows.Forms.ToolStripStatusLabel tsDateTime;
        private System.Windows.Forms.Timer timer;
    }
}