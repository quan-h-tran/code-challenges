using RSL.CodeChallenge.Models;
using RSL.CodeChallenge.Services;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using static RSL.CodeChallenge.Constants;

namespace RSL.CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        private IApiService _apiService;
        private string _theLottBaseApiEndpoint;
        private string _lottoResultsCompanyId;
        private List<string> _lotteriesProducts;

        public HomeController(IApiService apiService)
        {
            _apiService = apiService;
            _theLottBaseApiEndpoint = ConfigurationManager.AppSettings["TheLottBaseApiEndpoint"] ?? string.Empty;
            _lottoResultsCompanyId = ConfigurationManager.AppSettings["TheLottLastestResultsCompanyId"] ?? string.Empty;
            _lotteriesProducts = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["TheLottLotteriesProducts"]) ? ConfigurationManager.AppSettings["TheLottLotteriesProducts"].Split('|').ToList() : new List<string>();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LatestResults()
        {
            ViewBag.Title = "The Lott Lastest Result";
            var results = new LastestResultsView();

            var request = new LottoResultsRequest
            {
                CompanyId = _lottoResultsCompanyId,
                MaxDarwCountPerProduct = MaxDarwCountPerProduct,
                OptionalProductFilter = _lotteriesProducts
            };

            var latestResults = _apiService.Post<LatestResultsResponse>(_theLottBaseApiEndpoint, "latestresults", request);
            if (latestResults != null && latestResults.DrawResults.Any())
            {
                results.Results.AddRange(latestResults.DrawResults);
            }

            return View("LatestResults", results);
        }
    }
}
