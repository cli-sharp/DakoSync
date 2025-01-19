namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class WfsObjectsController : Controller
{
    [HttpGet("accounts/{accountuid}/wfsobjects")]
    public ActionResult<IEnumerable<WfsObject>> GetWfsObjects(string accountuid)
    {
        return null;
    }
}
