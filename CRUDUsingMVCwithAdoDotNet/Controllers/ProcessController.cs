using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WassenBurgMedical.Models;
using WassenBurgMedical.Repository;
namespace CRUDUsingMVC.Controllers
{
   
    public class ProcessController : Controller
    {
      
        public ActionResult GetAllProcessDetails(string search)
        {
            List<ProcessModel> dataList = new List<ProcessModel>();
            ProcessDataRepository ProcessRepo = new ProcessDataRepository();
            if (string.IsNullOrEmpty(search))
            {               
                ModelState.Clear();
                dataList = ProcessRepo.GetAllProcessData();
            }
            else
            {
                ModelState.Clear();
                List<ProcessModel> processList = ProcessRepo.GetAllProcessData();
                dataList = ProcessRepo.SearchProcessData(processList,search);
                search = "";
            }
            return View(dataList);
        }
        public ActionResult Details(int Id)
        {
            ProcessDataRepository ProcessRepo = new ProcessDataRepository();
            ProcessModel dataList = new ProcessModel();
            dataList = ProcessRepo.GetAllProcessData().Where(x=>x.CustomerId==Id).FirstOrDefault();
            return PartialView("_Details", dataList);
        }

        // GET: Employee/AddEmployee
        public ActionResult AddEmployee()
        {
            return View();
        }

    }
}
