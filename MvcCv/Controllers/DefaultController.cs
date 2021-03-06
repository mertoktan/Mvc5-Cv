using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.Tbl_Hakkımda.ToList();
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.Tbl_Deneyımlerım.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Eğitimlerim()
        {
            var egitimler = db.Tbl_Egitimlerim.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenek = db.Tbl_Yeteneklerim.ToList();
            return PartialView(yetenek);
        }
        public PartialViewResult Hobilerim()
        {
            var hobi = db.Tbl_Hobilerim.ToList();
            return PartialView(hobi);
        }
        public PartialViewResult Sertifikalar()
        {
            var sertifika = db.Tbl_Sertifikalarım.ToList();
            return PartialView(sertifika);
        }
        [HttpGet]
        public PartialViewResult İletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult İletisim(Tbl_İletişim t)
        {
            t.TARIH =DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbl_İletişim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}