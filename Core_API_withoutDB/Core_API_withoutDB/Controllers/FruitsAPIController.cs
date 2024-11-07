using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API_withoutDB.Controllers
{
	//This is for url with controller
	[Route("api/[controller]")]

	// This shows that that the below controller is api controller and it take care of some methods of api
	// like get ,put etc and many more things..
	[ApiController]

	// This is api controller whose base class is controllerbase , and this base class controllerbase,
	// handles the http request and and http response
	public class FruitsAPIController : ControllerBase
	{
		// Here we are not using database for creating web api , this is first simple web api we are creating,
		// and using hard coded data that is list of string , and this list of string we are fetching through api,
		//by creating api 

		// THis is list of string which we are going to use with our api
		public List<string> Fruits = new List<string>()
		{
			"Mango",
			"Apple",
			"Banana",
			"Strawberry"
		};

		// Creating get API through which we can access all data through the below API
		// This attribute we ust mention before the creating api 
		[HttpGet]
		public List<string> GetFruits()
		{
			return Fruits;
		}
		// Above is the web api for getting a data


		// Now we are creating one more api through which we can access the data with particular id
		// FOr that we have to pass variable inside the get attribute i.e
		[HttpGet("{id}")]
	    public string GetFruitByIndex(int id)
	    {
			return Fruits.ElementAt(id);
      	}
		// Above is api for accessing the particular data by passing the id with api url 
	}
}
