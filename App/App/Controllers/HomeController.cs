using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Models;
using OfficeOpenXml;
using System.Globalization;


namespace App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            List<Employee> lstEmployee = new List<Employee>();

            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });


            return View(lstEmployee);
        }

        public void DownloadExcel()
        {

            List<Employee> lstEmployee = new List<Employee>();

            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });

            ExcelPackage Ep = new ExcelPackage();
            ExcelWorksheet Sheet = Ep.Workbook.Worksheets.Add("Report");
            Sheet.Cells["A1"].Value = "Name";
            Sheet.Cells["B1"].Value = "Address";
            Sheet.Cells["C1"].Value = "Birthday";
            int row = 2;

            foreach (var item in lstEmployee)
            {

                Sheet.Cells[string.Format("A{0}", row)].Value = item.Name;
                Sheet.Cells[string.Format("B{0}", row)].Value = item.Address;
                Sheet.Cells[string.Format("C{0}", row)].Value = item.Birthday.ToString();
                row++;
            }
            Sheet.Cells["A:AZ"].AutoFitColumns();
            Response.Clear();
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("content-disposition", "attachment: filename=" + "Report.xlsx");
            Response.BinaryWrite(Ep.GetAsByteArray());
            Response.End();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
