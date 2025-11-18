using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio_19_3.Controllers
{
    public class ConsumoValue2Controller : Controller
    {
        // GET: ConsumoValue2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetItem()
        {
            string url = "https://localhost:44308/api/Values/Get/2";
            string responseBody = "";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                using (WebResponse response = request.GetResponse())
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null)
                        return Content("No hay respuesta del servidor.");
                    using(StreamReader objReader = new StreamReader(strReader))
                    {
                        responseBody = objReader.ReadToEnd();
                    }
                }
            }catch (WebException ex)
            {
                responseBody = "Error al consumir el servicio: " + ex.Message;
            }

            ViewBag.Resultado = responseBody;
            return View("resultado");
        }
    }
}