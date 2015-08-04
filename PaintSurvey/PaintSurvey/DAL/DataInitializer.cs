using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using PaintSurvey.DAL;
using PaintSurvey.Models;

namespace PaintSurvey.DAL
{
    public static class DataInitializer
    {
        public static void initData()
        {
            PaintSurveyContext db = new PaintSurveyContext();

            var paintData = new List<ArrayList>(){ 
                new ArrayList() { "1 Vinyl Matt", 20f, 5f, 10f, "Ceilings", 1 },
                new ArrayList() { "2 Vinyl Matt", 10f, 5f, 10f, "Ceilings", 2 },
                new ArrayList() { "2 Eggshell", 9f, 5f, 10f, "Ceilings", 3 },

                new ArrayList() { "Wallpaper", 4.5f, 5f, 10f, "Walls", 1 },
                new ArrayList() { "2 Vinyl Matt", 10f, 5f, 10f, "Walls", 2 },
                new ArrayList() { "2 Eggshell", 9f, 5f, 10f, "Walls", 3 },

                new ArrayList() { "General surface", 4f, 5f, 10f, "Doors", 1 },
                new ArrayList() { "Glazed med pane", 3.5f, 5f, 10f, "Doors", 2 },
                new ArrayList() { "Glazed small pane", 2.5f, 5f, 10f, "Doors", 3 },

                new ArrayList() { "Large pane", 5f, 5f, 10f, "Windows", 1 },
                new ArrayList() { "Med pane", 4f, 5f, 10f, "Windows", 2 },
                new ArrayList() { "Small pane", 3f, 5f, 10f, "Windows", 3 },

                new ArrayList() { "Panel", 4f, 5f, 10f, "Radiators", 1 },
                new ArrayList() { "Column", 3f, 5f, 10f, "Radiators", 2 },

                new ArrayList() { "100 Girth", 15f, 5f, 10f, "Isolated Surfaces", 1 },
                new ArrayList() { "150 Girth", 12f, 5f, 10f, "Isolated Surfaces", 2 },
                new ArrayList() { "300 Girth", 10f, 5f, 10f, "Isolated Surfaces", 3 }
            };

            paintData.ForEach(delegate(ArrayList x)
            {
                Console.Write("ADD");
                db.Paints.Add(new Paint
                {
                    name = Convert.ToString(x[0]),
                    prodRateOne = float.Parse(Convert.ToString(x[1])),
                    prodRateTwo = float.Parse(Convert.ToString(x[2])),
                    unitRate = float.Parse(Convert.ToString(x[3])),
                    surfaceType = Convert.ToString(x[4]),
                    order = int.Parse(Convert.ToString(x[5])),
                });
            });

            db.SaveChanges();

            db.DefaultRooms.Add(
                new DefaultRoom
                {
                    roomLength = 5f,
                    roomWidth = 5f,
                    roomHeight = 2.5f,
                    doorWidth = 0.5f,
                    doorHeight = 1.5f,
                    windowWidth = 1.5f,
                    windowHeight = 1f,
                    radiatorWidth = 1f,
                    radiatorHeight = 0.5f
                }
            );

            db.SaveChanges();
         
       
        }
        
    }
}