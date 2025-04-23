using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class Register
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


    }
}
