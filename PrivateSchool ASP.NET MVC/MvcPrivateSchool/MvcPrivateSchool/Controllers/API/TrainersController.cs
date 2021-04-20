using MvcPrivateSchool.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcPrivateSchool.Controllers.API
{
    public class TrainersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        public IHttpActionResult GetTrainers()
        {
            var trainers = db.Trainers.ToList();
            return Ok(trainers);
        }

        [HttpGet]
        public IHttpActionResult GetTrainer(int id)
        {
            var trainer = db.Trainers.SingleOrDefault(t => t.ID == id);
            if(trainer == null)
            {
                return NotFound();
            }
            return Ok(trainer);
        }

        [HttpPost]
        public IHttpActionResult Create(Trainer trainer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Trainers.Add(trainer);
            db.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + trainer.ID), trainer);
        }

        [HttpPut]
        public IHttpActionResult Edit(Trainer trainer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            bool result = db.Trainers.Any(t => t.ID == trainer.ID);

            if (!result)
            {
                return NotFound();
            }

            db.Entry(trainer).State = EntityState.Modified;
            db.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + trainer.ID), trainer);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var trainer = db.Trainers.SingleOrDefault(t => t.ID == id);

            if (trainer == null)
            {
                return NotFound();
            }
            db.Trainers.Remove(trainer);
            db.SaveChanges();
            return Ok(trainer);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
