using CourseTracker.Core.Base;
using CourseTracker.PrepareCourse.Udemy;

namespace CourseTracker.PrepareCourse.Configuration;
public class PrepareCourseConfiguration
{
    internal readonly static string Udemy = "UDM";
    internal readonly static string CloudGuru = "CGR";
    public string filesPath { get; init; }
    public string processedPath { get; init; }
    public string pristinePath { get; init; }

    internal List<IPlartformCourseBuilder> platforms { get; init; }

    public PrepareCourseConfiguration(string filesPath, string processedPath, string pristinePath)
    {
        this.filesPath = filesPath;
        this.processedPath = processedPath;
        this.pristinePath = pristinePath;

        platforms = new() { { UdemyFactory.getBuilder() } };
    }
}
