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

    [HttpPost("accounts")]
    public ActionResult<Account> CreateAccount([FromBody] Account account)
    {
        return Created();
    }

    [HttpGet("accounts/{accountUid}")]
     public ActionResult<Account> ReadAccount(string accountUid)
    {
        return Ok();
    }

    [HttpPut("accounts/{accountUid}")]
    public ActionResult<Account> UpdateAccount(string accountUid, [FromBody] Account account)
    {
        return Created();
    }

    [HttpDelete("accounts/{accountUid}")]
     public ActionResult DeleteAccount(string accountUid)
    {
        return NoContent();
    }
}