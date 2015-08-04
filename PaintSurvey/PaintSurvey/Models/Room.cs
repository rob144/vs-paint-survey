using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaintSurvey.Models
{
    public class Room
    {
        [Key]
        public int key { get; set; }
        public string name { get; set; }
        public DateTime dateCreated { get; set; }
        public float roomHoursAdjust { get; set; }
        public float roomLength { get; set; }
        public float roomWidth { get; set; }
        public float roomHeight { get; set; }
        public float ceilingAdjustSimple { get; set; }
        public float wallAdjustSimple { get; set; }
        public float skirtingAdjustSimple { get; set; }
        public string groupItems { get; set; } //json
        public virtual Project project { get; set; } //m to 1 Relationship with Project
    }
}