namespace Lab_2_final
{
    partial class SortingForm
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
            this.rbCourseAscending = new System.Windows.Forms.RadioButton();
            this.rbCourseDescending = new System.Windows.Forms.RadioButton();
            this.rbGroupDescending = new System.Windows.Forms.RadioButton();
            this.rbGroupAscending = new System.Windows.Forms.RadioButton();
            this.rbYearDescending = new System.Windows.Forms.RadioButton();
            this.rbYearAscending = new System.Windows.Forms.RadioButton();
            this.buttonSorting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbCourseAscending
            // 
            this.rbCourseAscending.AutoSize = true;
            this.rbCourseAscending.Location = new System.Drawing.Point(12, 66);
            this.rbCourseAscending.Name = "rbCourseAscending";
            this.rbCourseAscending.Size = new System.Drawing.Size(156, 24);
            this.rbCourseAscending.TabIndex = 1;
            this.rbCourseAscending.TabStop = true;
            this.rbCourseAscending.Text = "по возростанию";
            this.rbCourseAscending.UseVisualStyleBackColor = true;
            // 
            // rbCourseDescending
            // 
            this.rbCourseDescending.AutoSize = true;
            this.rbCourseDescending.Location = new System.Drawing.Point(12, 96);
            this.rbCourseDescending.Name = "rbCourseDescending";
            this.rbCourseDescending.Size = new System.Drawing.Size(131, 24);
            this.rbCourseDescending.TabIndex = 2;
            this.rbCourseDescending.TabStop = true;
            this.rbCourseDescending.Text = "по убыванию";
            this.rbCourseDescending.UseVisualStyleBackColor = true;
            // 
            // rbGroupDescending
            // 
            this.rbGroupDescending.AutoSize = true;
            this.rbGroupDescending.Location = new System.Drawing.Point(12, 241);
            this.rbGroupDescending.Name = "rbGroupDescending";
            this.rbGroupDescending.Size = new System.Drawing.Size(131, 24);
            this.rbGroupDescending.TabIndex = 5;
            this.rbGroupDescending.TabStop = true;
            this.rbGroupDescending.Text = "по убыванию";
            this.rbGroupDescending.UseVisualStyleBackColor = true;
            // 
            // rbGroupAscending
            // 
            this.rbGroupAscending.AutoSize = true;
            this.rbGroupAscending.Location = new System.Drawing.Point(12, 211);
            this.rbGroupAscending.Name = "rbGroupAscending";
            this.rbGroupAscending.Size = new System.Drawing.Size(156, 24);
            this.rbGroupAscending.TabIndex = 4;
            this.rbGroupAscending.TabStop = true;
            this.rbGroupAscending.Text = "по возростанию";
            this.rbGroupAscending.UseVisualStyleBackColor = true;
            // 
            // rbYearDescending
            // 
            this.rbYearDescending.AutoSize = true;
            this.rbYearDescending.Location = new System.Drawing.Point(12, 379);
            this.rbYearDescending.Name = "rbYearDescending";
            this.rbYearDescending.Size = new System.Drawing.Size(131, 24);
            this.rbYearDescending.TabIndex = 8;
            this.rbYearDescending.TabStop = true;
            this.rbYearDescending.Text = "по убыванию";
            this.rbYearDescending.UseVisualStyleBackColor = true;
            // 
            // rbYearAscending
            // 
            this.rbYearAscending.AutoSize = true;
            this.rbYearAscending.Location = new System.Drawing.Point(12, 349);
            this.rbYearAscending.Name = "rbYearAscending";
            this.rbYearAscending.Size = new System.Drawing.Size(156, 24);
            this.rbYearAscending.TabIndex = 7;
            this.rbYearAscending.TabStop = true;
            this.rbYearAscending.Text = "по возростанию";
            this.rbYearAscending.UseVisualStyleBackColor = true;
            // 
            // buttonSorting
            // 
            this.buttonSorting.Location = new System.Drawing.Point(12, 446);
            this.buttonSorting.Name = "buttonSorting";
            this.buttonSorting.Size = new System.Drawing.Size(339, 45);
            this.buttonSorting.TabIndex = 9;
            this.buttonSorting.Text = "Сортировать";
            this.buttonSorting.UseVisualStyleBackColor = true;
            this.buttonSorting.Click += new System.EventHandler(this.buttonSorting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сортировка по курсу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Сортировка по стажу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Сортировка по группе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "или";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "или";
            // 
            // SortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 507);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbYearAscending);
            this.Controls.Add(this.rbGroupAscending);
            this.Controls.Add(this.rbYearDescending);
            this.Controls.Add(this.rbCourseDescending);
            this.Controls.Add(this.rbGroupDescending);
            this.Controls.Add(this.rbCourseAscending);
            this.Controls.Add(this.buttonSorting);
            this.Name = "SortingForm";
            this.Text = "SortingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbCourseAscending;
        private System.Windows.Forms.RadioButton rbCourseDescending;
        private System.Windows.Forms.RadioButton rbGroupDescending;
        private System.Windows.Forms.RadioButton rbGroupAscending;
        private System.Windows.Forms.RadioButton rbYearDescending;
        private System.Windows.Forms.RadioButton rbYearAscending;
        private System.Windows.Forms.Button buttonSorting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}