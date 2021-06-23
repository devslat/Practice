using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using AttributesValidation.Attributes;

namespace AttributesValidation
{

    class Ejemplo 
    {
        [ValidCharacters(ErrorMessage = "Caracteres invalidos en el campo: {0}!!")]
        [MaxStrLength(3, ErrorMessage = "El valor ingresado en el campo: {0}, supera el maximo de caracteres!!")]
        public string Description { get; set; }

        [SmallTime(ErrorMessage = "Ingreso de hora invalido en el campo {0}, hora: HH:MM:SS")]
        public string mpahcr { get; set; }


        [Range(0, (Int64)999, ErrorMessage = "El valor ingresado en el campo {0}, debe estar entre {1} and {2}!!")]
        public Int64 AuthorizationLimit { get; set; }
    }

}
