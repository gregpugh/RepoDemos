using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CodeTalk.Domain.Models;
using CodeTalk.ServiceLayer;
using CodeTalk.Domain.Contracts.Services; //5c

namespace CodeTalk.Controllers
{
    public class TalkController : Controller
    {

        // Constructor
        private ITalkService talkService;
        public TalkController(ITalkService _talkService)
        {
            talkService = _talkService;
        }


        public ActionResult Index()
        {
            var talks = talkService.GetTalks();
            return View(talks);
        }


        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Talk newTalk)
        {
            talkService.AddTalk(newTalk);
            return RedirectToAction("Index");
        }

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
