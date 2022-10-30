using System.Collections.Generic;
using static RSL.CodeChallenge.Constants;

namespace RSL.CodeChallenge.Models
{
    public class LatestResultsRequest
    {
        public LotteriesProduct CompanyId { get; set; }

        public int MaxDarwCountPerProduct { get; set; }

        public List<string> OptionalProductFilter { get; set; }
    }
}
