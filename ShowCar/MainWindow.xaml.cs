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

namespace ShowCar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Page2 page = new Page2();
            InitializeComponent();
            Frame.Content = page;

            Page3 page1 = new Page3();
            Frame.Content = page1;

            Page4 page2 = new Page4();
            Frame.Content = page2;

            Page5 page3 = new Page5();
            Frame.Content = page3;

            Page6 page4 = new Page6();
            Frame.Content = page4;


            this.Navigate(new Page2());
            this.Navigate(new Page3());
            this.Navigate(new Page4());
            this.Navigate(new Page5());
            this.Navigate(new Page6());

            this.Navigate(this.PreviousPage);
            this.Navigate(this.NextPage);
        }

    }
