namespace Nwu.Aiitsa.Webhost;

using Microsoft.AspNetCore.Mvc;

public sealed class HomeController : ApiController
{
	[HttpGet]
	public IActionResult Get()
	{
		return Ok("Hello Wortel!");
	}
}
