    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL.Models;

namespace BTL.Controllers
{
    public class NhanvienController : Controller
    {
        //khai bao doi tuong ket noi voi database
        PTPMQLYDbContext db = new PTPMQLYDbContext();
        // GET: Nhanvien
        public ActionResult Index()
        {
            //lay toan bo du lieu trong bang Nhanvien
            //tra ve dang list roi hien thi len view
            return View(db.Nhanviens.ToList());
        }
        //tao action create tra ve view cho nguoi dung
        //nhap thong tin nhan vien de them moi vao CSDL
        public ActionResult Create()
        {
            return View();
        }
        //tao action create voi tham so de nhan du lieu tu client
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Nhanvien nv)
        {
            //neu dieu kien rang buoc o class duoc thoa man
            if (ModelState.IsValid)
            {
                //them moi doi tuong nv vao  trong CSDL
                db.Nhanviens.Add(nv);
                //cap nhat thay doi vao CSDL 
                db.SaveChanges();
                return RedirectToAction("Index");
            }    
            //neu dieu kien rang buoc o class khong thoa man
            return View(nv);
        }
    }
}