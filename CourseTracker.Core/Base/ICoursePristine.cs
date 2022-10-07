namespace CourseTracker.Core.Base;
public interface ICoursePristine
{
    internal string Name { get; set; }
    internal string Instructor {get; set;}
    internal IList<IModules> Modules {get; set;}
}
