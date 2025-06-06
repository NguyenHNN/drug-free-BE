using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;

namespace Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ConsultationNote> ConsultationNotes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<QuizResult> QuizResults { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public DbSet<ConsultationAppointment> ConsultationAppointments { get; set; }
        public DbSet<CommunityEvent> CommunityEvents { get; set; }
        public DbSet<EventParticipant> EventParticipants { get; set; }
        public DbSet<UserEventFeedback> UserEventFeedbacks { get; set; }
        public DbSet<SurveyAnswer> SurveyAnswers { get; set; }
        public DbSet<SurveyResponse> SurveyResponses { get; set; }
        public DbSet<ConsultantAvailableSlot> ConsultantAvailableSlots { get; set; }
        public DbSet<UserSurveyAnswer> UserSurveyAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Apply configurations
            modelBuilder.ApplyConfiguration(new UserAccountConfiguration());
            modelBuilder.ApplyConfiguration(new SlotConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new ConsultationNoteConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new QuizResultConfiguration());
            modelBuilder.ApplyConfiguration(new UserAnswerConfiguration());
            modelBuilder.ApplyConfiguration(new CourseEnrollmentConfiguration());
            modelBuilder.ApplyConfiguration(new SurveyConfiguration());
            modelBuilder.ApplyConfiguration(new SurveyQuestionConfiguration());
            modelBuilder.ApplyConfiguration(new ConsultationAppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new CommunityEventConfiguration());
            modelBuilder.ApplyConfiguration(new EventParticipantConfiguration());
            modelBuilder.ApplyConfiguration(new UserEventFeedbackConfiguration());
            modelBuilder.ApplyConfiguration(new SurveyAnswerConfiguration());
            modelBuilder.ApplyConfiguration(new SurveyResponseConfiguration());
            modelBuilder.ApplyConfiguration(new ConsultantAvailableSlotConfiguration());
            modelBuilder.ApplyConfiguration(new UserSurveyAnswerConfiguration());
        }
    }
} 