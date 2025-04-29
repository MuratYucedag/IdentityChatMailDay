using IdentityChatMailDay.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatMailDay.Context
{
    public class MailContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R7AR1ND;initial Catalog=EmailChatDb;integrated Security=true;trust server certificate=true");
        }
    }
}
