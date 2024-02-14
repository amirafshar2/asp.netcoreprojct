




using BLL.Concreate;
using ClosedXML.Excel;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {

        BlogeManager _bll = new BlogeManager(new EfBlogRepository());
        public IActionResult ExportExelBlogList()
        {
            using(var WorkBook = new XLWorkbook())//ClosedXML package ile kulanıla bilir
            {
                var WorkShit = WorkBook.Worksheets.Add("Blog Listsi");
                WorkShit.Cell(1, 1).Value = "Blog Id";
                WorkShit.Cell(1, 2).Value = "Blog Adı";
                WorkShit.Cell(1, 3).Value = "Blog İçeriği";
                int RowNumber = 2;
                foreach (var item in _bll.GetAll())
                {
                    WorkShit.Cell(RowNumber, 1).Value = item.id;
                    WorkShit.Cell(RowNumber, 2).Value = item.Title;
                    WorkShit.Cell(RowNumber, 3).Value = item.Content;
                    RowNumber++;
                }
                using (var stream = new MemoryStream())
                {
                    WorkBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlfomats-officedocument.spreadsheetml.sheet", "Çalışma1.xlsx");
                }
            }
           
        }
        public IActionResult BlogListExel()
        {
            return View();
        }
    }
}
