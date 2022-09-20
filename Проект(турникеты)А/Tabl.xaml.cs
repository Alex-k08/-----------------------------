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

namespace Проект_турникеты_А
{
    /// <summary>
    /// Логика взаимодействия для Tabl.xaml
    /// </summary>
    public partial class Tabl : Page
    {
       
        public Tabl()
        {
            InitializeComponent();
            Gimnazia1Entities db = new Gimnazia1Entities(); 
            dataView.ItemsSource = db.Events.ToList();

        }

        private void addItemButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Dobavit());
        }
    }
}
