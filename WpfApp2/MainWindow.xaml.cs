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

namespace WpfApp2
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

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(TbNumber.Text);
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = -1;
                int count = 0;
                int a = Convert.ToInt32(ListBoxData.Items[0]);
                int b = Convert.ToInt32(ListBoxData.Items[1]);
                for (int i = a; i <= b; i++)
                {
                   
                    if (i % 2 == 0)
                    {
                        if (k == -1)
                        {
                            count++;
                        }
                    }
                }
                if (k == -1)
                {
                    TextBlockAnswer.Text = $"Ответ: \n {count}";
                }
                else
                {
                    TextBlockAnswer.Text = $"Ответ:\n Таких чисел нет";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
