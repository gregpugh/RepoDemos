using CodeTalk.Domain.Models;
using CodeTalk.ServiceLayer;
using CodeTalk.Domain.Contracts.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodeTalk.Controllers.Api
{
    public class TalksController : ApiController
    {
        //6a

        private ITalkService _talkService;
        public TalksController(ITalkService talkService)
        {
            _talkService = talkService;
        }

        //6b
        public IEnumerable<Talk> Get()
        {
           var talks =  _talkService.GetTalks()
                                    .OrderByDescending(t => t.DateCreated)
                                    .Take(50);
           return talks;
        }

        //6e
        public HttpResponseMessage Post([FromBody]Talk newTalk)
        {
            if (_talkService.AddTalk(newTalk))
            {
                return Request.CreateResponse(HttpStatusCode.Created, newTalk);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

    }
}
