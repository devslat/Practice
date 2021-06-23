using System;
using System.Text.RegularExpressions;

namespace AttributesValidation.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    class ValidCharacters : RegexAttribute
    {
        public ValidCharacters() : base(@"^[a-z0-9]*$", RegexOptions.IgnoreCase)
        {
            ErrorMessage = "Caracteres invalidos.";
        }
    }
}
