using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomPaging.Models;
namespace CustomPaging.Controllers
{
    public class HomeController : Controller
    {
       // int page = 1;
        // GET: Home
        private readonly List<Studentinform> _st;
       public static int pageNo;
        
        public HomeController()
        {
            _st = new List<Studentinform>()
            {
                new Studentinform() {Id = 1, Name = "Jack_delete", Address="",marks=45},
                new Studentinform() {Id = 2, Name = "Riley", Address="",marks=58},
                new Studentinform() {Id = 3, Name = "William_delete",Address="",marks=88},
                new Studentinform() {Id = 4, Name = "Oliver", Address="",marks=99},
                new Studentinform() {Id = 5, Name = "Lachlan_delete", Address="",marks=87},
                new Studentinform() {Id = 6, Name = "Thomas",Address="",marks=49},
                new Studentinform() {Id = 7, Name = "Joshua_delete", Address="",marks=65},
                new Studentinform() {Id = 8, Name = "James", Address="",marks=74},
                new Studentinform() {Id = 9, Name = "Liam_delete", Address="",marks=89},
                new Studentinform() {Id = 10, Name = "Max", Address="",marks=88}
            };
        }
        [HttpGet]
        public ActionResult Index(int page = 1)
        {
            int pageSize = 2;
            int totalPage = 0;
            int totalRecord = 0;
            totalRecord = _st.Count();
            //var removed = _st.Select(a=>a.Name.Contains("_delete")).ToList();
            totalPage = (totalRecord / pageSize) + ((totalRecord % pageSize) > 0 ? 1 : 0);
           var  allCustomer = _st.OrderBy(a => a.Id).Skip(((page - 1) * pageSize)).Take(pageSize).ToList();
           ViewBag.TotalRows = totalRecord;
           ViewBag.PageSize = pageSize;
           return View(allCustomer);
        }
        [HttpPost]
        public ActionResult Index(int page=1,int? x=0)
        {
            int pageSize = 2;
            int totalPage = 0;
            int totalRecord = 0;
            totalRecord = _st.Count();
            totalPage = (totalRecord / pageSize) + ((totalRecord % pageSize) > 0 ? 1 : 0);
            string start = Request.QueryString["page"];
            pageNo = Convert.ToInt32(start);
            var allCustomer = _st.OrderBy(a => a.Id).Skip(((page - 1) * pageSize)).Take(pageSize).ToList();
            ViewBag.TotalRows = totalRecord;
            ViewBag.PageSize = pageSize;
            return View(allCustomer);
        }
         public static readonly int p = 1;
    }
}