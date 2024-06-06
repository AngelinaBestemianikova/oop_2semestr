using Lab_2_final.Models;
using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_2_final
{
    public partial class StudentForm : Form
    {
        private Student student;
        private string pathToFile;

        public StudentForm()
        {
            InitializeComponent();

            student = new Student();
            pathToFile = Path.Combine(Environment.CurrentDirectory, "student_data.json");
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text))
                {
                    MessageBox.Show("Поле 'Имя' пустое. Введите имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                student.Name = textBoxName.Text;
                if (Regex.IsMatch(student.Name, @"\d"))
                {
                    MessageBox.Show("Поле 'Имя' должно содеражать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(textBoxFirstname.Text))
                {
                    MessageBox.Show("Поле 'Фамилия' пустое. Введите фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                student.FirstName = textBoxFirstname.Text;
                if (Regex.IsMatch(student.FirstName, @"\d"))
                {
                    MessageBox.Show("Поле 'Фамилия' должно содеражать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                student.LastName = textBoxLastname.Text;

                if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
                {
                    MessageBox.Show("Выберите пол", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                student.Gender = radioButtonMale.Checked ? "Male" : "Female";

                var studentAge = int.Parse(textBoxAge.Text);
                if(studentAge > 15 && studentAge < 100)
                {
                    student.Age = studentAge;
                }
                else
                {
                    MessageBox.Show("Заполните возраст числом от 16 и до 100", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(comboBoxSpec.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Выберите специальность"); return;
                }     

                student.Specialty = comboBoxSpec.SelectedItem?.ToString();
                student.Course = trackBarCourse.Value;
                student.Group = int.Parse(textBoxGroup.Text);

                var averageScore = double.Parse(textBoxAverage.Text);
                if (student.Age - student.Course < 16)
                {
                    MessageBox.Show($"С возрастом {textBoxAge.Text} нельзя быть на {trackBarCourse.Value} курсе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (averageScore > 1 && averageScore <= 10)
                {
                    student.AverageScore = averageScore;
                }
                else
                {
                    MessageBox.Show("Заполните средний балл числом от 1 до 10", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                student.IsMathPassed = checkBoxMath.Checked;
                student.IsRussianPassed = checkBoxRussian.Checked;
                student.IsHistoryPassed = checkBoxHistory.Checked;

                if ((int.Parse(textBoxAge.Text) - student.Job.Year) <= 14)
                {
                    MessageBox.Show("Стаж не может быть таким", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля корректными данными", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var jsonStringStudent = JsonSerializer.Serialize(student);

            var streamWriter = new StreamWriter(pathToFile);
            streamWriter.Write(jsonStringStudent);
            streamWriter.Flush();
            streamWriter.Close();

            MessageBox.Show($"Файл успешно сохранен.\nПуть: {pathToFile}", "Сохранение в файл", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(fileDialog.FileName);
                student.PathToPhoto = fileDialog.FileName;
            }
        }

        private void buttonAddress_Click(object sender, EventArgs e)
        {          
            var addressForm = new AddressForm(student.Address);
            addressForm.ShowDialog();
            student.Address = addressForm.Address;          
        }

        private void buttonJob_Click(object sender, EventArgs e)
        {
            var jobForm = new JobForm(student.Job);         
            jobForm.ShowDialog();
            student.Job = jobForm.Job;         
        }
        private void buttonOutput_Click(object sender, EventArgs e)
        {
            var streamReader = new StreamReader(pathToFile);
            var jsonStringStudent = streamReader.ReadToEnd();
            streamReader.Close();

            student = JsonSerializer.Deserialize<Student>(jsonStringStudent);

            textBoxName.Text = student.Name;
            textBoxLastname.Text = student.LastName;
            textBoxFirstname.Text = student.FirstName;

            if (student.Gender == "Male")
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }

            textBoxAge.Text = student.Age.ToString();
            comboBoxSpec.SelectedItem = student.Specialty;
            trackBarCourse.Value = student.Course;
            textBoxGroup.Text = student.Group.ToString();
            textBoxAverage.Text = student.AverageScore.ToString();
            checkBoxMath.Checked = student.IsMathPassed;
            checkBoxRussian.Checked = student.IsRussianPassed;
            checkBoxHistory.Checked = student.IsHistoryPassed;
            pictureBox.Image = Image.FromFile(student.PathToPhoto);
            labelForCourse.Text = student.Course.ToString();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уже на этой странице", "Меню", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void jobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var jobForm = new JobForm(student.Job);
            jobForm.ShowDialog();
            student.Job = jobForm.Job;
        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addressForm = new AddressForm(student.Address);
            addressForm.ShowDialog();
            student.Address = addressForm.Address;
        }

        private void trackBarCourse_Scroll(object sender, EventArgs e)
        {
            labelForCourse.Text = trackBarCourse.Value.ToString();
        }
    }
}