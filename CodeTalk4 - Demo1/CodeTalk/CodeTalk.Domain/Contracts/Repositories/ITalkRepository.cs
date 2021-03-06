﻿using CodeTalk.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.Domain.Contracts.Repositories
{
    public interface ITalkRepository
    {
        IQueryable<Talk> GetTalks();
        Talk GetTalkById(int talkId);
        bool AddTalk(Talk newTalk);
        void EditTalk(Talk updatedTalk);
        void DeleteTalk(int deleteTalkWithThisId);
    }
}
