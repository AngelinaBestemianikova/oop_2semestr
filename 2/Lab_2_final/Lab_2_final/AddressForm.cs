using Lab_2_final.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_2_final
{
    public partial class AddressForm : Form
    {
        public AddressForm(Address address)
        {
            InitializeComponent();

            if (address != null)
            {
                textBoxIndex.Text = address.Index.ToString();
                textBoxFlat.Text = address.FlatNumber.ToString();
                textBoxHouse.Text = address.HouseNumber.ToString();
                textBoxStreet.Text = address.Street.ToString();
                textBoxCity.Text = address.City.ToString();
            }
        }

        internal Address Address { get; set; }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            try
            {
                Address = new Address
                {
                    City = textBoxCity.Text,
                    Street = textBoxStreet.Text,
                    HouseNumber = textBoxHouse.Text,
                    Index = int.Parse(textBoxIndex.Text)
                };

                if (string.IsNullOrEmpty(textBoxFlat.Text))
                {
                    Address.FlatNumber = null;
                }
                else
                {
                    Address.FlatNumber = int.Parse(textBoxFlat.Text);
                }

                if (string.IsNullOrEmpty(textBoxCity.Text))
                {
                    MessageBox.Show("Поле 'Город' пустое. Введите город", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //if (!Regex.IsMatch(textBoxCity.Text, @"\d"))
                //{
                //    MessageBox.Show("Поле 'Город' должно содеражать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if (textBoxIndex.Text.Length != 6)
                {
                    MessageBox.Show("Поле 'Индекс' должно быть из шести цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            

                if (string.IsNullOrEmpty(textBoxStreet.Text))
                {
                    MessageBox.Show("Поле 'Улица' пустое. Введите улицу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(textBoxHouse.Text))
                {
                    MessageBox.Show("Поле 'Дом' пустое. Введите дом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
