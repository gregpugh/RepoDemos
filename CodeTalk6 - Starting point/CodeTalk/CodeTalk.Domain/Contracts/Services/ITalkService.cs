using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodeTalk.Domain.Models;

namespace CodeTalk.Domain.Contracts.Services
{
    public interface ITalkService
    {
        IList<Talk> GetTalks();
        Talk GetTalkById(int talkId);
        bool AddTalk(Talk newTalk);
        void EditTalk(Talk updatedTalk);
        void DeleteTalk(int deleteTalkWithThisId);
    }
}
