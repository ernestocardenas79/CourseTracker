namespace CourseTracker.Core.Base;
public interface ICoursePristine
{
    string Platform { get; set; }
    string Name { get; set; }
    string Instructor { get; set; }
    IEnumerable<IModule> Modules { get; set; }
}
