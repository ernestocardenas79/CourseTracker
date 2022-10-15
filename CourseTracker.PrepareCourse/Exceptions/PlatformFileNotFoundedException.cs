namespace CourseTracker.PrepareCourse.Exceptions;
public class PlatformFileNotFoundedException : Exception
{
    public string FileName { get; set; }

    public string Message { get; set; }
}
