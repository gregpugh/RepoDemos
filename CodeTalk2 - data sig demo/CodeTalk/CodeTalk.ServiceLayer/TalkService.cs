using CodeTalk.Domain.Contracts.Services;
using CodeTalk.DataSource;
using CodeTalk.DataSource.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.ServiceLayer
{
    public class TalkService : ITalkService
    {
        public IList<Domain.Models.Talk> GetTalks()
        {
            var repo = new TalkRepository();
            return repo.GetTalks().ToList();
        }

        public bool AddTalk(Domain.Models.Talk newTalk)
        {
            var repo = new TalkRepository();
            return repo.AddTalk(newTalk);
        }
    }
}
