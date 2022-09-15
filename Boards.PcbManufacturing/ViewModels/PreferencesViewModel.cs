using Boards.Dto;
using Boards.PcbManufacturing.BaseModel;

namespace Boards.PcbManufacturing.ViewModels
{
    internal class PreferencesViewModel : ViewModelBase
    {
        private string _projectName;
        private string _zipCode;
        private int _boardsQuantity;
        private double _boardThickness;
        private Material _material;
        private SurfaceFinish _surfaceFinish;
        private Color _color;

        public string ProjectName
        { 
            get => _projectName; 
            set
            {
                _projectName = value;
                this.OnPropertyChanged();
            }
        }

        public string ZipCode
        { 
            get => _zipCode; 
            set
            {
                _zipCode = value;
                this.OnPropertyChanged();
            }
        }

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
    }
}
