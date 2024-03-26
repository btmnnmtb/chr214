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
    /// Логика взаимодействия для avtorizovan.xaml
    /// </summary>
    public partial class avtorizovan : Window
    {
        public avtorizovan()
        {
            InitializeComponent();
            List<Testtt> otvet = new List<Testtt>()
            {
                new Testtt("1" , "2121" , "1" , "2" , "3"),
                

            };
            MyData.ItemsSource = otvet;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            {
                MainWindow wid = new MainWindow();
                wid.Show();
                Close();
            }
        }

        private void redactor_testa_Click(object sender, RoutedEventArgs e)
        {
            
            izmen.Content = new izmentest();
            Testtt test = new Testtt("1" , "2" , "3 " , "4" , "5" ); 
            izmen.i





        }
    }
}
