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

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для BookList.xaml
    /// </summary>
    public partial class BookList : Window
    {
        LibraryEntities db = new LibraryEntities();
        public BookList()
        {
            InitializeComponent();
            BookGrid.ItemsSource = db.Book.ToList();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            MainWindow op = new MainWindow();
            op.Show();
            this.Close();
        }

    }
}
