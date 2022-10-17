using CourseTracker.Core.Base;
using CourseTracker.PrepareCourse.Configuration;
using CourseTracker.PrepareCourse.Scanner;
using System.Text.Json;

namespace CourseTracker.PrepareCourse;
public class CourseBuilder : CoursePristineBuilderBase
{
    private readonly CoursePlatformScanner coursePlatformScanner;
    private readonly PrepareCourseConfiguration configuration;

    public CourseBuilder(PrepareCourseConfiguration configuration)
                                : base(configuration.filesPath)
    {
        this.configuration = configuration;
        coursePlatformScanner = new(configuration.filesPath, configuration);
    }

    public void CreateNewCourses()
    {
        var files = coursePlatformScanner.Start();

        foreach (IPlartformCourseBuilder platformBuilder in configuration.platforms)
        {
            var platformFiles = files.Where(f => f.Key == platformBuilder.platformName)
                                     .Select(f => f.Value)
                                     .First();

            PlatformHandler(platformFiles, platformBuilder);
        }
    }

    protected override string[] linesFromFile(string file) => File.ReadAllLines(file);

    protected override string nameFile(string file) => Path.GetFileName(file).Split('.')[0];

    protected override void PresistCourse(ICoursePristine pristineCourse)
    {
        string jsonCourse = JsonSerializer.Serialize(pristineCourse);

        Directory.CreateDirectory(configuration.pristinePath);
        File.WriteAllText($"{configuration.pristinePath}{Path.DirectorySeparatorChar}{pristineCourse.Name}.json", jsonCourse, System.Text.Encoding.UTF8);
    }
}
