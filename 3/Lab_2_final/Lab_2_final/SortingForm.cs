using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_final
{
    public partial class SortingForm : Form
    {
        public SortingForm()
        {
            InitializeComponent();
        }

        public bool GroupAscending { get; set; }
        public bool GroupDescending { get; set; }
        public bool CourseAscending { get; set; }
        public bool CourseDescending { get; set; }
        public bool YearAscending { get; set; }
        public bool YearDescending { get; set; }

        private void buttonSorting_Click(object sender, EventArgs e)
        {
            if (rbCourseAscending.Checked)
            {
                CourseAscending = true;
            }
            else if (rbCourseDescending.Checked) 
            {
                CourseDescending = true;    
            }

            if (rbGroupAscending.Checked)
            {
                GroupAscending = true;
            }
            else if (rbGroupDescending.Checked)
            {
                GroupDescending = true;
            }

            if (rbYearAscending.Checked)
            {
                YearAscending = true;
            }
            if ( rbYearDescending.Checked)
            {
                YearDescending = true;
            }

            Close();
        }
    }
}
