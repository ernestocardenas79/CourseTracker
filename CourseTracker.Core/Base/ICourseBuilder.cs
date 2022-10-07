namespace CourseTracker.Core.Base;

public interface ICourseBuilder
{
    ICoursePristine Build(IRawCourse rawCourse);
}
