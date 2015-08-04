using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaintSurvey.Models
{
    public class DefaultRoom
    {
        [Key]
        public int key { get; set; }
        public string name { get; set; }
        public float roomLength { get; set; }
        public float roomWidth { get; set; }
        public float roomHeight { get; set; }
        public float doorWidth { get; set; }
        public float doorHeight { get; set; }
        public float windowWidth { get; set; }
        public float windowHeight { get; set; }
        public float radiatorWidth { get; set; }
        public float radiatorHeight { get; set; }
    }
}