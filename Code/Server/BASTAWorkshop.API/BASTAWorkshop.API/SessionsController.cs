using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BASTAWorkshop.API
{
    public class SessionsController: ApiController
    {
        private static ConcurrentDictionary<Guid, Session> _database;

        static SessionsController()
        {
            _database = new ConcurrentDictionary<Guid, Session>();
        }

        [HttpGet]
        [ActionName("ping")]
        public string Ping()
        {
            return "Ok";
        }

        [HttpPost]
        [ActionName("details")]
        public Session AddSession(Session session)
        {
            var sessionId = Guid.NewGuid();
            session.Id = sessionId;

            session.Speakers.ForEach(s =>
            {
                var speakerId = Guid.NewGuid();
                s.Id = speakerId;
            });

            _database.TryAdd(sessionId, session);

            return session;
        }

        [HttpGet]
        [ActionName("list")]
        public List<Session> GetSessions()
        {
            return _database.Values.ToList();
        }

        [HttpGet]
        [ActionName("details")]
        public Session GetSession(Guid id)
        {
            Session session;
            var success = _database.TryGetValue(id, out session);

            if(success)
            {
                return session;
            }
            else
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, String.Format("Session {0} not found.", id)));
            }
        }
    }
}