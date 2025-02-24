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

namespace Yagnov
{
    /// <summary>
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Window
    {
        private const string CorrectLogin = "KKT";
        private const string CorrectPass = "best";
        
        public reg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = tbxLogin.Text;
            string pass = tbxPass.Text;
            if (login == CorrectLogin && pass == CorrectPass)
            { }

        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
