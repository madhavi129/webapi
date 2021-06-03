using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using StudentModelmvc.Models;
using StudentWebapi;

namespace StudentModelmvc.Controllers
{
    public class StundentsModelController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            IEnumerable<StudentModel> studata = null;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "https://localhost:44333/api/";
                var json = webClient.DownloadString("Students");
                var list = JsonConvert.DeserializeObject<List<StudentModel>>(json);
                studata = list.ToList();
                return View(studata);
            }
        }

        // GET: Students/Details/5
        public ActionResult Details(int id)
        {
            StudentModel studata;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "https://localhost:44333/api/";
                var json = webClient.DownloadString("Students/" + id);
                studata = JsonConvert.DeserializeObject<StudentModel>(json);
            }
            return View(studata);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        public ActionResult Create(StudentModel model)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "https://localhost:44333/api/";
                    var url = "Students/POST";
                    //webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string data = JsonConvert.SerializeObject(model);
                    var response = webClient.UploadString(url, data);
                    JsonConvert.DeserializeObject<StudentModel>(response);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int id)
        {
            StudentModel studata;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "https://localhost:44333/api/";

                var json = webClient.DownloadString("Students/" + id);
                //  var list = emp 
                studata = JsonConvert.DeserializeObject<StudentModel>(json);
            }
            return View(studata);
        }

        // POST: Students/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StudentModel model)
        {

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "https://localhost:44333/api/Students/" + id;
                    //var url = "Values/Put/" + id;
                    //webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string data = JsonConvert.SerializeObject(model);

                    var response = webClient.UploadString(webClient.BaseAddress, "PUT", data);

                    StudentModel modeldata = JsonConvert.DeserializeObject<StudentModel>(response);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }


        //GET
        //public ActionResult Delete(int id)
        //{
        //    StudentModel studata;
        //    using (WebClient webClient = new WebClient())
        //    {
        //        webClient.BaseAddress = "https://localhost:44333/api/";
        //        var json = webClient.DownloadString("Students/" + id);
        //        studata = JsonConvert.DeserializeObject<StudentModel>(json);
        //    }
        //    return View(studata);

        //}
        //[HttpPost]
        //public ActionResult Delete(int id, StudentModel model)
        //{

        //    try
        //    {
        //        using (WebClient webClient = new WebClient())
        //        {
        //            NameValueCollection nv = new NameValueCollection();
        //            string url = "https://localhost:44333/api/Students/" + id;
        //            var response = Encoding.ASCII.GetString(webClient.UploadValues(url, "DELETE", nv));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return RedirectToAction("Index");
        //}
    }

}