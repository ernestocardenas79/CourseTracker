using CourseTracker.Core.Base;
using CourseTracker.PrepareCourse.Configuration;
using CourseTracker.PrepareCourse.Scanner;
using CourseTracker.PrepareCourse.Udemy;

namespace CourseTracker.PrepareCourse;
public class CourseBuilder : CoursePristineBuilderBase
{
    private readonly CoursePlatformScanner coursePlatformScanner;
    private readonly PrepareCourseConfiguration configuration;

    public CourseBuilder(string filePath, PrepareCourseConfiguration configuration)
                                : base(filePath) {
        this.configuration = configuration;
        coursePlatformScanner = new(filePath, configuration);
    }

    public void CreateNewCourses()
    {
        var files = coursePlatformScanner.Start();

        foreach(IPlartformCourseBuilder platformBuilder in configuration.platforms)
        {
            var platformFiles = files.Where(f => f.Key ==platformBuilder.platformName)
                                     .Select(f=> f.Value)
                                     .First();

            PlatformHandler(platformFiles, platformBuilder);
        }
    }

    protected override string[] linesFromFile(string file)=> File.ReadAllLines(file);

    protected override void PresistCourse(ICoursePristine pristineCourse)
    {

    }
}
