namespace DakoSync.Controllers;

using DakoSync.Models;
using Microsoft.AspNetCore.Mvc;

public class AccountsController : Controller
{
    [HttpGet("accounts")]
    public ActionResult<IEnumerable<string>> ReadAccounts()
    {
        return Ok();
    }

    [HttpPut("accounts")]
    public ActionResult<Account> CreateOrUpdateAccount([FromBody] Account account)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}")]
     public ActionResult<Account> ReadAccount(string accountUid)
    {
        return Ok();
    }

    [HttpDelete("accounts/{accountUid}")]
     public ActionResult DeleteAccount(string accountUid)
    {
        return NoContent();
    }
}