﻿namespace AuthenticationService.Models
{
    public class RegisterModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TokenId { get; set; }
    }
}