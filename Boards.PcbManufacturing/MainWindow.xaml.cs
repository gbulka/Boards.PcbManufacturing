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
using Boards.Dto;
using Boards.PcbManufacturing.ViewModels;

namespace Boards.PcbManufacturing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var model = new PreferencesViewModel
            {
                ProjectName = "New project",
                Color = new Dto.Color
                {
                    Name = "Red",
                    R = 128,
                    G = 0,
                    B = 0,
                },
            };
            InitializeComponent();
            this.DataContext = model;
        }
    }
}
