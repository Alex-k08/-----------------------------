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
    /// Логика взаимодействия для Dobavit.xaml
    /// </summary>
    public partial class Dobavit : Page
    {
        DataGrid dataTable;
        Gimnazia1Entities db;
        public Dobavit(DataGrid table, Gimnazia1Entities db)
        {
            InitializeComponent();
            dataTable = table;
            this.db = db;
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            Events codeStruct = new Events
            {
                Event = int.Parse($"{Events2}"),
                Contents = Contents2.Text,
            };
            db.Events.Add(codeStruct); 
            db.SaveChanges(); 
            this.Cursor = Cursors.Arrow; 
            dataTable.ItemsSource = null; 
            dataTable.ItemsSource = db.Events.ToList();
            NavigationService.GoBack();
        }
    }
}
