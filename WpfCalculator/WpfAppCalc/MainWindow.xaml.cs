using System;
using System.Data;
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
using System.Threading;

namespace WpfAppCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            AddHandler(System.Windows.Controls.Primitives.ToggleButton.CheckedEvent, new RoutedEventHandler(chk_Checked));
            AddHandler(System.Windows.Controls.Primitives.ToggleButton.UncheckedEvent, new RoutedEventHandler(chk_Unchecked));
            foreach (UIElement el in MainContainer.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str == "AC")
                Enter.Text = "";
            else if (str == "=")
            {
                dynamic value = (dynamic)new DataTable().Compute(Enter.Text, null);
                Enter.Text = value.ToString();

            }
            else if (str == "√")
            {
                double x = Convert.ToDouble(Enter.Text);
                double value = Math.Sqrt(x);
                Enter.Text = value.ToString();
            }
            else if (str == "Nⁿ")
            {

                double x = Convert.ToDouble(Enter.Text);
                double y = Convert.ToDouble(Enter.Text);

                double value = Math.Pow(x, y);
                Enter.Text = value.ToString();
            }
            else if (str == "!")
            {
                int x = int.Parse(Enter.Text);
                if (x > 0)
                {
                    int p = 1;
                    for (int i = 1; i <= x; i++)
                    {
                        p *= i;
                    }
                    int value = p;
                    Enter.Text = value.ToString();
                }
                else
                {
                    Enter.Text = "ошибка";
                }

            }
            else if (str == "1/x")
            {
                double x = Convert.ToDouble(Enter.Text);

                double value = 1 / x;
                Enter.Text = value.ToString() + "   " + DateTime.Now.ToString();

            }
            else if (str == "←")
            {

                int lenght = Enter.Text.Length - 1;
                dynamic text1 = Enter.Text;
                Enter.Text = "";
                for (int i = 0; i < lenght; i++)
                {
                    Enter.Text += text1[i];
                }
            }
            else if (str == "ⁿ²")
            {
                dynamic x = Convert.ToDouble(Enter.Text);
                double value = x * x;
                Enter.Text = value.ToString();
            }
            /*  else if (str == "ⁿ")
              {
                   string p= Enter.Text;
                  int k = Convert.ToInt32(p);
                  //Thread.Sleep(500);

                  string str2 = "5";
                  Enter.Text = str2;
                  string s = Enter.Text;
                  int n = Convert.ToInt32(s);
                  int j=0;
                  int b = 1;
                  while (j <= n)
                  { j++;b *= k; }
                  int value = b;
                  Enter.Text = value.ToString();
              }*/
            else
                Enter.Text += str;
        }



        private void chk_Checked(object sender, RoutedEventArgs e)
        {

            CheckBox chk = e.OriginalSource as CheckBox;

            DependencyObject dpObj = LogicalTreeHelper.FindLogicalNode(this, chk.Content.ToString());


            ((FrameworkElement)dpObj).Visibility = Visibility.Visible;
        }

        private void chk_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = e.OriginalSource as CheckBox;
            DependencyObject obj = LogicalTreeHelper.FindLogicalNode(this, chk.Content.ToString());
            ((FrameworkElement)obj).Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
