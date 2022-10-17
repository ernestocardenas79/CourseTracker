using CourseTracker.Core.Base;

namespace CourseTracker.PrepareCourse
{
    public class Module : IModule
    {
        public string Id { get; init; }
        public string Name { get; set; }
        public IEnumerable<ILesson> Lessons { get; set; }

        public Module()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
