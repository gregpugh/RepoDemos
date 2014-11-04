using CodeTalks.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalks.Data
{
    public class CodeTalksContext: DbContext
    {
        public CodeTalksContext()
            : base("DefaultConnection")
        { 
        }

        public DbSet<Talk> Talks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
