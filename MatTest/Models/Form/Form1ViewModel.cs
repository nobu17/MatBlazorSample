using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MatTest.Models.Form
{
    public class Form1ViewModel : ComponentBase
    {
        public LoginData LoginData { get; set; } = new LoginData();

        public void HandleValidSubmit()
        {
            // do something
        }
    }

    public class LoginData
    {
        [Required(ErrorMessage = "ユーザIDを入力してください。")]
        [StringLength(16, ErrorMessage = "ユーザIDが長すぎます。")]
        public string UserID { get; set; }

        [Required(ErrorMessage = "パスワードを入力してください。")]
        [StringLength(32, ErrorMessage = "パスワードが長すぎます。")]
        public string Password { get; set; }
    }
}
