using CourseTracker.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTracker.PrepareCourse.Udemy;
internal class UdemyFactory
{
    internal static IPlartformCourseBuilder getBuilder()
    {
        UdemyCourseBuilder udemyBuilder = new ();

        return udemyBuilder;
    } 
}
