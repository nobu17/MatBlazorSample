using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MatTest.Models.Form
{
    public class Form2ViewModel : ComponentBase
    {
        public NestedData NestedData { get; set; } = new NestedData();

        public bool CanSubmit { get; set; }

        public void HandleValidSubmit()
        {
            Console.WriteLine("OnValidSubmit");
        }
    }

    public class NestedData
    {
        [Required]
        [ValidateComplexType]
        public LoginData LoginData { get; set; } = new LoginData();

        [CustomeValidation]
        public string CustomStr { get; set; }
    }

    public class CustomeValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var str = value as string;
            if (str != null && string.IsNullOrWhiteSpace(str))
            {
                return new ValidationResult("空白は無効です。", new[] { validationContext.MemberName });
            }
            return ValidationResult.Success;
        }
    }
}
