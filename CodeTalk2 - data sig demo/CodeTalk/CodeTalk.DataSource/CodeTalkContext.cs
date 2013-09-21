using CodeTalk.Domain.Models;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.DataSource
{
    class CodeTalkContext : DbContext
    {
        public DbSet<Talk> Talks { get; set; }
    }
}

