using CodeTalk.DataSource.Repositories;
using CodeTalk.Domain.Contracts.Services;
using CodeTalk.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.ServiceLayer
{
    public class TalkService : ITalkService
    {
        public IList<Talk> GetTalks()
        {
            var repo = new TalkRepository();
            return repo.GetTalks().ToList();
        }

        public bool AddTalk(Talk newTalk)
        {
            var repo = new TalkRepository();
            return repo.AddTalk(newTalk);
        }
    }
}
