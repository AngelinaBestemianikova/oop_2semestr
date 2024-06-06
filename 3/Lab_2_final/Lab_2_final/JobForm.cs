using Lab_2_final.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_final
{
    public partial class JobForm : Form
    {
        public JobForm(Job job)
        {
            InitializeComponent();

            if (job != null)
            {
                textBoxCompany.Text = job.Company.ToString();
                textBoxPosition.Text = job.Position.ToString();
                textBoxYear.Text = job.Year.ToString();
            }
        }


        internal Job Job { get; set; }

        private void buttonBackToHome2_Click(object sender, EventArgs e)
        {
            try
            {
                Job = new Job
                {
                    Company = textBoxCompany.Text,
                    Position = textBoxPosition.Text,
                };

                if (string.IsNullOrEmpty(textBoxYear.Text))
                {
                    Job.Year = null;
                }
                else
                {
                    Job.Year = int.Parse(textBoxYear.Text);
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля корректными данными", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Close();
        }
    }
}
