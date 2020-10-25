using System.Web.Mvc;
using Microsoft.ApplicationInsights;

namespace AdventureWorks.Web.Controllers
{
    public class HomeController : Controller
    {
	    public ActionResult Index()
	    {
		    var ai = new TelemetryClient();
		    ai.TrackTrace("Index action called");

		    return View();
	    }
    }
}