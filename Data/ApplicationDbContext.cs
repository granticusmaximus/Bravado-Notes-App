using Bravado_Notes_App.Models.Wiki;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bravado_Notes_App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #region WIKIS 
        public DbSet<Entry> Entries { get; set; }
        #endregion
    }
}
