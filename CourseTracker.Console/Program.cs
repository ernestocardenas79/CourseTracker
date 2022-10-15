using CourseTracker.PrepareCourse;
using CourseTracker.PrepareCourse.Configuration;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();

string filesPath = config["RawCoursePath"].ToString();

PrepareCourseConfiguration configuration = new();

CourseBuilder courseBuilder = new(filesPath, configuration);
courseBuilder.CreateNewCourses();
