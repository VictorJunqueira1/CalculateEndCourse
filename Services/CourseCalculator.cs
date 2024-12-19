using CalculateEndCourse.Models;

namespace CalculateEndCourse.Services
{
    public static class CourseCalculator
    {
        public static DateTime CalculateEndDate(Course course)
        {
            // Calcula o número de aulas restantes
            int remainingClasses = course.TotalClasses - course.ClassesCompleted;

            // Converte horas semanais em minutos
            int weeklyTime = course.WeeklyHours * 60;

            // Calcula o número de aulas possíveis por semana
            int classesPerWeek = weeklyTime / course.AverageClassDuration;

            // Calcula o número de semanas necessárias para concluir
            double weeksRequired = (double)remainingClasses / classesPerWeek;

            // Calcula o número de dias necessários
            int daysRequired = (int)(weeksRequired * 7);

            // Retorna a data de término
            return DateTime.Now.AddDays(daysRequired);
        }
    }
}