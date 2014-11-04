using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodeTalk.Domain.Models;

namespace CodeTalk.Domain.Contracts.Services
{
    public interface ICommentService
    {
        IList<Comment> GetComments();
        Comment GetCommentById(int commentId);
        bool AddComment(Comment newComment);
        void EditComment(Comment updatedComment);
        void DeleteComment(int deleteCommentWithThisId);
    }
}
