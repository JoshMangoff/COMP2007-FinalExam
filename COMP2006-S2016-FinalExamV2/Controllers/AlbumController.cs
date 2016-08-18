using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using COMP2006_S2016_FinalExamV2.Models;

/*
 * Josh Mangoff
 * 200284512
 * August 18, 2016
 * Version 0.1
 * Controller for Albums
 */

namespace COMP2006_S2016_FinalExamV2.Controllers
{
    public class AlbumController : Controller
    {
        private MVCMusicStoreContext db = new MVCMusicStoreContext();

        // GET: /Album/
        public ActionResult Index()
        {
            var albums = db.Albums.Include(a => a.Artist).Include(a => a.Genre);
            return View(albums.ToList());
        }

    }
}
