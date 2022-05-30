using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
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
    /// Логика взаимодействия для PageAuth.xaml
    /// </summary>
    public partial class PageAuth : Window
    {
        DBContainer db;
        public PageAuth()
        {
            InitializeComponent();
            db = new DBContainer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Email.Text == "" || Password.Password == "")
            {
                MessageBox.Show("Ошибка пустые поля");
                return;
            }
            if (db.Users.Select(item => item.email + "" + item.password).Contains(Email.Text + "" + Password.Password))
            {
                MessageBox.Show("Вы успешно авторизовались");
                PageMain RW = new PageMain();
                RW.Show();
                this.Close();
            }
            else
                MessageBox.Show("Ошибка логина/пароля");
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            PageRegistr RW = new PageRegistr();
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
        private void Button_Click_exit(object sender, EventArgs e)
        {
            PageMainNone RW = new PageMainNone();
            RW.Show();
            this.Close();
            
            
        }
    }
}
