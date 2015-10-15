using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using System.Collections.Generic;
using Eshop.Models;

namespace Eshop.Controllers.Api
{
    public class UzsakymasApiController : ApiController
    {
        private EshopDb db = new EshopDb();

        // GET: api/UzsakymasApi
        public IQueryable<Uzsakymas> GetUzsakymas()
        {
            return db.Uzsakymas;
        }

        // GET: api/UzsakymasApi/5
        [ResponseType(typeof(Uzsakymas))]
        public IHttpActionResult GetUzsakymasModel(Guid id)
        {
            Uzsakymas uzsakymasModel = db.Uzsakymas.Find(id);
            if (uzsakymasModel == null)
            {
                return NotFound();
            }

            return Ok(uzsakymasModel);
        }

        // PUT: api/UzsakymasApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUzsakymasModel(Guid id, Uzsakymas uzsakymasModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uzsakymasModel.UzsakymoId)
            {
                return BadRequest();
            }

            db.Entry(uzsakymasModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UzsakymasModelExists(id))
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

        // POST: api/UzsakymasApi
        [ResponseType(typeof(Uzsakymas))]
        public IHttpActionResult PostUzsakymasModel(List<Prekes> prekes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var krep = new List<Krepselis>();
            foreach (var item in prekes)
            {
                krep.Add(
                    new Krepselis
                    {
                        KrepselisId = Guid.NewGuid(),
                        Kaina = item.Kaina,
                        Kiekis = item.KiekPerku,
                        Pavadinimas = item.Pavadinimas
                    });
            }

            var uzsakymasModel = new Uzsakymas
            {
                UzsakymoId = Guid.NewGuid(),
                Krepselis = krep
            };
            db.Uzsakymas.Add(uzsakymasModel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (UzsakymasModelExists(uzsakymasModel.UzsakymoId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = uzsakymasModel.UzsakymoId }, uzsakymasModel);
        }

        // DELETE: api/UzsakymasApi/5
        [ResponseType(typeof(Uzsakymas))]
        public IHttpActionResult DeleteUzsakymasModel(Guid id)
        {
            Uzsakymas uzsakymasModel = db.Uzsakymas.Find(id);
            if (uzsakymasModel == null)
            {
                return NotFound();
            }

            db.Uzsakymas.Remove(uzsakymasModel);
            db.SaveChanges();

            return Ok(uzsakymasModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UzsakymasModelExists(Guid id)
        {
            return db.Uzsakymas.Count(e => e.UzsakymoId == id) > 0;
        }
    }
}