namespace CourseTracker.Core.Base;
public interface ILesson
{
    public string Id { get; init; }
    public string Name { get; set; }
    public string Duration { get; set; }
    public bool Taked { get; set; }
}
