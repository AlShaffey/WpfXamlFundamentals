using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfXaml
{
    public class Person : INotifyPropertyChanged, IDataErrorInfo
    {
        private double _age;
        public double Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertChanged(nameof(Age));
                }
            }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertChanged(nameof(Name));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string this[string columnName] => Validate(columnName);

        public string Error => throw new NotImplementedException();

        private string Validate(string columnName)
        {
            var result = string.Empty;

            switch (columnName)
            {
                case nameof(Age):
                    if (Name == "m.2" && Age >= 26 && Age <= 30)
                    {
                        result = $"{Name} should not be within (26 - 30) years old!";
                    }
                    break;
                case nameof(Name): break;
                default: throw new ArgumentException($"Unknown property: {columnName}, columnName");
            }

            return result;
        }
    }
}
