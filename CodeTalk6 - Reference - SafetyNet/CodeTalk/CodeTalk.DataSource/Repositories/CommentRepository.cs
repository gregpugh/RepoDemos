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
    public class CommentRepository : ICommentRepository
    {

        // Constructor
        private CodeTalkContext codeTalkContext;
        public CommentRepository(CodeTalkContext _codeTalkContext)
        {
            codeTalkContext = _codeTalkContext;
        }


        public IQueryable<Comment> GetComments()
        {
            return codeTalkContext.Comments;
        }

        public Comment GetCommentById(int commentId)
        {
            return codeTalkContext.Comments.FirstOrDefault(c => c.Id == commentId);
        }

        public bool AddComment(Comment newComment)
        {
            codeTalkContext.Comments.Add(newComment);
            codeTalkContext.SaveChanges();
            return true;
        }

        public void EditComment(Comment updatedComment)
        {
            Comment existingComment = codeTalkContext.Comments.FirstOrDefault(c => c.Id == updatedComment.Id);

            existingComment.Body = updatedComment.Body;
            existingComment.DateCreated = updatedComment.DateCreated;
            existingComment.DateModified = DateTime.Now;

            codeTalkContext.SaveChanges();
        }

        public void DeleteComment(int deleteCommentWithThisId)
        {
            Comment deleteThisComment = GetCommentById(deleteCommentWithThisId);
            codeTalkContext.Comments.Remove(deleteThisComment);

            codeTalkContext.SaveChanges();
        }
    }
}
