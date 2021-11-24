using Microsoft.AspNetCore.Mvc;
using Catalog.Repository;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Controllers
{
   // GET /items [Route("items")] /[Route("[controller]")]
   [ApiController]
   [Route("[controller]")]
   public class ItemsController : ControllerBase
   {
       private readonly InMemoItemsRepository repository; 

       public ItemsController()
       {
          repository = new InMemoItemsRepository();
       }

      // GET /items 
      [HttpGet]
       public IEnumerable<Item> GetItems() 
       {
          var items = repository.GetItems();
          return  items; 
       }

   } 
}