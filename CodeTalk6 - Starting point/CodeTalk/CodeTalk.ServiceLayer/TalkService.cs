using CodeTalk.Domain.Models;
using CodeTalk.Domain.Contracts.Repositories;
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
       
        //Constructor
        private ITalkRepository talkRepository;
        public TalkService(ITalkRepository _talkRepository)
        {
            talkRepository = _talkRepository;
        }


        public IList<Talk> GetTalks()
        {
            return talkRepository.GetTalks().ToList();
        }

        public bool AddTalk(Talk newTalk)
        {
            return talkRepository.AddTalk(newTalk);
        }

        public Talk GetTalkById(int talkId)
        {
            return talkRepository.GetTalkById(talkId);
        }

        public void EditTalk(Talk updatedTalk)
        {
            talkRepository.EditTalk(updatedTalk);
        }

        public void DeleteTalk(int deleteTalkWithThisId)
        {
            talkRepository.DeleteTalk(deleteTalkWithThisId);
        }
    }
}
