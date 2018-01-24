<%@ WebHandler Language="C#" Class="add" %>

using System;
using System.Web;

public class add : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");
        context.Response.Write(context);

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}