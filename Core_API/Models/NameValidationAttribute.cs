using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_API.Models
{
    public class NameValidationAttribute : ValidationAttribute
    {
        private char FirstCharacter;
        public NameValidationAttribute(char c)
        {
            FirstCharacter = c;
        }
        /// <summary>
        /// Value is the propety value accepted from the Property
        /// on which this validation is applied
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            string str = (string)value;
            //if (!str.StartsWith('D'))
            //{
            //    return false;
            //}
            if (!str.StartsWith(FirstCharacter))
            {
                return false;
            }
            return true;
        }
    }
}
