<%@ WebHandler Language="C#" Class="param" %>

using System;
using System.Web;

public class param : IHttpHandler {


    public void ProcessRequest (HttpContext context) {
        ////使用者透過http get傳過來的資料
        ////在server端 Request.QueryString["參數名稱"]
        //string strusername=context.Request.QueryString["userName"];
        //string strage=context.Request.QueryString["age"];
        //content type不是form data就不能透過request.form or request.params去收結果

        string strusername=context.Request.Params["userName"];
        string strage=context.Request.Params["age"];

        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World "+strusername+" "+strage);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}