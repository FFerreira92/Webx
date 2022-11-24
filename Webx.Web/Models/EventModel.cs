﻿using Webx.Web.Data.Entities;

namespace Webx.Web.Models
{
    public class EventModel 
    {
        public int id { get; set; }

        public string title { get; set; }

        public string start { get; set; }

        public string end { get; set; }

        public string eventDescription { get; set; }

        public bool hasAttended { get; set; }

        public int eventOrderId { get; set; }
    }
}
