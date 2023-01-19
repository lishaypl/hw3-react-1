using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace my_kitchen2.Controllers
{
    public class IngredientController : ApiController
    {
        myKitchen3Entities db = new myKitchen3Entities();
        // GET: api/Ingredient
        public IEnumerable<ingredient> Get()
        {
            return db.ingredients.ToList();
        }

        // GET: api/Ingredient/5
        public ingredient Get(int id)
        {
            return db.ingredients.Where(x => x.IngredientId == id).FirstOrDefault();
        }

        // POST: api/Ingredient
        public void Post([FromBody] ingredient value)
        {
            db.ingredients.Add(value);
            db.SaveChanges();
        }

        // PUT: api/Ingredient/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Ingredient/5
        public void Delete(int id)
        {
            ingredient r = db.ingredients.Where(x => x.IngredientId == id).First();
            db.ingredients.Remove(r);
            db.SaveChanges();
        }
    }
}
