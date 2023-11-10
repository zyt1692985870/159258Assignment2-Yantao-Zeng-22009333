using System;
using System.Collections.Generic;
using System.Web.Mvc;

public class LoginController : Controller
{
    // 显示登录页面
    public ActionResult Index()
    {
        return View();
    }

    // 处理登录提交
    [HttpPost]
    public ActionResult Login(string username, string password)
    {

        return RedirectToAction("Home");
    }

    // 登录成功后跳转到Home视图
    public ActionResult Home()
    {
        return View("~/Views/Home/home.cshtml");
    }
}

