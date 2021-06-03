using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;


namespace WebApplication1.Controllers
{
    public class SupplierController : Controller
    {
        // GET: Supplier
        public ActionResult Index()
        {

            IEnumerable<SupplierViewModel> supdata = null;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "https://localhost:44360/api/";

                var json = webClient.DownloadString("Suppliers");
                var list = JsonConvert.DeserializeObject<List<SupplierViewModel>>(json);
                supdata = list.ToList();
                return View(supdata);
            }
        }

        public ActionResult Details(int id)
        {

            SupplierViewModel supdata;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "https://localhost:44360/api/";

                var json = webClient.DownloadString("Suppliers/" + id);
                //  var list = emp 
                supdata = JsonConvert.DeserializeObject<SupplierViewModel>(json);
            }
            return View(supdata);
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(SupplierViewModel model)
        {

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "https://localhost:44360/api/";
                    var url = "Suppliers/POST";
                    //webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string data = JsonConvert.SerializeObject(model);
                    var response = webClient.UploadString(url, data);
                    JsonConvert.DeserializeObject<SupplierViewModel>(response);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            SupplierViewModel supdata;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "https://localhost:44360/api/";

                var json = webClient.DownloadString("Values/" + id);
                //  var list = emp 
                supdata = JsonConvert.DeserializeObject<SupplierViewModel>(json);
            }
            return View(supdata);

        }


        public ActionResult EditEmployee(int id)
        {
            SupplierViewModel supdata;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "https://localhost:44360/api/";

                var json = webClient.DownloadString("Values/" + id);
                //  var list = emp 
                supdata = JsonConvert.DeserializeObject<SupplierViewModel>(json);
            }
            return View(supdata);
        }
        [HttpPost]
        public ActionResult Delete(int id, SupplierViewModel model)
        {

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "https://localhost:44360/api/Values/" + id;
                    var url = "Values/Delete";
                    //webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    //webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    //string data = JsonConvert.SerializeObject(model);

                    //var response = webClient.UploadString(webClient.BaseAddress, data);

                    //EmployeeViewModel modeldata = JsonConvert.DeserializeObject<EmployeeViewModel>(response);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult EditEmployee(int id, SupplierViewModel model)
        {

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "http://localhost:44360/api/Values/1";
                    //var url = "Values/Put/" + id;
                    //webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string data = JsonConvert.SerializeObject(model);

                    var response = webClient.UploadString(webClient.BaseAddress, data);

                    SupplierViewModel modeldata = JsonConvert.DeserializeObject<SupplierViewModel>(response);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }
    }
}



