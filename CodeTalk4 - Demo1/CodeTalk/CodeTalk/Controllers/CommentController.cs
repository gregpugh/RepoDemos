using CodeTalk.Domain.Models;
using CodeTalk.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTalk.Controllers
{
    public class CommentController : Controller
    {
        
        //Constructor
        private CommentService commentService;
        public CommentController()
        {
            commentService = new CommentService();
        }


        public ActionResult Index()
        {
            var comments = commentService.GetComments();
            return View(comments);
        }

        public ActionResult Insert(int id)
        {
            Comment comment = new Comment() { TalkId = id };
            return View(comment);
        }

        [HttpPost]
        public ActionResult Insert(Comment newComment)
        {
            commentService.AddComment(newComment);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Comment comment = commentService.GetCommentById(id);
            return View(comment);
        }

        [HttpPost]
        public ActionResult Edit(Comment updatedComment)
        {
            commentService.EditComment(updatedComment);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Comment comment = commentService.GetCommentById(id);
            return View(comment);
        }

    }
}
