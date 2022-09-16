﻿using System.ComponentModel.DataAnnotations;
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
        [RegularExpression(
            @"(^\d{5}(-\d{4})?$)"+
            @"|(^[ABCEGHJKLMNPRSTVXYabceghjklmnprstvxy]{1}\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstv‌​xy]{1} *\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstvxy]{1}\d{1}$)"+
            @"|\d{2}-\d{3}", 
            ErrorMessage = "That postal code is not a valid US or Canadian postal code.")]
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
