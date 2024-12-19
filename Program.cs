using CalculateEndCourse.Services;

namespace CalculateEndCourse
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Planejador de Curso ===");

            // Obter os dados do curso do usuário
            var course = CourseService.CreateCourse();

            // Calcular a data de término
            var endDate = CourseService.CalculateEndDate(course);

            // Exibir o resultado
            Console.WriteLine($"\nVocê terminará seu curso de {course.Name} em: {endDate:dd/MM/yyyy}");
        }
    }
}