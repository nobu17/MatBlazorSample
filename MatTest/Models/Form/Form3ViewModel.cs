using FluentValidation;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatTest.Models.Form
{
    public class Form3ViewModel : ComponentBase
    {
        public LoginData2 LoginData { get; set; } = new LoginData2();

        public void HandleValidSubmit()
        {
            // do something
        }
    }

    public class LoginData2
    {
        public string UserID { get; set; }

        public string Password { get; set; }
    }

    public class LoginDataValidator : AbstractValidator<LoginData2>
    {
        public LoginDataValidator()
        {
            RuleFor(p => p.UserID).NotEmpty().WithMessage("ログインIDを入力してください。");
            RuleFor(p => p.UserID).MaximumLength(10).WithMessage("ログインIDは10文字まで入力してください。");
            RuleFor(p => p.Password).NotEmpty().WithMessage("パスワードを入力してください。");
            RuleFor(p => p.Password).MaximumLength(10).WithMessage("パスワードは10文字まで入力してください。");
        }
    }
}
