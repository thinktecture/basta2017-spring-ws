using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BASTAWorkshop.API
{
    public class Session
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}