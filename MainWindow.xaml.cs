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
using iNKORE.UI.WPF.Modern.Controls;

namespace TestDataGrid
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        class items
        {
            public string Username { get; set; }
            public DateTime Password { get; set; }
            public double Rank { get; set; }
            public bool IsSelected { get; set; } // Свойство для CheckBox
        }

        private void testGrid_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Add(new items { Username = "Test", Password = new DateTime(), Rank = 5, IsSelected = false });
            Dispatcher.Invoke(new Action(delegate () {
                dataGrid.Items.Add(new items { Username = "Test", Password = new DateTime(), Rank = 5, IsSelected = true });
            }));
        }

    }
}
