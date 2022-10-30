using System.Collections.Generic;

namespace RSL.CodeChallenge.Models
{
    public class LottoResultsRequest
    {
        public string CompanyId { get; set; }

        public int MaxDarwCountPerProduct { get; set; }

        public List<string> OptionalProductFilter { get; set; }
    }
}
