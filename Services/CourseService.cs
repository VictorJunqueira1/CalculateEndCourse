using CalculateEndCourse.Helpers;
using CalculateEndCourse.Models;

namespace CalculateEndCourse.Services
{
    public static class CourseService
    {
        public static Course CreateCourse()
        {
            // Solicita e valida os dados do curso
            string courseName = CourseInputValidator.GetValidCourseName();
            int totalClasses = CourseInputValidator.GetValidTotalClasses();
            int classesCompleted = CourseInputValidator.GetValidClassesCompleted(totalClasses);
            int daysPerWeek = CourseInputValidator.GetValidDaysPerWeek();
            int weeklyHours = CourseInputValidator.GetValidWeeklyHours();
            int averageClassDuration = CourseInputValidator.GetValidAverageClassDuration();

            return new Course
            {
                Name = courseName,
                TotalClasses = totalClasses,
                ClassesCompleted = classesCompleted,
                DaysPerWeek = daysPerWeek,
                WeeklyHours = weeklyHours,
                AverageClassDuration = averageClassDuration
            };
        }

        public static DateTime CalculateEndDate(Course course)
        {
            // Usa o CourseCalculator para calcular a data de término
            return CourseCalculator.CalculateEndDate(course);
        }
    }
}