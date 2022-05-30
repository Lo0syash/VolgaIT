using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VolgaIT
{
    /// <summary>
    /// Логика взаимодействия для PageRegistr.xaml
    /// </summary>
    public partial class PageRegistr : Window
    {
        DBContainer db;
        public PageRegistr()
        {
            InitializeComponent();
            db = new DBContainer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Email.Text == "" || Password.Password == "" || Password_check.Password == "")
            {
                MessageBox.Show("Ошибка пустые поля");
                return;
            }
            if (db.Users.Select(item => item.email).Contains(Email.Text))
            {
                MessageBox.Show("Такой email существует в системе");
                return;
            }
            if (Password.Password.ToString() == Password_check.Password.ToString())
            {
                User newUser = new User()
                {
                    email = Email.Text,
                    password = Password.Password,
                };
                db.Users.Add(newUser);
                db.SaveChanges();
                MessageBox.Show("Вы успешно зарегестрировались");
                PageMain RW = new PageMain();
                RW.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Указаны разные пароли");
            }
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            PageAuth RW = new PageAuth();
            RW.Show();
            this.Close();
        }
        private void Button_Click_center(object sender, RoutedEventArgs e)
        {
            PageMainNone RW = new PageMainNone();
            RW.Show();
            this.Close();
        }
        private void Button_Click_add(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для начала авторизуйтесь");
        }
        private void Button_Click_list(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для начала авторизуйтесь");
        }
        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {
            PageMainNone RW = new PageMainNone();
            RW.Show();
            this.Close();
        }
    }
}
