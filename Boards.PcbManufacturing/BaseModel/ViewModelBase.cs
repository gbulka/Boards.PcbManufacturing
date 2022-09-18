using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Boards.PcbManufacturing.BaseModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged, IDataErrorInfo
    {
        public string this[string propertyName]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(propertyName))
                {
                    throw new ArgumentException("Invalid property name", propertyName);
                }

                string error = string.Empty;
                var value = GetValue(propertyName);
                var results = new List<ValidationResult>();
                var validationContext = new ValidationContext(this, null, null) { MemberName = propertyName };
                var result = Validator.TryValidateProperty(value, validationContext, results);
                if (!result)
                {
                    var validationResult = results.First();
                    error = validationResult.ErrorMessage;
                }

                return error;
            }
        }

        public virtual string Error => null;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private object GetValue(string propertyName)
        {
            var prop = this.GetType().GetProperty(propertyName);
            var value = prop.GetValue(this);
            return value;
        }
    }
}
