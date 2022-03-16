using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bookman.Models
{
    public class IDDBContext : IdentityDbContext<IdentityUser>
    {
        public IDDBContext(DbContextOptions options): base(options)
        {

        }
    }
}
