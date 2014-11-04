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
    public class CommentService : ICommentService
    {
        //5f

        //Constructor
        private ICommentRepository commentRepository;
        public CommentService(ICommentRepository _commentRepository)
        {
            commentRepository = _commentRepository;
        }

        ////Constructor
        //private ICommentRepository commentRepository;
        //public CommentService()
        //{
        //    commentRepository = new CommentRepository();
        //}


        public IList<Comment> GetComments()
        {
            return commentRepository.GetComments().ToList();
        }

        public Comment GetCommentById(int commentId)
        {
            return commentRepository.GetCommentById(commentId);
        }

        public bool AddComment(Comment newComment)
        {
            return commentRepository.AddComment(newComment);
        }

        public void EditComment(Comment updatedComment)
        {
            commentRepository.EditComment(updatedComment);
        }

        public void DeleteComment(int deleteCommentWithThisId)
        {
            commentRepository.DeleteComment(deleteCommentWithThisId);
        }
    }
}
