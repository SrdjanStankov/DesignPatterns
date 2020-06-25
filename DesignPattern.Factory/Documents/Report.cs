using DesignPatterns.Factory.Pages;

namespace DesignPatterns.Factory.Documents
{
    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
