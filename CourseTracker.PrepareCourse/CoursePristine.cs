using CourseTracker.Core.Base;

namespace CourseTracker.PrepareCourse
{
    internal class CoursePristine : ICoursePristine
    {
        public string Name { get; set; }
        public string Instructor { get; set; }
        public IEnumerable<IModule> Modules { get; set; }
        public string Platform { get; set; }

        internal CoursePristine()
        {
            Instructor = "Undefined";
            Name = "Undefined";
        }
    }
}
