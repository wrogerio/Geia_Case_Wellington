using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.DTO
{
    public class CustomValidation: ValidationAttribute
    {
        public CustomValidation()
        {
            
        }

        public override bool IsValid(object? value)
        {
            var dt = (DateTime) value;
            
            return base.IsValid(value);
        }
    }
}
