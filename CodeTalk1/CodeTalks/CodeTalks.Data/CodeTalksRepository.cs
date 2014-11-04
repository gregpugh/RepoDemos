using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTalks.Data.Contracts;

using CodeTalks.Model;

namespace CodeTalks.Data
{
    public class CodeTalksRepository: ICodeTalksRepository
    {
        public IQueryable<Talk> GetTalks()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Comment> GetCommentsByTalk(int talkId)
        {
            throw new NotImplementedException();
        }
    }
}
