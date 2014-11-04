using CodeTalks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalks.Data.Contracts
{
    public interface ICodeTalksRepository
    {
        IQueryable<Talk> GetTalks();
        //IQueryable<Talk> GetTalksIncludingComments();
        
        IQueryable<Comment> GetCommentsByTalk(int talkId);

        //bool Save();

        //bool AddTalk(Talk newTalk);
        //bool AddComment(Comment newComment);
    }

}
