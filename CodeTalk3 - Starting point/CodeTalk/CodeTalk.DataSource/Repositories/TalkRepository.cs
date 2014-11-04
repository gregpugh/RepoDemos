using CodeTalk.Domain.Contracts.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.DataSource.Repositories
{
    public class TalkRepository: ITalkRepository
    {
        public IQueryable<Domain.Models.Talk> GetTalks()
        {
            var ctx = new CodeTalkContext();
            return ctx.Talks;
        }

        public bool AddTalk(Domain.Models.Talk newTalk)
        {
            var ctx = new CodeTalkContext();
            ctx.Talks.Add(newTalk);
            ctx.SaveChanges();

            return true;
        }
    }
}
