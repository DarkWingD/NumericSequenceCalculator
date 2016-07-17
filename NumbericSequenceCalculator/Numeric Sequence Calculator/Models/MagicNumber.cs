using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Numeric_Sequence_Calculator.Models
{
    public class MagicNumber
    {
        [Required]
        [Range(1,9999999,ErrorMessage = "Please enter a number that is greater than 1 but less than 9999999")]
        public int Number { get; set; }
    }
}