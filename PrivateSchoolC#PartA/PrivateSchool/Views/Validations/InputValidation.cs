using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Validations
{
    public class InputValidation
    {
        public static bool HasOnlyLetters(string str)
        {
            str.All(x => Char.IsLetter(x));

            return false;
        }
        public static bool HasOnlyDigits(string str)
        {
            str.All(x => Char.IsDigit(x));
            return false;
        }
    }
}
