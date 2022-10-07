
using CourseTracker.Core.Base;

internal class UdemycoursePristineBuilder : ICoursePristineBuilder
{
    internal UdemycoursePristineBuilder(IRawCourse rawCourse, ICourseBuilder courseBuilder)
                                :base(rawCourse, courseBuilder){}
    public override void PresistCourse(ICoursePristine coursePristine)
    {
        Console.WriteLine("UdemycoursePristineBuilder_PersistenceCourse");
    }
}
