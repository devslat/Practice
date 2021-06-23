using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AttributesValidation.Attributes
{
    
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MaxStrLength : ValidationAttribute
    {
        public MaxStrLength(double max)
        {
            Max = max;
        }
        public double Max { get; set; } = 0;

        public override bool IsValid(object value)
        {

            double count = 0; bool vLength = true;
            string strText = value.ToString();
            foreach (char c in strText)
            {
                count++;
                if (count >= Max)
                {
                    vLength = false;
                    break;
                }

            }
            return vLength;
        }
    }
}
