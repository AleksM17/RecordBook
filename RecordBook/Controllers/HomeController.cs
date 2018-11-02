using RecordBook.Dal;
using RecordBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecordBook.Controllers
{
    public class HomeController : Controller
    {
        IRecordRepository _recordRepo = new SqlRepository();
        // GET: Home
        public ActionResult Index()
        {
            return View(_recordRepo.GetRecords());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Record record)
        {
            if (ModelState.IsValid)
            {
                record.Date=DateTime.Now;
                _recordRepo.CreateRecord(record);
                return RedirectToAction("Index");
            }
            return View(record);
        }
    }
}