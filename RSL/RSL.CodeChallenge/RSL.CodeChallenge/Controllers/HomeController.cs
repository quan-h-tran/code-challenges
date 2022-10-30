using RSL.CodeChallenge.Models;
using RSL.CodeChallenge.Services;
using System.Web.Mvc;
using static RSL.CodeChallenge.Constants;

namespace RSL.CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        private IApiService _apiService;

        public HomeController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LatestResults()
        {
            ViewBag.Title = "The Lott Lastest Result";
            var results = new LastestResultsView();

            var request = new LatestResultsRequest
            {
                CompanyId = LotteriesProduct.Powerball,
                MaxDarwCountPerProduct = 3
            };

            var latestResults = _apiService.Post<LatestResultsResponse>("https://data.api.thelott.com/sales/vmax/web", "data/lotto/latestresults", request);
            if (latestResults != null)
            {
                results.Results.Add(latestResults);
            }

            return View("LatestResults", results);
        }
    }
}
