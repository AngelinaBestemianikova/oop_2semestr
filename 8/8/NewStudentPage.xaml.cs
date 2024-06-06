using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Media.Imaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Globalization;

namespace _8
{
    /// <summary>
    /// Логика взаимодействия для NewStudentPage.xaml
    /// </summary>
    public partial class NewStudentPage : Page
    {
        public NewStudentPage()
        {
            InitializeComponent();
        }

        Student student = new Student();

        private void To_Address_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbStudentID.Text))
            {
                MessageBox.Show("Поле 'ID' не может быть пустым!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (Regex.IsMatch(tbStudentID.Text, @"\D"))
            {
                MessageBox.Show("Поле 'ID' должно содеражать только цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.StudentID = int.Parse(tbStudentID.Text);
            }

            if (string.IsNullOrEmpty(tbFIO.Text))
            {
                MessageBox.Show("Поле 'FIO' пустое. Введите FIO", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (Regex.IsMatch(tbFIO.Text, @"\d"))
            {
                MessageBox.Show("Поле 'FIO' должно содеражать только буквы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.FullName = tbFIO.Text;
            }

            if (string.IsNullOrEmpty(cbSpecialization.Text))
            {
                MessageBox.Show("Поле 'Specialization' пустое. Выберите Specialization", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.Specialization = cbSpecialization.Text;
            }

            if (string.IsNullOrEmpty(cbCourse.Text))
            {
                MessageBox.Show("Поле 'Course' пустое. Выберите Course", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.Course = int.Parse(cbCourse.Text);
            }

            if (string.IsNullOrEmpty(cbGroup.Text))
            {
                MessageBox.Show("Поле 'Group' пустое. Выберите Group", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.GroupName = cbGroup.Text;
            }

            if (string.IsNullOrEmpty(tbAge.Text))
            {
                MessageBox.Show("Поле 'Age' пустое.  Введите Age", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (Regex.IsMatch(tbAge.Text, @"\D"))
            {
                MessageBox.Show("Поле 'Age' должно содеражать только цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }           
            else
            {
                student.Age = int.Parse(tbAge.Text);

                if (int.TryParse(tbAge.Text, out int age))
                {
                    DateTime currentDate = DateTime.Now;

                    int year = currentDate.Year - age;

                    dpBDay.SelectedDate = new DateTime(year, currentDate.Month, currentDate.Day);

                    dpBDay.DisplayDateStart = new DateTime(year, 1, 1);
                    dpBDay.DisplayDateEnd = new DateTime(year, 12, 31);
                }
                else
                {
                    dpBDay.SelectedDate = null;
                    dpBDay.DisplayDateStart = null;
                    dpBDay.DisplayDateEnd = null;
                }
            }

            CultureInfo culture = CultureInfo.InvariantCulture;
            decimal averageScore;
            if (string.IsNullOrEmpty(tbAverageScore.Text))
            {
                MessageBox.Show("Поле 'AverageScore' пустое.  Введите AverageScore", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!Regex.IsMatch(tbAverageScore.Text, @"^[0-9]+(?:\.[0-9]+)?$"))
            {
                MessageBox.Show("Поле 'AverageScore' должно содеражать только цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                if (decimal.TryParse(tbAverageScore.Text, NumberStyles.Number, culture, out averageScore))
                    student.AverageScore = averageScore;
            }

            if(dpBDay.SelectedDate is null)
            {
                MessageBox.Show("Дата рождения не может быть пустой!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); 
                return;
            }
            string bDay = dpBDay.SelectedDate.ToString();
            DateTime currentDateTime = DateTime.Now;

            if (DateTime.Parse(bDay) > currentDateTime)
            {
                MessageBox.Show("Дата рождения не может быть в будущем!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); 
                return;
            }
            DateTime maxAllowedDate = DateTime.Now.AddYears(-100); if (DateTime.Parse(bDay) < maxAllowedDate)
            {
                MessageBox.Show("Дата рождения не может быть более чем 100 лет назад!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DateTime minAllowedDate = currentDateTime.AddYears(-18);
            if (DateTime.Parse(bDay) > minAllowedDate)
            {
                MessageBox.Show("Студенту должно быть более 18 лет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); 
                return;
            }

            else
            {
                student.BirthDate = dpBDay.SelectedDate;
            }

            if (rbFemale.IsChecked == true)
            {
                student.Gender = "female";
            }
            else
            {
                student.Gender = "male";
            }

            if (int.Parse(tbAge.Text) - int.Parse(cbCourse.SelectedItem.ToString()) < 17)
            {
                MessageBox.Show($"Студент с возрастом {tbAge.Text} не может быть на курсе {cbCourse.SelectedItem}!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(image.Source == null)
            {
                MessageBox.Show("Добавьте фото студента!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var validationContext = new ValidationContext(student);
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            if (!Validator.TryValidateObject(student, validationContext, results, true))
            {
                MessageBox.Show(results.First().ErrorMessage, "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var id = int.Parse(tbStudentID.Text);

            NewStudent.NavigationService.Navigate(new AddressPage(id, student));
        }

        private void LoadImage_btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(imagePath);
                bitmapImage.EndInit();

                image.Source = bitmapImage;
                
                student.Photo = imagePath;
            }
        }
    }
}
