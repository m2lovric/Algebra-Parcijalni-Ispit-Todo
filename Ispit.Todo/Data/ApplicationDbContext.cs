using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Ispit.Todo.Models;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ispit.Todo.Data
{
    public class ApplicationUser: IdentityUser
    {
        [ForeignKey("UserId")]
        public virtual ICollection<Todolist> Todolists { get; set; }
    }
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Todolist> Todolist { get; set; }

        public DbSet<Models.Task> Task { get; set; }
    }
}
