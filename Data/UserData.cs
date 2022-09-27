using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using review.Entities;

namespace review.Data
{
    public class UserData : DbContext
    {
        public UserData(DbContextOptions options)
            : base(options)
        {
        }

        public  DbSet<AppUser> Users { get; set; }


    }

}