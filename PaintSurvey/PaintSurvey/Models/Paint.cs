using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaintSurvey.Models
{
    public class Paint
    {
        [Key]
        public int key { get; set; }
        public string name { get; set; }
        public float prodRateOne { get; set; }
        public float prodRateTwo { get; set; }
        public float unitRate { get; set; }
        public string surfaceType { get; set; }
        public int order { get; set; }
        public virtual Project project { get; set; }
    }
}
