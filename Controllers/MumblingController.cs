using System;
using Microsoft.AspNetCore.Mvc;

namespace KatasApi.Controllers
{
  [ApiController]
  [Route("api/mumbling")]
  public class MumblingController : ControllerBase
  {

    public static String Accum(string s)
    {

      string output = "";
      // your code
      for (var i = 0; i < s.Length; i++)
      {
        output = output + s.Substring(i, 1).ToUpper();
        for (var j = 0; j < i; j++)
        {
          output = output + s.Substring(i, 1).ToLower();
        }
        if (i < s.Length - 1)
        {
          output = output + "-";
        }
      }
      return output;
    }

    [HttpGet("{digits}")]
    public ActionResult Mumbling(string digits)
    {
      return Ok(new { mumbling = Accum(digits) });
    }
  }
}