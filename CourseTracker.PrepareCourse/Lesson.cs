using CourseTracker.Core.Base;

namespace CourseTracker.PrepareCourse
{
    public class Lesson : ILesson
    {
        public string Id { get; init; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public bool Taked { get; set; }

        public Lesson()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
