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

namespace Pr_Design
{
    /// <summary>
    /// Логика взаимодействия для LoginWin.xaml
    /// </summary>
    public partial class LoginWin : Window
    {
        public LoginWin()
        {
            InitializeComponent();
        }

        private void EnterBut_Click(object sender, RoutedEventArgs e)
        {
            OrderWin Ow = new OrderWin();
            Ow.Show();
            this.Close();
        }

        private void checkBoxPwd_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.IsChecked.Value)
            {
                pwdTextBox.Text = pwdPasswordBox.Password;
                pwdTextBox.Visibility = Visibility.Visible;
                pwdPasswordBox.Visibility = Visibility.Hidden;
            }
            else
            {
                pwdPasswordBox.Password = pwdTextBox.Text;
                pwdTextBox.Visibility = Visibility.Hidden;
                pwdPasswordBox.Visibility = Visibility.Visible;
            }
        }
    }
}