﻿namespace CourseTracker.Core.Base;

public abstract class CoursePristineBuilderBase
{
    private readonly string filePath;

    public CoursePristineBuilderBase(string filePath)
    {
        this.filePath = filePath;
    }

    protected void PlatformHandler(IEnumerable<string> filesPath, IPlartformCourseBuilder plartformCourseBuilder)
    {
        foreach (string file in filesPath)
        {
            var lines = linesFromFile(file);
            var coursePristine = plartformCourseBuilder.Build(lines);

            coursePristine.Name = nameFile(file).Replace(coursePristine.Platform + "_", "");

            PresistCourse(coursePristine);
        }
    }

    protected abstract void PresistCourse(ICoursePristine pristineCourse);

    protected abstract string[] linesFromFile(string file);

    protected abstract string nameFile(string file);
}
