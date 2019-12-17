using System;
using Microsoft.AspNetCore.Mvc;

namespace KatasApi.Controllers
{

  [ApiController]
  [Route("api/explosion")]

  public class ExplosionController : ControllerBase
  {

    public static string Explode(string s)
    {
      string output = "";
      // Insert your solution here
      for (var i = 0; i < s.Length; i++)
      {
        output = output + new string(Convert.ToChar(s.Substring(i, 1)), int.Parse(s.Substring(i, 1)));
      }
      return output;
    }

    [HttpGet("{digits}")]
    public ActionResult Explosion(string digits)
    {
      return Ok(new { digitsexplosion = Explode(digits) });
    }
  }
}