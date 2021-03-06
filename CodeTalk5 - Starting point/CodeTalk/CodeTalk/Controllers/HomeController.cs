﻿using CodeTalk.Domain.Models;
using CodeTalk.ServiceLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTalk.Controllers
{
    public class HomeController : Controller
    {
        
        //Constructor
        private TalkService talkService;  
        private CommentService commentService; 
        public HomeController()
        {
            talkService = new TalkService();        
            commentService = new CommentService();  
        }

       
        public ActionResult Index()
        {
            var talks = talkService.GetTalks().OrderByDescending(t => t.DateCreated);

            return View(talks);
        }

      
        public ActionResult SubmitTalk()
        {
            ViewBag.Message = "Describe your talk";

            return View();
        }
        [HttpPost]
        public ActionResult SubmitTalk(Talk newTalk)
        {
            talkService.AddTalk(newTalk);
            return RedirectToAction("Index");
        }

        public ActionResult AddComment(int id)
        {
            Comment comment = new Comment() { TalkId = id }; 
            return View(comment);
        }
        [HttpPost]
        public ActionResult AddComment(Comment newComment)
        {
            commentService.AddComment(newComment);
            return RedirectToAction("Index");
        }

        //
        //
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
