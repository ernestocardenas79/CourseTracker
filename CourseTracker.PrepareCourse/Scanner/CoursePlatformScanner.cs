using CourseTracker.Core.Base;
using CourseTracker.PrepareCourse.Configuration;
using CourseTracker.PrepareCourse.Helper;
using CourseTracker.PrepareCourse.Udemy;

namespace CourseTracker.PrepareCourse.Scanner;

public class CoursePlatformScanner
{
    private readonly string filesPath;
    private PrepareCourseConfiguration configuration;

    private ScanStatus Status { get; set; }

    public CoursePlatformScanner(string filesPath, PrepareCourseConfiguration configuration) 
    {
        Status = ScanStatus.inactive;
        this.filesPath = filesPath;
        this.configuration = configuration;
    }

    public Dictionary<string, IEnumerable<string>> Start()
    {
        Status = ScanStatus.inprogres;
        Dictionary<string, IEnumerable<string>> fileRawCourses = new();

        foreach (IPlartformCourseBuilder platformBuilder in configuration.platforms)
        {
            var platformFiles = Directory
                                .GetFiles(filesPath)
                                .Where(f => Path.GetFileName(f).StartsWith(platformBuilder.platformName));

            if (platformFiles != null)
            {
                fileRawCourses.Add(PrepareCourseConfiguration.Udemy, platformFiles);
            }
        }

        Status = ScanStatus.done;
        return fileRawCourses;
    }
}
