﻿namespace Angular_app.ViewModel.Account
{
    using System.ComponentModel.DataAnnotations;

    public class LoginVM
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}