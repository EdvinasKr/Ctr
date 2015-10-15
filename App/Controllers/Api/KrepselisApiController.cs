using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Eshop.Models;

namespace Eshop.Controllers.Api
{
    public class KrepselisApiController : ApiController
    {
        private EshopDb db = new EshopDb();

        // GET: api/KrepselisApi
        public IQueryable<Krepselis> GetKrepselisModels()
        {
            return db.Krepselis;
        }

        // GET: api/KrepselisApi/5
        [ResponseType(typeof(Krepselis))]
        public IHttpActionResult GetKrepselisModel(Guid id)
        {
            Krepselis krepselisModel = db.Krepselis.Find(id);
            if (krepselisModel == null)
            {
                return NotFound();
            }

            return Ok(krepselisModel);
        }

        // PUT: api/KrepselisApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKrepselisModel(Guid id, Krepselis krepselisModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != krepselisModel.KrepselisId)
            {
                return BadRequest();
            }

            db.Entry(krepselisModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KrepselisModelExists(id))
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

        // POST: api/KrepselisApi
        [ResponseType(typeof(Krepselis))]
        public IHttpActionResult PostKrepselisModel(Krepselis krepselisModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Krepselis.Add(krepselisModel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (KrepselisModelExists(krepselisModel.KrepselisId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = krepselisModel.KrepselisId }, krepselisModel);
        }

        // DELETE: api/KrepselisApi/5
        [ResponseType(typeof(Krepselis))]
        public IHttpActionResult DeleteKrepselisModel(Guid id)
        {
            Krepselis krepselisModel = db.Krepselis.Find(id);
            if (krepselisModel == null)
            {
                return NotFound();
            }

            db.Krepselis.Remove(krepselisModel);
            db.SaveChanges();

            return Ok(krepselisModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KrepselisModelExists(Guid id)
        {
            return db.Krepselis.Count(e => e.KrepselisId == id) > 0;
        }
    }
}