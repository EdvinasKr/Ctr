using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Eshop.Models;

namespace EshopMain.Controllers.Api
{
    public class PrekesApiController : ApiController
    {
        private EshopDb db = new EshopDb();

        // GET: api/PrekesApi
        public IQueryable<Prekes> GetPrekes()
        {
            return db.Prekes;
        }

        // GET: api/PrekesApi/5
        [ResponseType(typeof(Prekes))]
        public IHttpActionResult GetPrekes(Guid id)
        {
            Prekes prekes = db.Prekes.Find(id);
            if (prekes == null)
            {
                return NotFound();
            }

            return Ok(prekes);
        }

        // PUT: api/PrekesApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPrekes(Guid id, Prekes prekes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prekes.PrekesId)
            {
                return BadRequest();
            }

            db.Entry(prekes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrekesExists(id))
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

        // POST: api/PrekesApi
        [ResponseType(typeof(Prekes))]
        public IHttpActionResult PostPrekes(Prekes prekes)
        {
            prekes.PrekesId = Guid.NewGuid();
            prekes.GaliojimoPabaiga = DateTime.Now.AddDays(2);
            prekes.KiekPerku = 1;


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Prekes.Add(prekes);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PrekesExists(prekes.PrekesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            var a = CreatedAtRoute("DefaultApi", new { id = prekes.PrekesId }, prekes);
            return a;
        }

        // DELETE: api/PrekesApi/5
        [ResponseType(typeof(Prekes))]
        public IHttpActionResult DeletePrekes(Guid id)
        {
            Prekes prekes = db.Prekes.Find(id);
            if (prekes == null)
            {
                return NotFound();
            }

            db.Prekes.Remove(prekes);
            db.SaveChanges();

            return Ok(prekes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PrekesExists(Guid id)
        {
            return db.Prekes.Count(e => e.PrekesId == id) > 0;
        }
    }
}