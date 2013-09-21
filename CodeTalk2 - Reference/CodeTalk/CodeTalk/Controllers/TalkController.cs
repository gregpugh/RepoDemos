using CodeTalk.Domain.Models;
using CodeTalk.ServiceLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTalk.Controllers
{
    public class TalkController : Controller
    {
        public ActionResult Index()
        {
            var talkService = new TalkService();
            var talks = talkService.GetTalks();
            return View(talks);
        }

        public ActionResult Insert()
        {
            var talk = new Talk();
            return View(talk);
        }

        [HttpPost]
        public ActionResult Insert(Talk newTalk)
        {
            var talkService = new TalkService();
            talkService.AddTalk(newTalk);
            return View();
        }

    }
}
