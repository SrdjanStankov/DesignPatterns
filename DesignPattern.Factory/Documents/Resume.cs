using DesignPatterns.Factory.Pages;

namespace DesignPatterns.Factory.Documents
{
    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
