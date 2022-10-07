namespace CourseTracker.Core.Base;
public interface IRawCourse
{
    internal string Module { get; set; }
    internal string Duration {get; set;}
    internal string lesson {get;set;}
    internal string lessonDuration {get; set;}
}
