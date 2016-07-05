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
using VideoList.Models;

namespace VideoList.Controllers
{
    public class VideoDatasController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/VideoDatas
        public IQueryable<VideoData> GetVideoDatas()
        {
            return db.VideoDatas;
        }

        // GET: api/VideoDatas/5
        [ResponseType(typeof(VideoData))]
        public IHttpActionResult GetVideoData(int id)
        {
            VideoData videoData = db.VideoDatas.Find(id);
            if (videoData == null)
            {
                return NotFound();
            }

            return Ok(videoData);
        }

        // PUT: api/VideoDatas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVideoData(int id, VideoData videoData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != videoData.VideoID)
            {
                return BadRequest();
            }

            db.Entry(videoData).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VideoDataExists(id))
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

        // POST: api/VideoDatas
        [ResponseType(typeof(VideoData))]
        public IHttpActionResult PostVideoData(VideoData videoData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VideoDatas.Add(videoData);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = videoData.VideoID }, videoData);
        }

        // DELETE: api/VideoDatas/5
        [ResponseType(typeof(VideoData))]
        public IHttpActionResult DeleteVideoData(int id)
        {
            VideoData videoData = db.VideoDatas.Find(id);
            if (videoData == null)
            {
                return NotFound();
            }

            db.VideoDatas.Remove(videoData);
            db.SaveChanges();

            return Ok(videoData);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VideoDataExists(int id)
        {
            return db.VideoDatas.Count(e => e.VideoID == id) > 0;
        }
    }
}