<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;
//server端程式 用.ashx 泛型處理程式
public class Handler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
            System.Threading.Thread.Sleep(5000);//等待五秒鐘
        //response server端要給client端的
        context.Response.ContentType = "text/plain";// type是純文字資料
        //context.Response.ContentType = "text/html";//瀏覽器把h2當作標籤看
        //context.Response.ContentType = "Application/vnd.ms-word";//瀏覽器把hello wod當作word檔案
        //context.Response.ContentType = "Application/pdf";//把檔案當作pdf
        context.Response.Write("<h2>Hello World<h2>");
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}