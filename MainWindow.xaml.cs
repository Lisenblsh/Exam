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
            if (tb_count.Text == "" || tb_count.Text.Count() < 3 || tb_count.Text.Count() > 4)
                otvet.Content = ""; 
            else
            {
                string[] str = tb_count.Text.Select(i => i.ToString()).ToArray();
                int cod = Convert.ToInt32(str[str.Count() - 2]) * 10 + Convert.ToInt32(str[str.Count() - 1]);
                string msg = "";
                if (str.Count() == 3)
                {
                    if (cod < 10)
                        msg = "Внутрений диаметр подшипника равен = " + Convert.ToString(cod) + "мм \n(Внутрений радиус = " + Convert.ToString(cod/2) + "мм)";
                }
                else if (str.Count() == 4)
                {
                    if (cod == 0)
                        msg = "Внутрений диаметр подшипника равен = 10мм \n(Внутрений радиус = 5мм)";
                    else if (cod == 1)
                        msg = "Внутрений диаметр подшипника равен = 12мм \n(Внутрений радиус = 6мм)";
                    else if (cod == 2)
                        msg = "Внутрений диаметр подшипника равен = 15мм \n(Внутрений радиус = 7.5мм)";
                    else if (cod == 3)
                        msg = "Внутрений диаметр подшипника равен = 17 \n(Внутрений радиус = 8.5мм)";
                    else if (cod >= 4)
                        msg = "Внутрений диаметр подшипника равен = " + Convert.ToString(cod * 5) + "мм \n(Внутрений радиус = " + Convert.ToString(cod*5 / 2) + "мм)";
                }
                otvet.Content = msg;
            }
        }
    }
}
