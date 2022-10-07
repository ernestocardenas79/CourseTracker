using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTracker.Core.Base;

public abstract class ICoursePristineBuilder
{
    private readonly IRawCourse RawCourse;
    private readonly ICourseBuilder CourseBuilder;
    public ICoursePristineBuilder(IRawCourse rawCourse, ICourseBuilder courseBuilder)
    {
        RawCourse = rawCourse;
        CourseBuilder = courseBuilder;
    }

    internal ICoursePristine Build()
    {
        var coursePristine = CourseBuilder.Build(RawCourse);
        PresistCourse(coursePristine);

        return coursePristine;
    }
    public abstract void PresistCourse(ICoursePristine coursePristine);
}