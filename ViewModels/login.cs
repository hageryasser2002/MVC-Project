﻿using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class login
    {

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
