using CodeTalk.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.Domain.Contracts.Services
{
    public interface ITalkService
    {
        IList<Talk> GetTalks();
        bool AddTalk(Talk newTalk);
    }
}
