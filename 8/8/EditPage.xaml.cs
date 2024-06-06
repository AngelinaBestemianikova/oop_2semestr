using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.Data.Entity.Migrations;

namespace _8
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        Student student = new Student();

        string img;
        public EditPage(Student student, bool statement)
        {
            InitializeComponent();

            img = student.Photo;

            if (statement == false)
            {
                tbStudentID.IsReadOnly = true;
                tbFIO.IsReadOnly = true;
                cbCourse.IsEnabled = false;
                cbGroup.IsEnabled = false;
                cbSpecialization.IsEnabled = false;
                tbAverageScore.IsReadOnly = true;
                tbAge.IsReadOnly = true;
                dpBDay.IsEnabled = false;
                tbAddressID.IsReadOnly = true;
                tbCity.IsReadOnly = true;
                tbFlat.IsReadOnly = true;
                tbIndex.IsReadOnly = true;
                tbStreet.IsReadOnly = true;
                tbSHouse.IsReadOnly = true;
                Save_btn.IsEnabled = false;
                LoadImage_btn.IsEnabled = false;
                rbFemale.IsEnabled = false;
                rbMale.IsEnabled = false;               
            }

            tbStudentID.Text = student.StudentID.ToString();
            tbFIO.Text = student.FullName;
            cbCourse.Text = student.Course.ToString();
            cbGroup.Text = student.GroupName;
            cbSpecialization.Text = student.Specialization;
            tbAge.Text = student.Age.ToString();
            tbAverageScore.Text = student.AverageScore.ToString().Replace(',', '.');
            dpBDay.SelectedDate = student.BirthDate;

            tbAddressID.Text = student.Address.AddressID.ToString();
            tbCity.Text = student.Address.City;
            tbFlat.Text = student.Address.ApartmentNumber;
            tbIndex.Text = student.Address.PostalCode.ToString();
            tbStreet.Text = student.Address.Street;
            tbSHouse.Text = student.Address.HouseNumber;
            tbAddressID.Text = tbStudentID.Text;

            if (!string.IsNullOrEmpty(student.Photo))
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(student.Photo);
                bitmap.EndInit();

                image.Source = bitmap;
            }
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

        private void Save_btn_Click(object sender, RoutedEventArgs e)
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
                tbAddressID.Text = tbStudentID.Text;
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
            if (int.Parse(tbAge.Text) >100 || int.Parse(tbAge.Text) < 18)
            {
                MessageBox.Show("Введите Age от 18 до 100", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
                MessageBox.Show("Поле 'AverageScore' должно содеражать только цифры и точку", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                if(decimal.TryParse(tbAverageScore.Text, NumberStyles.Number, culture, out averageScore))
                student.AverageScore = averageScore;
            }

            string bDay = dpBDay.SelectedDate.ToString();
            DateTime currentDateTime = DateTime.Now;
            if (DateTime.Parse(bDay) > currentDateTime)
            {
                MessageBox.Show("Дата рождения не может быть в будущем!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); return;
            }
            DateTime maxAllowedDate = DateTime.Now.AddYears(-100); if (DateTime.Parse(bDay) < maxAllowedDate)
            {
                MessageBox.Show("Дата рождения не может быть более чем 100 лет назад!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DateTime minAllowedDate = currentDateTime.AddYears(-18);
            if (DateTime.Parse(bDay) > minAllowedDate)
            {
                MessageBox.Show("Студенту должно быть более 18 лет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); return;
            }
            else
            {
                student.BirthDate = dpBDay.SelectedDate;
            }

            if (!string.IsNullOrEmpty(student.Photo))
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(student.Photo);
                bitmap.EndInit();

                image.Source = bitmap;
                student.Photo = bitmap.UriSource.ToString();
            }
            else
            {
                student.Photo = img;
            }

            if (rbFemale.IsChecked == true)
            {
                student.Gender = "female";
            }
            else
            {
                student.Gender = "male";
            }

            if (image.Source == null)
            {
                MessageBox.Show("Добавьте фото студента!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(tbCity.Text))
            {
                MessageBox.Show("Введите City", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (!Regex.IsMatch(tbCity.Text, @"^[\p{L}-]+$"))
            {
                MessageBox.Show("Город может содержать только буквы и дефис", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(tbIndex.Text))
            {
                MessageBox.Show("Введите Index", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!Regex.IsMatch(tbIndex.Text, @"^\d{6}$"))
            {
                MessageBox.Show("Индекс должен состоять ровно из 6 цифр", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(tbStreet.Text))
            {
                MessageBox.Show("Введите Street", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(tbSHouse.Text))
            {
                MessageBox.Show("Введите HouseNumber", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (!Regex.IsMatch(tbSHouse.Text, @"^\d+"))
            {
                MessageBox.Show("Номер дома должен начинаться с цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Address address = new Address
            {
                AddressID = int.Parse(tbStudentID.Text),
                City = tbCity.Text,
                PostalCode = int.Parse(tbIndex.Text),
                Street = tbStreet.Text,
                HouseNumber = tbSHouse.Text,
                ApartmentNumber = tbFlat.Text
            };

            student.Address = address;

            var validationContext = new ValidationContext(student);
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            if (!Validator.TryValidateObject(student, validationContext, results, true))
            {
                MessageBox.Show(results.First().ErrorMessage, "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string connectionString = "Data Source=DESKTOP-KS0KMCI\\SQLEXPRESS;Initial Catalog=OOP_UniversityDB;Integrated Security=True;MultipleActiveResultSets=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UpdateStudent", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StudentId", tbStudentID.Text);

                    command.Parameters.AddWithValue("@FullName", tbFIO.Text);
                    command.Parameters.AddWithValue("@Photo", student.Photo);
                    command.Parameters.AddWithValue("@Age", tbAge.Text);
                    command.Parameters.AddWithValue("@Specialization", cbSpecialization.SelectedItem);
                    command.Parameters.AddWithValue("@BirthDate", dpBDay.SelectedDate);
                    command.Parameters.AddWithValue("@Course", cbCourse.SelectedItem);
                    command.Parameters.AddWithValue("@GroupName", cbGroup.SelectedItem);
                    command.Parameters.AddWithValue("@AverageScore", tbAverageScore.Text);

                    if (rbFemale.IsChecked == true)
                    {
                        command.Parameters.AddWithValue("@Gender", "female");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Gender", "male");
                    }
                    command.Parameters.AddWithValue("@City", tbCity.Text);
                    command.Parameters.AddWithValue("@PostalCode", tbIndex.Text);
                    command.Parameters.AddWithValue("@Street", tbStreet.Text);
                    command.Parameters.AddWithValue("@HouseNumber", tbSHouse.Text);
                    command.Parameters.AddWithValue("@ApartmentNumber", tbFlat.Text);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Информация о студенте была изменена", "Уведомление",
                MessageBoxButton.OK, MessageBoxImage.Information);           
        }
    }
}
