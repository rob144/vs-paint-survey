using System.Collections.Generic;
using PaintSurvey.Models;

namespace PaintSurvey.DAL
{
    public class PaintSurveyDbInitializer 
        : System.Data.Entity.DropCreateDatabaseIfModelChanges<PaintSurveyContext>
    {
        protected override void Seed(PaintSurveyContext context)
        {
            var projects = new List<Project>{
                new Project{ title="Carson", username="Alexander" },
            };
            projects.ForEach(s => context.Projects.Add(s));
            context.SaveChanges();

            var paints = new List<Paint>{
                new Paint { name="1 Vinyl Matt"     , prodRateOne=20, prodRateTwo=5, unitRate=10, surfaceType="Ceilings", order=1},
                new Paint { name="2 Vinyl Matt"     , prodRateOne=10, prodRateTwo=5, unitRate=10, surfaceType="Ceilings", order=2},
                new Paint { name="2 Eggshell"       , prodRateOne=9, prodRateTwo=5, unitRate=10, surfaceType="Ceilings", order=3},
                new Paint { name="Wallpaper"        , prodRateOne=4.5f, prodRateTwo=5, unitRate=10, surfaceType="Walls", order=1},
                new Paint { name="2 Vinyl Matt"     , prodRateOne=10, prodRateTwo=5, unitRate=10, surfaceType="Walls", order=2},
                new Paint { name="2 Eggshell"       , prodRateOne=9, prodRateTwo=5, unitRate=10, surfaceType="Walls", order=3},
                new Paint { name="General surface"  , prodRateOne=4, prodRateTwo=5, unitRate=10, surfaceType="Doors", order=1},
                new Paint { name="Glazed med pane"  , prodRateOne=3.5f, prodRateTwo=5, unitRate=10, surfaceType="Doors", order=2},
                new Paint { name="Glazed small pane", prodRateOne=2.5f, prodRateTwo=5, unitRate=10, surfaceType="Doors", order=3},
                new Paint { name="Large pane"       , prodRateOne=5, prodRateTwo=5, unitRate=10, surfaceType="Windows", order=1},
                new Paint { name="Med pane"         , prodRateOne=4, prodRateTwo=5, unitRate=10, surfaceType="Windows", order=1},
                new Paint { name="Small pane"       , prodRateOne=3, prodRateTwo=5, unitRate=10, surfaceType="Windows", order=2},
                new Paint { name="Panel"            , prodRateOne=4, prodRateTwo=5, unitRate=10, surfaceType="Radiators", order=1},
                new Paint { name="Column"           , prodRateOne=3, prodRateTwo=5, unitRate=10, surfaceType="Radiators", order=2},
                new Paint { name="100 Girth"        , prodRateOne=15, prodRateTwo=5, unitRate=10, surfaceType="Isolated Surfaces", order=1},
                new Paint { name="150 Girth"        , prodRateOne=12, prodRateTwo=5, unitRate=10, surfaceType="Isolated Surfaces", order=2},
                new Paint { name="300 Girth"        , prodRateOne=10, prodRateTwo=5, unitRate=10, surfaceType="Isolated Surfaces", order=3}
            };

            paints.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>{
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            };

            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}