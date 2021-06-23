using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Text.Json;

using System.Net;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Net.Http;
using System.ComponentModel.DataAnnotations;

namespace AttributesValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            Ejemplo Obj = new Ejemplo();
            Obj.Description = "123456789123%#z";
            Obj.AuthorizationLimit = 3456;
            Obj.mpahcr = "10:01:003";

            var validationContext = new ValidationContext(Obj, null, null);
            var results = new List<ValidationResult>();


            if (Validator.TryValidateObject(Obj, validationContext, results, true))
            {
                Console.WriteLine("Hello World!");
            }
            else
            {
                Console.WriteLine("Not Hello World!");
            }





        }

    }

}
