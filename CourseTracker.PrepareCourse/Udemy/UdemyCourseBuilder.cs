using CourseTracker.Core.Base;
using CourseTracker.PrepareCourse.Configuration;

namespace CourseTracker.PrepareCourse.Udemy;

public class UdemyCourseBuilder : IPlartformCourseBuilder
{
    public string platformName { get; } = PrepareCourseConfiguration.Udemy;

    public ICoursePristine Build(IEnumerable<string> lines)
    {
        var udemyRawLinesCourse = transformLinesIntoRawLinesCourse(lines);
        return transRawLnesIntoPristineCourse(udemyRawLinesCourse);
    }

    private ICoursePristine transRawLnesIntoPristineCourse(IEnumerable<UdemyRawLineCourse> udemyRawLinesCourse)
    {
        var course = new CoursePristine();

        course.Platform = platformName;

        var structuredCourse = udemyRawLinesCourse.GroupBy(u => u.Module)
                        .Select(g =>
                                new Module
                                {
                                    Name = g.Key,
                                    Lessons = g.Select(g => new Lesson()
                                    {
                                        Name = g.lesson,
                                        Duration = g.lessonDuration
                                    })
                                });

        course.Modules = structuredCourse;

        return course;
    }

    private List<UdemyRawLineCourse> transformLinesIntoRawLinesCourse(IEnumerable<string> lines)
    {
        List<UdemyRawLineCourse> rawCourse = new();
        foreach (var line in lines)
        {
            var courseinfo = line.Split(',');

            rawCourse.Add(new()
            {
                Module = courseinfo[0],
                ModuleDuration = courseinfo[1],
                lesson = courseinfo[2],
                lessonDuration = courseinfo[3],
            });
        }

        return rawCourse;
    }
}