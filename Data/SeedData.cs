using Microsoft.EntityFrameworkCore;
using DotNetCorePortfolio.Models;
using DotNetCorePortfolio.Data;

namespace DotNetCorePortfolio.Data
{
    public class SeedData
    {
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

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (!context.Skill.Any())
                    context.Skill.AddRange(AddSkill());

                context.SaveChanges();
            }

        }
    }
}
