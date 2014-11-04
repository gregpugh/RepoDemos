using CodeTalk.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.Domain.Contracts.Repositories
{
    public interface ICommentRepository
    {
        //IQueryable<Comment> GetCommentsByTalk(int talkId);
        IQueryable<Comment> GetComments();
        Comment GetCommentById(int commentId);
        bool AddComment(Comment newComment);
        void EditComment(Comment updatedComment);
        void DeleteComment(int deleteCommentWithThisId);
    }
}
