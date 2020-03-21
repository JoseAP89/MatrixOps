using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace Matrices.Models
{
    public class InfoOp//:IValidatableObject
    {
        
        public int RowA { get; set; }

        public int ColA { get; set; }

        public int RowB { get; set; }

        public int ColB { get; set; }
        public OpType Operation { get; set; }
        public double[] Data { get; set; }
        
        /* public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            
        } */

    }
}