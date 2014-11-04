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
        //Constructor
        private CodeTalkContext codeTalkContext;
        public TalkRepository()
        {
            codeTalkContext = new CodeTalkContext();
        }


        public IQueryable<Talk> GetTalks()
        {
            return codeTalkContext.Talks.Include("Comments"); //4g.1
        }

        public Talk GetTalkById(int talkId)
        {
            return codeTalkContext.Talks.FirstOrDefault(t => t.Id == talkId);
        }

        public bool AddTalk(Talk newTalk)
        {
            codeTalkContext.Talks.Add(newTalk);
            codeTalkContext.SaveChanges();
            return true;
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
