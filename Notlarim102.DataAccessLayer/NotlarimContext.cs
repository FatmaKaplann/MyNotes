using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notlarim102.Entity;

namespace Notlarim102.DataAccessLayer
{
    public class NotlarimContext:DbContext
    {
        public DbSet<NotlarimUser> NotlarimUsers { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Liked> Likes { get; set; }

        public NotlarimContext()
        {
            Database.SetInitializer(new MyInitializer());
        }

    }
}
