using Lab_2_final.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_2_final
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            SearchData = new SearchData();
        }

        public SearchData SearchData { get; set; }

        private void buttonSearch_Click(object sender, System.EventArgs e)
        {
            if (Regex.IsMatch(textBoxFirstName.Text, @"\d"))
            {
                MessageBox.Show("Поле 'Фамилия' должно содеражать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SearchData.FirstName = textBoxFirstName.Text;

            if (Regex.IsMatch(textBoxName.Text, @"\d"))
            {
                MessageBox.Show("Поле 'Имя' должно содеражать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SearchData.StudentName = textBoxName.Text;

            if (Regex.IsMatch(textBoxLastName.Text, @"\d"))
            {
                MessageBox.Show("Поле 'Отчество' должно содеражать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SearchData.LastName = textBoxLastName.Text;

            SearchData.Spec = comboBoxSpec.Text;

            if (string.IsNullOrEmpty(textBoxCourse.Text))
            {
                SearchData.Course = null;
            }
            else if (int.TryParse(textBoxCourse.Text, out _))
            {
                SearchData.Course = int.Parse(textBoxCourse.Text);
            }
            else
            {
                MessageBox.Show("Введите целое число в поле 'Курс' ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Regex.IsMatch(textBoxAverageScore.Text, @"[^0-9\,]"))
            {
                MessageBox.Show("Поле 'Средний балл' должно содеражать только цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(textBoxAverageScore.Text))
            {
                SearchData.AverageScore = double.Parse(textBoxAverageScore.Text);
            }
            else
            {
                SearchData.AverageScore = null;
            }

            SearchData.AverageScoreRange = mtbAverageScoreRange.Text;

            var validationContext = new ValidationContext(SearchData);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(SearchData, validationContext, results, true))
            {
                MessageBox.Show(results.First().ErrorMessage, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!string.IsNullOrEmpty(SearchData.AverageScoreRange))
                {
                    var minValue = double.Parse(SearchData.AverageScoreRange.Split('-')[0]);
                    var maxValue = double.Parse(SearchData.AverageScoreRange.Split('-')[1]);

                    if (minValue > maxValue)
                    {
                        MessageBox.Show("Первое число должно быть меньше второго в поле 'Средний балл диапазон'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Close();
            }
        }
    }

    public class SearchData
    {
        public string FirstName { get; set; }
        public string StudentName { get; set; }
        public string LastName { get; set; }
        public string Spec { get; set; }

        [Range(1, 5, ErrorMessage = "Введите курс от 1 до 5")]
        public int? Course { get; set; }

        [Range(1.0, 10.0, ErrorMessage = "Введите средний балл от 1 до 10")]
        public double? AverageScore { get; set; }

        [RegularExpression(pattern: "^(?:[1-9])(?:\\,\\d+)?-(?:[1-9]|10)(?:\\,\\d+)?$", ErrorMessage = "Недопустипый формат поля 'Средний балл диапазон'. Ожидаемый формат: 'число(до 9)-число(до 10)'")]
        public string AverageScoreRange { get; set; }
    }
}
