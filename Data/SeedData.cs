using Microsoft.EntityFrameworkCore;
using DotNetCorePortfolio.Models;
using DotNetCorePortfolio.Data;
using Bogus;

namespace DotNetCorePortfolio.Data
{
    public class SeedData
    {
        private static List<Message> FakeMessages(int count)
        {
            var messageFaker = new Faker<Message>()
                .RuleFor(m => m.Email, f => f.Person.Email)
                .RuleFor(m => m.FullName, f => f.Person.FullName)
                .RuleFor(m => m.Body, f => f.Lorem.Paragraph())
                .RuleFor(m => m.CreatedAt, f => f.Date.Past());

            return messageFaker.Generate(count);
        }

        private static Skill[] AddSkill()
        {
            return new Skill[]
            {
                new Skill
                {
                    Name = "C#/.NET",
                    Percentage = 85
                },
                new Skill
                {
                    Name = "Java",
                    Percentage = 70
                },
                new Skill
                {
                    Name = "Python",
                    Percentage = 65
                },
                new Skill
                {
                    Name = "Linux",
                    Percentage = 90
                },
                new Skill
                {
                    Name = "HTML5/CSS3",
                    Percentage = 70
                },
                new Skill 
                {
                    Name = "Azure",
                    Percentage = 65
                }
            };
        }

        private static Project[] AddProject()
        {
            return new Project[]
            {
                new Project
                {
                    Title = "The Old Market Garage",
                    Thumbnail = "img/theoldmarketgarage.jpg",
                    Description = "Your local shop for sustainable, ethical, and eco-friendly shopping."
                },
                new Project
                {
                    Title = "KO Beauty",
                    Thumbnail = "img/kobeauty.jpg",
                    Description = "Nails & Eyelashes beauty salon that is affordable to everyone in the local community."
                },
                new Project
                {
                    Title = "DivvyUp",
                    Thumbnail = "img/divvyup.jpg",
                    Description = "Hassle-free, effective online payment system for hospitality industry."
                }
            };
        }
        
        private static Experience[] AddExperience()
        {
            return new Experience[]
            {
                new Experience
                {
                    Title = "Programming Peer Tutor",
                    Location = "Invercargill, NZ",
                    Duration = "2020 - 2021",
                    Description = "Helping students with programming subjects in grasping logical concepts."
                }
            };

        }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (!context.Skill.Any())
                    context.Skill.AddRange(AddSkill());
                if (!context.Project.Any())
                    context.Project.AddRange(AddProject());
                if (!context.Experience.Any())
                    context.Experience.AddRange(AddExperience());
                if (!context.Message.Any())
                    context.Message.AddRange(FakeMessages(100));

                context.SaveChanges();
            }

        }
    }
}
