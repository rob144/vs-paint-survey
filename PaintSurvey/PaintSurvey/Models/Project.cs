using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaintSurvey.Models
{
    public class Project
    {
        public int key { get; set; }
        public string username { get; set; }
        public string title { get; set; }
        public DateTime dateCreated { get; set; }
        public virtual ICollection<Room> rooms { get; set; } //1 to m Relationship to Room model
        public virtual ICollection<Room> paints { get; set; } //1 to m Relationship to Paint model
    }
}