using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.Domain.Models
{
    public class Talk
    {
        public Talk()
        {
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        ICollection<Comment> Comments { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

    }
}
