namespace DotNetCorePortfolio.Models
{
    public class ListModel
    {
        public IList<Project> ProjectModel { get; set; }
        public IList<Experience> ExperienceModel { get; set; }
        public IList<Skill> SkillModel { get; set; }
    }
}
