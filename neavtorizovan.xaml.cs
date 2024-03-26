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

namespace пр4
{
    /// <summary>
    /// Логика взаимодействия для neavtorizovan.xaml
    /// </summary>
    public partial class neavtorizovan : Window
    {
        public neavtorizovan()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wid = new MainWindow();
            wid.Show();
            Close();
        }
    }
}
