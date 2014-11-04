using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodeTalk.Domain.Contracts;
using CodeTalk.Domain.Contracts.Repositories;
using CodeTalk.Domain.Models;

namespace CodeTalk.DataSource.Repositories
{
    public class TalkRepository: ITalkRepository
    {
        //3b 
        //private CodeTalkContext ctx;
        private CodeTalkContext codeTalkContext;
        public TalkRepository()
        {
            codeTalkContext = new CodeTalkContext();
        }


        public IQueryable<Talk> GetTalks()
        {
            //3b var ctx = new CodeTalkContext();
            return codeTalkContext.Talks;
        }

        public bool AddTalk(Talk newTalk)
        {
            //3b var ctx = new CodeTalkContext();
            codeTalkContext.Talks.Add(newTalk);
            codeTalkContext.SaveChanges();
            return true;
        }

        //3c
        public Talk GetTalkById(int talkId)
        {
            return codeTalkContext.Talks.FirstOrDefault(t => t.Id == talkId);
        }

        public void EditTalk(Talk updatedTalk)
        {
            Talk existingTalk = codeTalkContext.Talks.FirstOrDefault(t => t.Id == updatedTalk.Id);

            existingTalk.Title = updatedTalk.Title;
            existingTalk.Description = updatedTalk.Description;
            existingTalk.DateCreated = updatedTalk.DateCreated;
            existingTalk.DateModified = DateTime.Now;

            codeTalkContext.SaveChanges();
        }

        public void DeleteTalk(int deleteTalkWithThisId)
        {
            Talk deleteThisTalk = GetTalkById(deleteTalkWithThisId);
            codeTalkContext.Talks.Remove(deleteThisTalk);

            codeTalkContext.SaveChanges();
        }


       
    }
}
