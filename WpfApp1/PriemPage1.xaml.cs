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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для PriemPage1.xaml
    /// </summary>
    public partial class PriemPage1 : Page
    {
        public PriemPage1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddPriemWindow1 addPriemWindow1 = new AddPriemWindow1();
            addPriemWindow1.Show();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TicketSearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RedactivBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
