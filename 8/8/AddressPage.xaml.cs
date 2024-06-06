using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;
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

namespace _8
{
    /// <summary>
    /// Логика взаимодействия для AddressPage.xaml
    /// </summary>
    public partial class AddressPage : Page
    {
        Student _student;

        public AddressPage(int id, Student student)
        {
            InitializeComponent();
            
            tbAddressID.Text = id.ToString();
            _student = student;            
        }

        private void Save_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCity.Text))
            {
                MessageBox.Show("Введите City", "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (!Regex.IsMatch(tbCity.Text, @"^[\p{L}-]+$"))
            {
                MessageBox.Show("Город может содержать только буквы и дефис", "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(tbIndex.Text))
            {
                MessageBox.Show("Введите Index", "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (!Regex.IsMatch(tbIndex.Text, @"^\d{6}$"))
            {
                MessageBox.Show("Индекс должен состоять ровно из 6 цифр", "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(tbStreet.Text))
            {
                MessageBox.Show("Введите Street", "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(tbSHouse.Text))
            {
                MessageBox.Show("Введите HouseNumber", "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (!Regex.IsMatch(tbSHouse.Text, @"^\d+"))
            {
                MessageBox.Show("Номер дома должен начинаться с цифры", "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Address address = new Address
            {
                AddressID = int.Parse(tbAddressID.Text),
                City = tbCity.Text,
                PostalCode = int.Parse(tbIndex.Text),
                Street = tbStreet.Text,
                HouseNumber = tbSHouse.Text,
                ApartmentNumber = tbFlat.Text
            };

            var validationContext = new ValidationContext(_student);
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            if (!Validator.TryValidateObject(_student, validationContext, results, true))
            {
                MessageBox.Show(results.First().ErrorMessage, "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            _student.Address = address;
            _student.UpdatedAt = DateTime.Now;

            AppData.db.Student.AddOrUpdate(_student);
            AppData.db.SaveChanges();
            MessageBox.Show("Студент был добавлен","Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            Save_btn.IsEnabled = false;
        }
    }
}