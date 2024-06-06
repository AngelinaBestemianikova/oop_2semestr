using Lab_2_final.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_2_final
{
    public partial class AllStudentsForm : Form
    {
        private List<Student> _listOfStudents;
        private Memory _memory = new Memory();
        private string _lastAction = "";

        public AllStudentsForm()
        {
            InitializeComponent();
            LoadStudentsFromFile("student_data.json");
        }

        private void LoadStudentsFromFile(string fileName)
        {
            lbStudents.Items.Clear();

            var pathToFile = Path.Combine(Environment.CurrentDirectory, fileName);
            var streamReader = new StreamReader(pathToFile);
            var jsonStringStudent = streamReader.ReadToEnd();
            streamReader.Close();

            _listOfStudents = JsonSerializer.Deserialize<List<Student>>(jsonStringStudent);
            _memory.Add(new List<Student>(_listOfStudents));

            PrintListOfStudents();
            _lastAction = "Загрузка данных";
            UpdateStatusStrip();
        }

        private void PrintListOfStudents()
        {
            foreach (var student in _listOfStudents)
            {
                lbStudents.Items.Add($"Name: {student.Name}");
                lbStudents.Items.Add($"Last Name: {student.LastName}");
                lbStudents.Items.Add($"First Name: {student.FirstName}");
                lbStudents.Items.Add($"Gender: {student.Gender}");
                lbStudents.Items.Add($"Age: {student.Age}");
                lbStudents.Items.Add($"Specialty: {student.Specialty}");
                lbStudents.Items.Add($"Course: {student.Course}");
                lbStudents.Items.Add($"Group: {student.Group}");
                lbStudents.Items.Add($"Average Score: {student.AverageScore}");
                lbStudents.Items.Add($"Is Math Passed: {student.IsMathPassed}");
                lbStudents.Items.Add($"Is History Passed: {student.IsHistoryPassed}");
                lbStudents.Items.Add($"Is Russian Passed: {student.IsRussianPassed}");

                lbStudents.Items.Add($"City: {student.Address.City}");
                lbStudents.Items.Add($"Street: {student.Address.Street}");
                lbStudents.Items.Add($"House Number: {student.Address.HouseNumber}");
                lbStudents.Items.Add($"Flat Number: {student.Address.FlatNumber}");
                lbStudents.Items.Add($"Index: {student.Address.Index}");

                lbStudents.Items.Add($"Company: {student.Job.Company}");
                lbStudents.Items.Add($"Position: {student.Job.Position}");
                lbStudents.Items.Add($"Year: {student.Job.Year}");

                lbStudents.Items.Add("\n");
                lbStudents.Items.Add("******************************");
                lbStudents.Items.Add("\n");
            }
        }

        private void SaveFormatedDataToFile()
        {
            var pathToFile = Path.Combine(Environment.CurrentDirectory, "student_data_formated.json");
            var jsonStringStudent = JsonSerializer.Serialize(_listOfStudents);

            var streamWriter = new StreamWriter(pathToFile);
            streamWriter.Write(jsonStringStudent);
            streamWriter.Flush();
            streamWriter.Close();

            MessageBox.Show($"Файл успешно сохранен.\nПуть: {pathToFile}", "Сохранение в файл", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _lastAction = "Сохранение данных";
        }

        private void ExecuteSearch()
        {
            var searchForm = new SearchForm();
            searchForm.ShowDialog();

            var courseSearchCriteria = searchForm.SearchData.Course;
            var specSearchCriteria = searchForm.SearchData.Spec;
            var firstNameSearchCriteria = searchForm.SearchData.FirstName;
            var nameSearchCriteria = searchForm.SearchData.StudentName;
            var lastNameSearchCriteria = searchForm.SearchData.LastName;
            var averageScoreSearchCriteria = searchForm.SearchData.AverageScore;
            var averageScoreRangeSearchCriteria = searchForm.SearchData.AverageScoreRange;

            double? averageScoreMin = null;
            double? averageScoreMax = null;

            if (!string.IsNullOrEmpty(averageScoreRangeSearchCriteria) && averageScoreRangeSearchCriteria.Trim().Length != 1)
            {
                var minRegex = new Regex(@"^[\d,]+(?=-)");
                var maxRegex = new Regex(@"(?<=-)[\d,]+$");
                averageScoreMin = double.Parse(minRegex.Matches(averageScoreRangeSearchCriteria)[0].Value);
                averageScoreMax = double.Parse(maxRegex.Matches(averageScoreRangeSearchCriteria)[0].Value);
            }

            // var firstNameRegex = new Regex(@"Best.+");

            //if (averageScoreRangeSearchCriteria.Trim().Length != 1)
            //{
            //    averageScoreMin = double.Parse(averageScoreRangeSearchCriteria.Split('-')[0]);
            //    averageScoreMax = double.Parse(averageScoreRangeSearchCriteria.Split('-')[1]);
            //}

            _listOfStudents = _listOfStudents
                .Where(s => string.IsNullOrEmpty(firstNameSearchCriteria) || s.FirstName.Contains(firstNameSearchCriteria))
                //.Where(s => firstNameRegex.IsMatch(s.FirstName))
                .Where(s => string.IsNullOrEmpty(nameSearchCriteria) || s.Name.Contains(nameSearchCriteria))
                .Where(s => string.IsNullOrEmpty(lastNameSearchCriteria) || s.LastName.Contains(lastNameSearchCriteria))
                .Where(s => courseSearchCriteria == null || s.Course == courseSearchCriteria)
                .Where(s => string.IsNullOrEmpty(specSearchCriteria) || s.Specialty == specSearchCriteria)
                .Where(s => averageScoreSearchCriteria == null || s.AverageScore > averageScoreSearchCriteria)
                .Where(s => averageScoreMin == null || averageScoreMax == null || (s.AverageScore >= averageScoreMin && s.AverageScore <= averageScoreMax))
                .ToList();

            _memory.Add(new List<Student>(_listOfStudents));

            lbStudents.Items.Clear();

            PrintListOfStudents();
            _lastAction = "Поиск";
            UpdateStatusStrip();
        }

        private void ExecuteSorting()
        {
            var sortingForm = new SortingForm();
            sortingForm.ShowDialog();

            bool sortByCourseAscending = sortingForm.CourseAscending;
            bool sortByCourseDescending = sortingForm.CourseDescending;
            bool sortByYearAscending = sortingForm.YearAscending;
            bool sortByYearDescending = sortingForm.YearDescending;
            bool sortByGroupAscending = sortingForm.GroupAscending;
            bool sortByGroupDescending = sortingForm.GroupDescending;


            if (sortByGroupAscending)
            {
                _listOfStudents = _listOfStudents.OrderBy(s => s.Group).ToList();
            }

            if (sortByGroupDescending)
            {
                _listOfStudents = _listOfStudents.OrderByDescending(s => s.Group).ToList();
            }

            if (sortByCourseAscending)
            {
                _listOfStudents = _listOfStudents.OrderBy(s => s.Course).ToList();
            }
            if (sortByCourseDescending)
            {
                _listOfStudents = _listOfStudents.OrderByDescending(s => s.Course).ToList();
            }

            if (sortByYearAscending)
            {
                _listOfStudents = _listOfStudents.OrderBy(s => s.Job.Year).ToList();
            }
            if (sortByYearDescending)
            {
                _listOfStudents = _listOfStudents.OrderByDescending(s => s.Job.Year).ToList();
            }

            _memory.Add(new List<Student>(_listOfStudents));

            lbStudents.Items.Clear();

            PrintListOfStudents();
            _lastAction = "Сортировка";
            UpdateStatusStrip();
        }

        private void UpdateStatusStrip()
        {
            tsNumberOfStudents.Text = $"Количество студентов в списке: {_listOfStudents.Count} | ";
            tsLastAction.Text = $"Последнее действие: {_lastAction} | ";
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var studentForm = new StudentForm(_listOfStudents);
            studentForm.ShowDialog();
            _lastAction = "Добавление данных";
        }

        private void buttonOutputStudents_Click(object sender, EventArgs e)
        {
            LoadStudentsFromFile("student_data.json");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void sortingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteSorting();
        }

        private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutProgrammForm = new AboutProgrammForm();
            aboutProgrammForm.ShowDialog();
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFormatedDataToFile();
        }

        private void buttonOutputFormattedStudents_Click(object sender, EventArgs e)
        {
            LoadStudentsFromFile("student_data_formated.json");
        }

        private void toolStripSearch_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void toolStripSort_Click(object sender, EventArgs e)
        {
            ExecuteSorting();
        }

        private void toolStripClear_Click(object sender, EventArgs e)
        {
            lbStudents.Items.Clear();
            _memory.Add(new List<Student>());
            _lastAction = "Очистка";
            UpdateStatusStrip();
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            _listOfStudents.Clear();
            lbStudents.Items.Clear();
            _memory.Add(new List<Student>(_listOfStudents));
            _lastAction = "Удаление";
            UpdateStatusStrip();
        }

        private void toolStripFarward_Click(object sender, EventArgs e)
        {
            _listOfStudents = _memory.Forward();
            lbStudents.Items.Clear();
            PrintListOfStudents();
            _lastAction = "Вперед";
            UpdateStatusStrip();
        }

        private void toolStripBack_Click(object sender, EventArgs e)
        {
            _listOfStudents = _memory.Back();
            lbStudents.Items.Clear();
            PrintListOfStudents();
            _lastAction = "Назад";
            UpdateStatusStrip();
        }

        private void buttonShowCloseTools_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = !toolStrip.Visible;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tsDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void tsDateTime_Click(object sender, EventArgs e)
        {

        }
    }
}