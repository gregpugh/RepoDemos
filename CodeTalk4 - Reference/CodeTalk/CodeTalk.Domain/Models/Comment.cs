using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeTalk.Domain.Models
{
    public class Comment
    {
        public Comment()
        {
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }

        public int Id { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public string Commentor { get; set; } // 4j

        public int TalkId { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

    }
}
