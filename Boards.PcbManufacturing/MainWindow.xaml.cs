using System;
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
            var model = new MainWindowViewModel
            {
                Preferences = new PreferencesViewModel
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
                },
                Quote = new QuoteViewModel
                {
                    QuoteEntries = new ObservableCollection<QuoteEntryViewModel>(
                        new QuoteEntryViewModel[]
                        {
                            new QuoteEntryViewModel { Group = Constants.QuoteEntryGroups.Fabrication, ParameterName = "Base Fabrication", ParameterValue = "61.2x148.5, 10 layers", TimeImpact = TimeSpan.FromDays(1), CostImpact = 1710.12M },
                            new QuoteEntryViewModel { Group = Constants.QuoteEntryGroups.Fabrication, ParameterName = "Boards Quantity", ParameterValue = "20", TimeImpact = default, CostImpact = 538M },
                            new QuoteEntryViewModel { Group = Constants.QuoteEntryGroups.Fabrication, ParameterName = "Surface Finish", ParameterValue = "Painted", TimeImpact = TimeSpan.FromDays(3), CostImpact = 75M },
                            new QuoteEntryViewModel { Group = Constants.QuoteEntryGroups.Assembly, ParameterName = "Packages", ParameterValue = "Package on Packages", TimeImpact = TimeSpan.FromDays(1), CostImpact = 2700M },
                            new QuoteEntryViewModel { Group = Constants.QuoteEntryGroups.Assembly, ParameterName = "Processes", ParameterValue = "Split Assembly", TimeImpact = default, CostImpact = 720.50M },
                            new QuoteEntryViewModel { Group = Constants.QuoteEntryGroups.Assembly, ParameterName = "Minimum Pitch", ParameterValue = "0.3mm pitch BGA", TimeImpact = default, CostImpact = 804M },
                        })
                }
            };
            model.Preferences.SurfaceFinish = model.Preferences.SurfaceFinishDataSource[3];
            model.Preferences.SolderMaskColor = model.Preferences.SolderMaskColorsDataSource[3];
            InitializeComponent();
            this.DataContext = model;
        }
    }
}
