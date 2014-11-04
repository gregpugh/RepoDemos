using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodeTalk.Domain.Models;
using CodeTalk.Domain.Contracts.Repositories;

namespace CodeTalk.DataSource
{
    public class FakeCommentRepository : ICommentRepository
    {
        public List<Talk> Talks { get; set; }
        public List<Comment> Comments { get; set; }

        public FakeCommentRepository()
        {
            // Initialize lists 

            //// Talks
            //Talks = new List<Talk>();

            //Talk t = new Talk();
            //t.Id = 1;
            //t.Title = "Title1";
            //t.Description = "Description1";
            //t.Comments = new List<Comment>();
            //t.DateCreated = Convert.ToDateTime("1/1/2013");
            //t.DateModified = Convert.ToDateTime("1/1/2013");
            //Talks.Add(t);

            //t = new Talk();
            //t.Id = 2;
            //t.Title = "Title2";
            //t.Description = "Description2";
            //t.Comments = new List<Comment>();
            //t.DateCreated = Convert.ToDateTime("2/2/2013");
            //t.DateModified = Convert.ToDateTime("2/2/2013");
            //Talks.Add(t);

            //t = new Talk();
            //t.Id = 3;
            //t.Title = "Title3";
            //t.Description = "Description3";
            //t.Comments = new List<Comment>();
            //t.DateCreated = Convert.ToDateTime("3/3/2013");
            //t.DateModified = Convert.ToDateTime("3/3/2013");
            //Talks.Add(t);

            
            // Comments
            Comments = new List<Comment>();

            Comment c = new Comment();
            c.Id = 1;
            c.TalkId = 1;
            c.Body = "Body1.1";
            c.Commentor = "Commentor1.1";
            c.DateCreated = Convert.ToDateTime("1/1/2013");
            c.DateModified = Convert.ToDateTime("1/1/2013");
            Comments.Add(c);

            c = new Comment();
            c.Id = 2;
            c.TalkId = 1;
            c.Body = "Body1.2";
            c.Commentor = "Commentor1.2";
            c.DateCreated = Convert.ToDateTime("1/2/2013");
            c.DateModified = Convert.ToDateTime("1/2/2013");
            Comments.Add(c);

            c = new Comment();
            c.Id = 3;
            c.TalkId = 2;
            c.Body = "Body2.1";
            c.Commentor = "Commentor2.1";
            c.DateCreated = Convert.ToDateTime("2/1/2013");
            c.DateModified = Convert.ToDateTime("2/1/2013");
            Comments.Add(c);

            c = new Comment();
            c.Id = 4;
            c.TalkId = 2;
            c.Body = "Body2.2";
            c.Commentor = "Commentor2.2";
            c.DateCreated = Convert.ToDateTime("2/2/2013");
            c.DateModified = Convert.ToDateTime("2/2/2013");
            Comments.Add(c);

            c = new Comment();
            c.Id = 5;
            c.TalkId = 3;
            c.Body = "Body3.1";
            c.Commentor = "Commentor3.1";
            c.DateCreated = Convert.ToDateTime("3/1/2013");
            c.DateModified = Convert.ToDateTime("3/1/2013");
            Comments.Add(c);

            c = new Comment();
            c.Id = 6;
            c.TalkId = 3;
            c.Body = "Body3.2";
            c.Commentor = "Commentor3.2";
            c.DateCreated = Convert.ToDateTime("3/2/2013");
            c.DateModified = Convert.ToDateTime("3/2/2013");
            Comments.Add(c);

        }

        //Talk Repository Methods
        //public IQueryable<Talk> GetTalks()
        //{
        //    return Talks.AsQueryable<Talk>();
        //}

        //public Talk GetTalkById(int talkId)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool AddTalk(Talk newTalk)
        //{
        //    throw new NotImplementedException();
        //}

        //public void EditTalk(Talk updatedTalk)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteTalk(int deleteTalkWithThisId)
        //{
        //    throw new NotImplementedException();
        //}

        
        
        //Comment Reposistory Methods
        public IQueryable<Comment> GetComments()
        {
            return Comments.AsQueryable<Comment>(); 
        }

        public Comment GetCommentById(int commentId)
        {
            throw new NotImplementedException();
        }

        public bool AddComment(Comment newComment)
        {
            throw new NotImplementedException();
        }

        public void EditComment(Comment updatedComment)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int deleteCommentWithThisId)
        {
            throw new NotImplementedException();
        }
    }
}
