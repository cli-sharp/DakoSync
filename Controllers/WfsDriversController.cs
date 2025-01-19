namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class WfsDriversController : Controller
{
    [HttpGet("accounts/{accountuid}/wfsdrivers")]
    public ActionResult<IEnumerable<WfsDriver>> GetWfsDrivers(string accountuid)
    {
        return null;
    }
}
