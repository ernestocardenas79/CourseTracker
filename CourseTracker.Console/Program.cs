using CourseTracker.PrepareCourse;
using CourseTracker.PrepareCourse.Configuration;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();

string filesPath = config["RawCoursePath"].ToString();
string processedPath = config["ProcessedCoursePath"].ToString();
string pristinePath = config["PristineCoursePath"].ToString();

PrepareCourseConfiguration configuration = new(filesPath, processedPath, pristinePath);

CourseBuilder courseBuilder = new(configuration);
courseBuilder.CreateNewCourses();
