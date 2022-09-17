using System.Collections.ObjectModel;
using System.Windows;
using Boards.Dto;
using Boards.PcbManufacturing.ViewModels;
using Color = Boards.Dto.Color;

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
                MaterialsDataSource = new ObservableCollection<Material>(
                    new Material[] {
                        new Material { Id = 1, Name = "Steel" },
                        new Material { Id = 2, Name = "Wood" },
                        new Material { Id = 3, Name = "Rubber" },
                        new Material { Id = 4, Name = "Plastic" },
                        new Material { Id = 5, Name = "Stone" },
                    }),
                SurfaceFinishDataSource = new ObservableCollection<SurfaceFinish>(
                    new SurfaceFinish[]
                    {
                        new SurfaceFinish { Id = 1, Name = "Sandblasted" },
                        new SurfaceFinish { Id = 2, Name = "Polished" },
                        new SurfaceFinish { Id = 3, Name = "Painted" },
                        new SurfaceFinish { Id = 4, Name = "Raw" },
                    }),
                SolderMaskColorsDataSource = new ObservableCollection<Color>(
                    new Color[]
                    {
                        new Color { Name = "Red", R = 255, G = 0, B = 0, },
                        new Color { Name = "Green", R = 0, G = 255, B = 0, },
                        new Color { Name = "Blue", R = 0, G = 0, B = 255, },
                        new Color { Name = "White", R = 255, G = 255, B = 255, },
                        new Color { Name = "Black", R = 0, G = 0, B = 0, },
                    })
            };
            model.SurfaceFinish = model.SurfaceFinishDataSource[3];
            model.SolderMaskColor = model.SolderMaskColorsDataSource[3];
            InitializeComponent();
            this.DataContext = model;
        }
    }
}
