using System.Collections.Generic;

namespace RSL.CodeChallenge.Models
{
    public class LastestResultsView
    {
        public List<DrawResult> Results { get; set; }

        public LastestResultsView()
        {
            Results = new List<DrawResult>();
        }
    }
}
