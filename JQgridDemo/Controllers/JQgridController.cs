using JQgridDemo.Service;
using JQgridDemo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQgridDemo.Controllers
{
    public class JQgridController : Controller
    {
        internal ICacheProvider Cache { get; set; }

        public JQgridController() {
            Cache = new DefaultCacheProvider();
        }

        public ActionResult JQgrid1()
        {
            return View();
        }

        public ActionResult JQgrid2()
        {
            return View();
        }

        public ActionResult JQgrid3()
        {
            return View();
        }

        public ActionResult JQgrid4()
        {
            return View();
        }

        public ActionResult JQgrid5()
        {
            return View();
        }

        public ActionResult JQgrid6()
        {
            List<myClass> data = new List<myClass>() {
                new myClass(){ id = 1, invdate =  "2007-10-01", name= "test", note= "note", amount= "200.00", tax= "10.00", total= "210.00" },
                new myClass(){ id = 2, invdate= "2007-10-02", name= "test2", note= "note2", amount= "300.00", tax= "20.00", total= "320.00" },
                new myClass(){ id = 3, invdate= "2007-09-01", name= "test3", note= "note3", amount= "400.00", tax= "30.00", total= "430.00" },
                new myClass(){ id = 4, invdate= "2007-10-04", name= "test", note= "note", amount= "200.00", tax= "10.00", total= "210.00" },
                new myClass(){ id = 5, invdate= "2007-10-05", name= "test2", note= "note2", amount= "300.00", tax= "20.00", total= "320.00" },
                new myClass(){ id = 6, invdate= "2007-09-06", name= "test3", note= "note3", amount= "400.00", tax= "30.00", total= "430.00" }
            };
            Cache.Set("JQgrid6",data);
            return View();
        }

        public ActionResult JQgrid7()
        {
            List<myClass> data = new List<myClass>() {
                new myClass(){ id = 1, invdate =  "2007-10-01", name= "test", note= "note", amount= "200.00", tax= "10.00", total= "210.00" },
                new myClass(){ id = 2, invdate= "2007-10-02", name= "test2", note= "note2", amount= "300.00", tax= "20.00", total= "320.00" },
                new myClass(){ id = 3, invdate= "2007-09-01", name= "test3", note= "note3", amount= "400.00", tax= "30.00", total= "430.00" },
                new myClass(){ id = 4, invdate= "2007-10-04", name= "test", note= "note", amount= "200.00", tax= "10.00", total= "210.00" },
                new myClass(){ id = 5, invdate= "2007-10-05", name= "test2", note= "note2", amount= "300.00", tax= "20.00", total= "320.00" },
                new myClass(){ id = 6, invdate= "2007-09-06", name= "test3", note= "note3", amount= "400.00", tax= "30.00", total= "430.00" }
            };
            Cache.Set("JQgrid7", data);
            return View();
        }

        public ActionResult JQgrid8()
        {
            return View();
        }

        public ActionResult JQgrid9()
        {
            return View();
        }

        public ActionResult JQgrid10()
        {
            List<myClass> data = new List<myClass>() {
                new myClass(){ id = 1, invdate =  "2007-10-01", name= "test", note= "note", amount= "200.00", tax= "10.00", total= "210.00" },
                new myClass(){ id = 2, invdate= "2007-10-02", name= "test2", note= "note2", amount= "300.00", tax= "20.00", total= "320.00" },
                new myClass(){ id = 3, invdate= "2007-09-01", name= "test3", note= "note3", amount= "400.00", tax= "30.00", total= "430.00" },
                new myClass(){ id = 4, invdate= "2007-10-04", name= "test", note= "note", amount= "200.00", tax= "10.00", total= "210.00" },
                new myClass(){ id = 5, invdate= "2007-10-05", name= "test2", note= "note2", amount= "300.00", tax= "20.00", total= "320.00" },
                new myClass(){ id = 6, invdate= "2007-09-06", name= "test3", note= "note3", amount= "400.00", tax= "30.00", total= "430.00" }
            };

            List<myClass2> subdata = new List<myClass2>() {
            new myClass2(){ id = 1, name = "Desktop Computer", note = "note", stock = "Yes", ship = "FedEx", sdate = "2007-12-03" },
            new myClass2(){ id = 1, name = "Laptop", note = "Long text ", stock = "Yes", ship = "InTime", sdate = "2007-12-03" },
            new myClass2(){ id = 2, name = "LCD Monitor", note = "note3", stock = "Yes", ship = "TNT", sdate = "2007-12-03" },
            new myClass2(){ id = 3, name = "Speakers", note = "note", stock = "No", ship = "ARAMEX", sdate = "2007-12-03" },
            new myClass2(){ id = 3, name = "Laser Printer", note = "note2", stock = "Yes", ship = "FedEx", sdate = "2007-12-03" },
            new myClass2(){ id = 3, name = "Play Station", note = "note3", stock = "No", ship = "FedEx", sdate = "2007-12-03" },
            new myClass2(){ id = 4, name = "Mobile Telephone", note = "note", stock = "Yes", ship = "ARAMEX", sdate = "2007-12-03" },
            new myClass2(){ id = 5, name = "Server", note = "note2", stock = "Yes", ship = "TNT", sdate = "2007-12-03" },
            new myClass2(){ id = 6, name = "Matrix Printer", note = "note3", stock = "No", ship = "FedEx", sdate = "2007-12-03" }
            };
            Cache.Set("JQgrid10", data);
            Cache.Set("JQgrid10Sub", subdata);
            return View();
        }

        public ActionResult JQgrid11()
        {
            return View();
        }

        /// <summary>
        /// jqgrid cache data
        /// </summary>
        /// <param name="jdata"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetCacheData(jqGridParam jdata,string type)
        {
            switch (type)
            {
                case "JQgrid6":
                    return Json(jdata.modelToJqgridResult(((List<myClass>)Cache.Get("JQgrid6")).OrderBy(x=>x.id).ToList()));
                case "JQgrid7":
                    return Json(jdata.modelToJqgridResult(((List<myClass>)Cache.Get("JQgrid7")).OrderBy(x => x.id).ToList()));
                case "JQgrid10":
                    return Json(jdata.modelToJqgridResult(((List<myClass>)Cache.Get("JQgrid10")).OrderBy(x => x.id).ToList()));
            }
            return null;
        }

        [HttpPost]
        public JsonResult GetCacheSubData(jqGridParam jdata, string type, int id)
        {
            switch (type)
            {
                case "JQgrid10Sub":
                    return Json(jdata.modelToJqgridResult(((List<myClass2>)Cache.Get("JQgrid10Sub"))
                        .Where(x=>x.id == id).OrderBy(x => x.name).ToList()));
            }
            return null;
        }

        public JsonResult SetData()
        {
            var requestKey = Request.Form.AllKeys;
            var pros = typeof(myClass).GetProperties();
            var datas = (List<myClass>)Cache.Get("JQgrid6");
            var id = 0;
            Int32.TryParse(Request.Form["id"],out id);
            switch (Request.Form["oper"])
            {
                case "add":
                    var data_add = new myClass();
                    foreach (var par in requestKey)
                    {
                        var p = pros.FirstOrDefault(y => y.Name == par);
                        if (p != null && par != "id")
                            p.SetValue(data_add,Request.Form[par]);
                    }
                    if (datas.Any())
                        id = datas.Max(x => x.id) + 1;
                    else
                        id = 1;
                    data_add.id = id;
                    datas.Add(data_add);
                    Cache.Invalidate("JQgrid6");
                    Cache.Set("JQgrid6", datas);
                    break;
                case "edit":
                    var data_edit = datas.FirstOrDefault(x => x.id == id);
                    if (data_edit != null)
                    {
                        foreach (var par in requestKey)
                        {
                            var p = pros.FirstOrDefault(y => y.Name == par);
                            if (p != null && par != "id")
                                p.SetValue(data_edit,Request.Form[par]);
                        }
                        Cache.Invalidate("JQgrid6");
                        Cache.Set("JQgrid6",datas);
                    }
                    break;
                case "del":
                    var data_del = datas.FirstOrDefault(x => x.id == id);
                    if(data_del != null)
                    {
                        datas.Remove(data_del);
                        Cache.Invalidate("JQgrid6");
                        Cache.Set("JQgrid6", datas);
                    }
                    break;
            }
            return null;
        }

        [HttpPost]
        public JsonResult AddData(myClass data)
        {
            var datas = (List<myClass>)Cache.Get("JQgrid7");
            var id = 1;
            if (datas.Any())
                id = datas.Max(x => x.id) + 1;
            data.id = id;
            datas.Add(data);
            Cache.Invalidate("JQgrid7");
            Cache.Set("JQgrid7", datas);
            return null;
        }

        [HttpPost]
        public JsonResult EdiData(myClass data)
        {
            var datas = (List<myClass>)Cache.Get("JQgrid7");
            var pros = typeof(myClass).GetProperties();
            var data_edit = datas.FirstOrDefault(x => x.id == data.id);
            if (data_edit != null)
            {
                foreach (var pro in pros)
                {
                    pro.SetValue(data_edit, pro.GetValue(data));
                }
                Cache.Invalidate("JQgrid7");
                Cache.Set("JQgrid7", datas);
            }
            return null;
        }

        [HttpPost]
        public JsonResult DelData(myClass data)
        {
            var datas = (List<myClass>)Cache.Get("JQgrid7");
            var data_del = datas.FirstOrDefault(x => x.id == data.id);
            if (data_del != null)
            {
                datas.Remove(data_del);
                Cache.Invalidate("JQgrid7");
                Cache.Set("JQgrid7", datas);
            }
            return null;
        }

        public class myClass {
            public int id { get; set; }
            public string invdate { get; set; }
            public string name { get; set; }
            public string amount { get; set; }
            public string tax { get; set; }
            public string total { get; set; }
            public string note { get; set; }
        }

        public class myClass2 {
            public int id { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string stock { get; set; }
            public string ship { get; set; }
            public string sdate { get; set; }
        }
    }
}