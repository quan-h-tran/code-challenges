using System.Collections.Generic;

namespace RSL.CodeChallenge.Models
{
    public class LastestResultsView
    {
        public List<LatestResultsResponse> Results { get; set; }

        public LastestResultsView()
        {
            Results = new List<LatestResultsResponse>();
        }
    }
}
