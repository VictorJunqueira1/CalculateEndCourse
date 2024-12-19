namespace CalculateEndCourse.Models
{
    public class Course
    {
        public string Name { get; set; }
        public int TotalClasses { get; set; }
        public int ClassesCompleted { get; set; }
        public int DaysPerWeek { get; set; }
        public int WeeklyHours { get; set; }
        public int AverageClassDuration { get; set; }
    }
}