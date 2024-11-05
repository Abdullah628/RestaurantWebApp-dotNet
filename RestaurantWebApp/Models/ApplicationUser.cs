﻿using Microsoft.AspNetCore.Identity;

namespace RestaurantWebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }


    }
}