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

namespace Wpf_Lesson3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //public int Count { get; set; }
        //private void btn_Click(object sender, RoutedEventArgs e)
        //{
        //    btn.Content = (Count++).ToString();
        //}

        //private void repeat_btn_Click(object sender, RoutedEventArgs e)
        //{
        //    repeat_btn.Content = (Count++).ToString();
        //}

        //public bool HasClicked { get; set; } = false;
        //private void Toggle_btn_Click(object sender, RoutedEventArgs e)
        //{
        //    HasClicked = !HasClicked;
        //    Toggle_btn.Content = HasClicked ? "Clicked" : "Not Clicked";
        //}
    }
}