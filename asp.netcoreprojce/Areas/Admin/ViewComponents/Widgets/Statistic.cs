








using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace asp.netcoreprojce.Areas.Admin.ViewComponents.Widgets
{
    public class Statistic: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string api = "baca2c85d18f1f9d5c718539fcc11533";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument doc = XDocument.Load(connection);
            ViewBag.wh = doc.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
