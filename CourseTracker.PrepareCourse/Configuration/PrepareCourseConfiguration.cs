using CourseTracker.Core.Base;
using CourseTracker.PrepareCourse.Udemy;

namespace CourseTracker.PrepareCourse.Configuration;
public class PrepareCourseConfiguration
{
    internal readonly static string Udemy = "UDM";
    internal readonly static string CloudGuru = "CGR";

    internal List<IPlartformCourseBuilder> platforms { get; init; }

    public PrepareCourseConfiguration()
    {
        platforms = new() {{UdemyFactory.getBuilder()}};
    }
}
