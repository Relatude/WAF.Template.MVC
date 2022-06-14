using System.ComponentModel.DataAnnotations;

namespace App.Server.Models {
    public class LoginModel {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
