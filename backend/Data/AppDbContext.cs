using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users=> Set<User>();
        public DbSet<Tema> Temas => Set<Tema>();
        public DbSet<Question> Questions => Set<Question>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tema>().HasData(
                new 
                {
                    Id = 1,
                    Title = "Adição"
                },
                new 
                {
                    Id = 2,
                    Title = "Subtração"
                }
            );

            modelBuilder.Entity<User>().HasData(
                new 
                {
                    Id = 1,
                    UserName = "guto_admin",
                    EmailAddress = "guto.admin@email.com",
                    Password = "guto12345",
                    Role ="Administrator"
                },

                new 
                {
                    Id = 2,
                    UserName = "tah_standard",
                    EmailAddress = "tah@email.com",
                    Password = "tah12345",
                    Role ="Standard"
                }
            );

            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    Title ="Quanto é 5 + 4 = ? ",
                    AnswerOne = "7",
                    AnswerTwo = "8",
                    AnswerThree = "9",
                    AnswerFour = "10",
                    AnswerCorrect = "9",
                    TemaId = 1
                },
                new Question
                {
                    Id = 2,
                    Title ="Quanto é 10 + 4 = ? ",
                    AnswerOne = "7",
                    AnswerTwo = "11",
                    AnswerThree = "15",
                    AnswerFour = "14",
                    AnswerCorrect = "14",
                    TemaId = 1
                },
                new Question
                {
                    Id = 3,
                    Title ="Quanto é 3 + 3 = ? ",
                    AnswerOne = "6",
                    AnswerTwo = "8",
                    AnswerThree = "4",
                    AnswerFour = "10",
                    AnswerCorrect = "6",
                    TemaId = 1
                },
                new Question
                {
                    Id = 4,
                    Title ="Quanto é 2 + 9 = ? ",
                    AnswerOne = "10",
                    AnswerTwo = "11",
                    AnswerThree = "29",
                    AnswerFour = "18",
                    AnswerCorrect = "11",
                    TemaId = 1
                },
                new Question
                {
                    Id = 5,
                    Title ="Quanto é 1 + 1 = ? ",
                    AnswerOne = "3",
                    AnswerTwo = "4",
                    AnswerThree = "2",
                    AnswerFour = "11",
                    AnswerCorrect = "2",
                    TemaId = 1
                },
                new Question
                {
                    Id = 6,
                    Title ="Quanto é 5 - 4 = ? ",
                    AnswerOne = "7",
                    AnswerTwo = "1",
                    AnswerThree = "9",
                    AnswerFour = "6",
                    AnswerCorrect = "1",
                    TemaId = 4
                },
                new Question
                {
                    Id = 7,
                    Title ="Quanto é 7 - 5 = ? ",
                    AnswerOne = "12",
                    AnswerTwo = "3",
                    AnswerThree = "2",
                    AnswerFour = "1",
                    AnswerCorrect = "2",
                    TemaId = 4
                },
                new Question
                {
                    Id = 8,
                    Title ="Quanto é 10 - 10 = ? ",
                    AnswerOne = "0",
                    AnswerTwo = "3",
                    AnswerThree = "5",
                    AnswerFour = "8",
                    AnswerCorrect = "0",
                    TemaId = 4
                },
                new Question
                {
                    Id = 9,
                    Title ="Quanto é 8 - 4 = ? ",
                    AnswerOne = "2",
                    AnswerTwo = "6",
                    AnswerThree = "4",
                    AnswerFour = "12",
                    AnswerCorrect = "4",
                    TemaId = 4
                },
                new Question
                {
                    Id = 10,
                    Title ="Quanto é 15 - 7 = ? ",
                    AnswerOne = "7",
                    AnswerTwo = "8",
                    AnswerThree = "9",
                    AnswerFour = "10",
                    AnswerCorrect = "8",
                    TemaId = 4
                }

            );
        }

    }
}