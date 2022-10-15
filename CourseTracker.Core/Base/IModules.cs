namespace CourseTracker.Core.Base;

internal interface IModules
{
    public string Name { get; set; }
    public List<ILesson> Lessons { get; set; }
}
