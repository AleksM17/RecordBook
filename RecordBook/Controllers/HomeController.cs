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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Record record = _recordRepo.GetRecord(id);
            return View(record);
        }

        [HttpPost]
        public ActionResult Edit(Record record)
        {
            if (ModelState.IsValid)
            {
                _recordRepo.UpdateRecord(record);
                return RedirectToAction("Index");
            }
            return View(record);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Record record = _recordRepo.GetRecord(id);
            return View(record);
        }

        [HttpPost]
        public ActionResult Delete(Record record)
        {
            if (ModelState.IsValid)
            {
                _recordRepo.Delete(record);
                return RedirectToAction("Index");
            }
            return View(record);
        }
    }
}