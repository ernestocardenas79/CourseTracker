namespace CourseTracker.Core.Base;
public interface ILesson
{
    public string Id {get;set;}
    public string Name { get; set; }
    public int Duration {get;set;}
    public bool Taked {get;set;}
}
