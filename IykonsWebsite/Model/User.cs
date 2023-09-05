﻿using Microsoft.AspNetCore.Identity;

namespace IykonsWebsite.Model
{
    public class User: IdentityUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
