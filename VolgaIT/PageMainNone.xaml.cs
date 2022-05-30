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
    /// Логика взаимодействия для PageMainNone.xaml
    /// </summary>
    public partial class PageMainNone : Window
    {
        DBContainer db;
        public PageMainNone()
        {
            InitializeComponent();
            db = new DBContainer();
        }
        private void Button_Click_center(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы уже на главной");
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
            if (MessageBox.Show("Вы уверны, что хотите завершить работу?", "Завершение работы", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageRegistr RW = new PageRegistr();
            RW.Show();
            this.Close();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            PageAuth RW = new PageAuth();
            RW.Show();
            this.Close();
        }
    }
}
