namespace CourseTracker.Core.Base;

public interface IModule
{
    public string Id { get; init; }
    public string Name { get; set; }
    public IEnumerable<ILesson> Lessons { get; set; }
}
