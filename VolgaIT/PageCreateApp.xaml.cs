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
    /// Логика взаимодействия для PageCreateApp.xaml
    /// </summary>
    public partial class PageCreateApp : Window
    {
        DBContainer db;
        public PageCreateApp()
        {
            InitializeComponent();
            db = new DBContainer();
        }
        private void Button_Click_center(object sender, RoutedEventArgs e)
        {
            PageMain RW = new PageMain();
            RW.Show();
            this.Close();
        }
        private void Button_Click_add(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы уже тут");
        }
        private void Button_Click_list(object sender, RoutedEventArgs e)
        {
            PageState RW = new PageState();
            RW.Show();
            this.Close();
        }
        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверны, что хотите выти из системы?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                PageMainNone RW = new PageMainNone();
                RW.Show();
                this.Close();
            }
        }
    }
}
