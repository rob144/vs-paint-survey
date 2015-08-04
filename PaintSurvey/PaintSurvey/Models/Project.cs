using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaintSurvey.Models
{
    public class Project
    {
        [Key]
        public int key { get; set; }
        public string title { get; set; }
        public string username { get; set; }
        public DateTime dateCreated { get; set; }
        public virtual ICollection<Room> rooms { get; set; } //1 to m Relationship to Room model
        public virtual ICollection<Paint> paints { get; set; } //1 to m Relationship to Paint model
    }
}