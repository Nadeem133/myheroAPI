using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using myheroAPI.Models;

namespace myheroAPI.Controllers
{
    public class CRUDController : ApiController
    {
        private heroAPIEntities1 db = new heroAPIEntities1();

        // GET: api/CRUD
        [Route("api/Getheroes")]
        public IQueryable<hero> Getheroes()
        {
            return db.heroes;
        }

        // GET: api/CRUD/5
        [ResponseType(typeof(hero))]
        [Route("api/Gethero")]
        public IHttpActionResult Gethero(int id)
        {
            hero hero = db.heroes.Find(id);
            if (hero == null)
            {
                return NotFound();
            }

            return Ok(hero);
        }

        // PUT: api/CRUD/5
        [ResponseType(typeof(void))]
        [Route("api/Puthero")]
        public IHttpActionResult Puthero(int id, hero hero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hero.ID)
            {
                return BadRequest();
            }

            db.Entry(hero).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!heroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CRUD
        [Route("api/Posthero")]
        [ResponseType(typeof(hero))]
        public IHttpActionResult Posthero(hero hero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.heroes.Add(hero);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (heroExists(hero.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hero.ID }, hero);
        }

        // DELETE: api/CRUD/5
        [Route("api/Deletehero")]
        [ResponseType(typeof(hero))]
        public IHttpActionResult Deletehero(int id)
        {
            hero hero = db.heroes.Find(id);
            if (hero == null)
            {
                return NotFound();
            }

            db.heroes.Remove(hero);
            db.SaveChanges();

            return Ok(hero);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        [Route("api/heroExists")]
        private bool heroExists(int id)
        {
            return db.heroes.Count(e => e.ID == id) > 0;
        }
    }
}