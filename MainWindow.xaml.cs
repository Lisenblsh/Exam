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

namespace Exam
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tb_count.Text == "")
                otvet.Content = ""; 
            else
            {
                string[] str = tb_count.Text.Select(i => i.ToString()).ToArray();
                int cod = Convert.ToInt32(str[str.Count() - 2]) * 10 + Convert.ToInt32(str[str.Count() - 1]);
                string msg = "";
                if (str.Count() == 3)
                {
                    if (cod < 10)
                        msg = "Диаметр подшипника равен = " + Convert.ToString(cod);
                }
                else if (str.Count() == 4)
                {
                    if (cod == 0)
                        msg = "Диаметр подшипника равен = 10";
                    else if (cod == 1)
                        msg = "Диаметр подшипника равен = 12";
                    else if (cod == 3)
                        msg = "Диаметр подшипника равен = 17";
                    else if (cod >= 4)
                        msg = "Диаметр подшипника равен = " + Convert.ToString(cod * 5);
                }
                otvet.Content = msg;
            }
        }
    }
}
