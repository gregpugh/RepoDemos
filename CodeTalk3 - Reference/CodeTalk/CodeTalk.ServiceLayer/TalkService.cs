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
        //3f - rename repo //private ITalkRepository repo;
        //3e -private var and constructor
        private ITalkRepository talkRepository;
        public TalkService()
        {
            //3e  //repo = new TalkRepository();
            talkRepository = new TalkRepository();
        }
        
        public IList<Talk> GetTalks()
        {
            //3e  //var repo = new TalkRepository();
            return talkRepository.GetTalks().ToList();
        }

        public bool AddTalk(Domain.Models.Talk newTalk)
        {
            //3e  //var repo = new TalkRepository();
            return talkRepository.AddTalk(newTalk);
        }

        //3g
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
