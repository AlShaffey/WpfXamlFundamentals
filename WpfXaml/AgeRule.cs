using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfXaml
{
    public class AgeRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var validationResult = ValidationResult.ValidResult;

            if (value == null)
            {
                validationResult = new ValidationResult(false, "Age is missing!");
            }
            else
            {
                var textualAge = value.ToString();

                if (!double.TryParse(textualAge, out double age))
                {
                    validationResult = new ValidationResult(false, "Type is incorrect!");
                }
                else
                {
                    try
                    {

                        if (age <= 25 && age >= 22)
                        {
                            validationResult = new ValidationResult(false, "A person should not be within (22 - 25) years old!");
                        }
                    }
                    catch (Exception)
                    {
                        validationResult = new ValidationResult(false, "Conversion to double failed!");
                    }
                }

            }
            return validationResult;
        }
    }
}
