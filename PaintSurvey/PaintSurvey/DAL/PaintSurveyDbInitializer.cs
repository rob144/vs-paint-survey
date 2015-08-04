using System;
using System.Collections.Generic;
using System.Collections;
using PaintSurvey.Models;

namespace PaintSurvey.DAL
{
    public class PaintSurveyDbInitializer 
        : System.Data.Entity.DropCreateDatabaseAlways<PaintSurveyContext>
    {
        protected override void Seed(PaintSurveyContext context)
        {
            
        }
    }
}