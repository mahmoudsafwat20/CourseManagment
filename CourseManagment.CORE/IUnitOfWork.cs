using CourseManagment.CORE.IRepositories;
using CourseManagment.CORE.Models;

public interface IUnitOfWork : IDisposable
{
    IRepository<Badge> Badges { get; }
    IRepository<Certificate> Certificates { get; }
    IRepository<Company> Companies { get; }
    IRepository<Course> Courses { get; }
    IRepository<Employee> Employees { get; }
    IRepository<EmployeeBadge> EmployeeBadges { get; }   // ✅ use EmployeeBadges (singular Employee, plural Badges)
    IRepository<Enrollment> Enrollments { get; }
    IRepository<Lesson> Lessons { get; }
    IRepository<Notification> Notifications { get; }
    IRepository<PointTransaction> PointTransactions { get; }
    IRepository<Question> Questions { get; }
    IRepository<Quiz> Quizzes { get; }
    IRepository<QuizAttempt> QuizAttempts { get; }
    IRepository<Subscription> Subscriptions { get; }

    int Complete();
    Task<int> CompleteAsync();
}
