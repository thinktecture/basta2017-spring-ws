using System;
using System.Collections.Generic;

namespace BASTAWorkshop.API
{
    public class Session
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public DateTime Time { get; set; }
        //public List<Speaker> Speakers { get; set; }
    }
}