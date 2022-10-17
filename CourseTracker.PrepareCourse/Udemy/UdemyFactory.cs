using CourseTracker.Core.Base;

namespace CourseTracker.PrepareCourse.Udemy;
internal class UdemyFactory
{
    internal static IPlartformCourseBuilder getBuilder()
    {
        UdemyCourseBuilder udemyBuilder = new();

        return udemyBuilder;
    }
}
