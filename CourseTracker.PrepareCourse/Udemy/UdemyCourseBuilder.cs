using CourseTracker.Core.Base;
using CourseTracker.PrepareCourse.Configuration;

namespace CourseTracker.PrepareCourse.Udemy;

public class UdemyCourseBuilder : IPlartformCourseBuilder
{
    public string platformName { get;} = PrepareCourseConfiguration.Udemy;

    public ICoursePristine Build(IEnumerable<string> lines)
    {
        var udemyRawLinesCourse = transforLinesIntoRawLinesCourse(lines);
        return transRawLnesIntoPristineCourse(udemyRawLinesCourse);
    }

    private ICoursePristine transRawLnesIntoPristineCourse(List<UdemyRawLineCourse> udemyRawLinesCourse)
    {
        throw new NotImplementedException();
    }

    private List<UdemyRawLineCourse> transforLinesIntoRawLinesCourse(IEnumerable<string> lines)
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