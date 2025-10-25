using CourseManagment.CORE;
using CourseManagment.CORE.IRepositories;
using CourseManagment.CORE.Models;
using CourseManagment.EF.Repositories;

namespace CourseManagment.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IRepository<Badge> Badges { get; }
        public IRepository<Certificate> Certificates { get; }
        public IRepository<Company> Companies { get; }
        public IRepository<Course> Courses { get; }
        public IRepository<Employee> Employees { get; }
        public IRepository<EmployeeBadge> EmployeeBadges { get; }
        public IRepository<Enrollment> Enrollments { get; }
        public IRepository<Lesson> Lessons { get; }
        public IRepository<Notification> Notifications { get; }
        public IRepository<PointTransaction> PointTransactions { get; }
        public IRepository<Question> Questions { get; }
        public IRepository<Quiz> Quizzes { get; }
        public IRepository<QuizAttempt> QuizAttempts { get; }
        public IRepository<Subscription> Subscriptions { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Badges = new Repositories<Badge>(_context);
            Certificates = new Repositories<Certificate>(_context);
            Companies = new Repositories<Company>(_context);
            Courses = new Repositories<Course>(_context);
            Employees = new Repositories<Employee>(_context);
            EmployeeBadges = new Repositories<EmployeeBadge>(_context);
            Enrollments = new Repositories<Enrollment>(_context);
            Lessons = new Repositories<Lesson>(_context);
            Notifications = new Repositories<Notification>(_context);
            PointTransactions = new Repositories<PointTransaction>(_context);
            Questions = new Repositories<Question>(_context);
            Quizzes = new Repositories<Quiz>(_context);
            QuizAttempts = new Repositories<QuizAttempt>(_context);
            Subscriptions = new Repositories<Subscription>(_context);
        }

        public int Complete() => _context.SaveChanges();
        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
    }
}
