using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CodeTalk.Domain.Models;
using CodeTalk.ServiceLayer;

namespace CodeTalk.Controllers
{
    public class TalkController : Controller
    {
        //3h
        // Constructor
        private TalkService talkService;
        public TalkController()
        {
            talkService = new TalkService();
        }


        public ActionResult Index()
        {
            //3h -//var talkService = new TalkService();
            var talks = talkService.GetTalks();
            return View(talks);
        }


        public ActionResult Insert()
        {

            //var talk = new Talk();
            //return View(talk);
           
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Talk newTalk)
        {
            //3h - //var talkService = new TalkService();
            talkService.AddTalk(newTalk);
            //return View();
            return RedirectToAction("Index");
        }

        //3i
        public ActionResult Edit(int id)
        {
            Talk talk = talkService.GetTalkById(id);
            return View(talk);
        }

        [HttpPost]
        public ActionResult Edit(Talk updatedTalk)
        {
            talkService.EditTalk(updatedTalk);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Talk talk = talkService.GetTalkById(id);
            return View(talk);

        }

        public ActionResult Delete(int id)
        {
            int deleteTalkWithThisId = id;
            talkService.DeleteTalk(deleteTalkWithThisId);
            return RedirectToAction("Index");
        }
    }
}
