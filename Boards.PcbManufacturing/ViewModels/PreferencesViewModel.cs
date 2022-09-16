using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Xml.Linq;
using Boards.Dto;
using Boards.PcbManufacturing.BaseModel;

namespace Boards.PcbManufacturing.ViewModels
{
    public class PreferencesViewModel : ViewModelBase
    {
        private string _projectName;
        private string _zipCode;
        private int _boardsQuantity;
        private double _boardThickness;
        private Material _material;
        private SurfaceFinish _surfaceFinish;
        private Color _color;

        [Required(ErrorMessage = "Project Name is required.")]
        [StringLength(50, ErrorMessage = "No more than 50 characters")]
        public string ProjectName
        { 
            get => _projectName; 
            set
            {
                _projectName = value;
                this.OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "Zipcode is required.")]
        [RegularExpression(@"\d{2}-\d{3}", ErrorMessage = "This value is not a postal code.")]
        public string ZipCode
        { 
            get => _zipCode; 
            set
            {
                _zipCode = value;
                this.OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "Boards Quantity is required.")]
        [RegularExpression(@"\d{*}", ErrorMessage = "Integer value required.")]
        public int BoardsQuantity
        {
            get => _boardsQuantity; 
            set
            {
                _boardsQuantity = value;
                this.OnPropertyChanged();
            } 
        }

        public double BoardThickness
        { 
            get => _boardThickness;
            set
            {
                _boardThickness = value;
                this.OnPropertyChanged();
            } 
        }

        public Material Material
        {
            get => _material;
            set 
            {
                _material = value;
                this.OnPropertyChanged();
            } 
        }

        public SurfaceFinish SurfaceFinish 
        { 
            get => _surfaceFinish; 
            set 
            {
                _surfaceFinish = value;
                this.OnPropertyChanged();
            } 
        }

        public Color Color 
        { 
            get => _color; 
            set 
            {
                _color = value;
                this.OnPropertyChanged();
            } 
        }

        public ObservableCollection<Material> MaterialsDataSource
        {
            get
            {
                return new ObservableCollection<Material>(
                    new Material[] {
                        new Material { Id = 1, Name = "Steel" },
                        new Material { Id = 2, Name = "Wood" },
                        new Material { Id = 3, Name = "Rubber" },
                        new Material { Id = 4, Name = "Plastic" },
                        new Material { Id = 5, Name = "Stone" },
                    });
            }
        }
    }
}
