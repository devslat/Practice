

namespace AttributesValidation.Attributes
{
    using System;
    using System.Text.RegularExpressions;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class SmallTime : ValidationAttribute
    {

        //Ejemplo con validaciones multiples y expresion regular
        public override bool IsValid(object value)
        {
            if (value == null) return true;
            DateTime TimeCompare;
            string pattern = @"^([0-1]\d|2[0-3]):([0-5]\d):([0-5]\d)$";
            Match mt = Regex.Match(value.ToString(), pattern);
            if (string.IsNullOrEmpty(mt.Value))
            {
                return false;
            }
            else
            {
                if (DateTime.TryParse(value.ToString(), out TimeCompare))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
