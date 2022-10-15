using System.Collections.Generic;

namespace CourseTracker.Core.Base;

public interface IPlartformCourseBuilder
{
    ICoursePristine Build(IEnumerable<string> lines);

    string platformName { get; }
}
