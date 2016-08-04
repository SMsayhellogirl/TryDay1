using Day1HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1HomeWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Day1homework()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Day1homework(Day1ViewMode day)
        {
            if (TempData["GetMyView"] == null)
            {
                TempData["GetMyView"] = getdefult();
            }
            Day1ViewMode viewdata = new Day1ViewMode();
            viewdata.Dno = 4;
            viewdata.Dtype = day.Dtype;
            viewdata.Dmoney = day.Dmoney;
            viewdata.Dday = day.Dday;
            viewdata.Dnote = day.Dnote;

            List<Day1ViewMode> myviewdata = new List<Day1ViewMode>();
            myviewdata = (List<Day1ViewMode>)TempData["GetMyView"];
            myviewdata.Add(viewdata);

            TempData["GetMyView"] = myviewdata;
            return View();
        }

        [ChildActionOnly]
        public ActionResult Day1homeworkChirldaction()
        {
            if (TempData["GetMyView"] == null)
            {
                TempData["GetMyView"] = getdefult();
            }

            return View(TempData["GetMyView"]);
        }

        public List<Day1ViewMode> getdefult()
        {
            List<Day1ViewMode> myviewdata = new List<Day1ViewMode>();
            

            for (int i = 1; i < 4; i++)
            {
                Day1ViewMode myview = new Day1ViewMode();
                myview.Dno = i;
                myview.Dtype = "支出";
                myview.Dday = "2016-01-0"+ i.ToString();
                myview.Dmoney = (i * 150).ToString();
                myview.Dnote = "我是備註" + i.ToString();
                myviewdata.Add(myview);
            }

            return myviewdata;
        }
    }
}