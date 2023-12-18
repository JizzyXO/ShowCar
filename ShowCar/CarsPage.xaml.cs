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
    /// Логика взаимодействия для CarsPage.xaml
    /// </summary>
    public partial class CarsPage : Page
    {
        public CarsPage()
        {
            InitializeComponent();

            this.TextBlocks[0].Text = "Покупатели";
            this.TextBlocks[1].Text = "Марки";
            this.TextBlocks[2].Text = "Сотрудники";
            this.TextBlocks[3].Text = "Автомобили";
            this.TextBlocks[4].Text = "Продажи";
        }
        public TextBlock[] TextBlocks { get; private set; }
    }
}
