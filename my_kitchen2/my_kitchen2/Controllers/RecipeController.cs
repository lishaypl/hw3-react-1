using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using my_kitchen2.DTO;
using System.Data.Common;
using Newtonsoft.Json;

namespace my_kitchen2.Controllers
{
    public class RecipeController : ApiController
    {

        // GET: api/Recipe
        myKitchen3Entities db = new myKitchen3Entities();

        [HttpGet]
        [Route("api/get/recipe")]
        public IHttpActionResult GetRecipes()
        {
            try
            {
                return Ok(db.recipes.ToList());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        // GET: api/Recipe/5
        public recipe Get(int id)
        {
            return db.recipes.Where(x => x.recipeId == id).FirstOrDefault();
        }

        // POST: api/Recipe
        public void Post([FromBody] recipe value)
        {
            db.recipes.Add(value);
            db.SaveChanges();

        }


        [HttpPost]
        [Route("api/post/recipe")]
        public IHttpActionResult PstR([FromBody] recipe value)
        {

            var a = new recipe
            {
                name = value.name,
                cookingMethod = value.cookingMethod,
                image = value.image,
                ingredients = value.ingredients,
                time = value.time,
 
            };

            try
            {

                db.recipes.Add(a);
                db.SaveChanges();
                return Ok(a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }



            //    /*Created(new Uri(Request.RequestUri.AbsoluteUri + value.recipeId), value)*/
            //    ;

            //}

        }
    } }
