using System;
using Microsoft.AspNetCore.Identity;

namespace StockManager.Areas.Identity.Data
{
    public class StockManagerUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
    }
}
