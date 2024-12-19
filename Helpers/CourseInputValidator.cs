namespace CalculateEndCourse.Helpers
{
    public static class CourseInputValidator
    {
        public static string GetValidCourseName()
        {
            return InputHelper.GetValidString("Qual o nome do seu curso? ");
        }

        public static int GetValidTotalClasses()
        {
            return InputHelper.GetValidNumber("Número de aulas totais do curso: ", 1);
        }

        public static int GetValidClassesCompleted(int totalClasses)
        {
            return InputHelper.GetValidNumber("Digite o número de aulas que você já fez: ", 0, totalClasses);
        }

        public static int GetValidDaysPerWeek()
        {
            return InputHelper.GetValidNumber("Quantas vezes você faz esse curso por semana? ", 1, 7);
        }

        public static int GetValidWeeklyHours()
        {
            return InputHelper.GetValidNumber("Quantas horas semanais você dedica ao curso? ", 1, 168);
        }

        public static int GetValidAverageClassDuration()
        {
            return InputHelper.GetValidNumber("Qual é a média de tempo que dura cada aula (em minutos)? ", 1);
        }
    }
}