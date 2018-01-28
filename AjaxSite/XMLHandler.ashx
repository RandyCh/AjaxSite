<%@ WebHandler Language="C#" Class="XMLHandler" %>

using System;
using System.Web;
using System.Data;//使用dataset
using System.Data.SqlClient;//sqlconnection
using System.Configuration;//從webconfig讀資料

public class XMLHandler : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        //從webconfig放入"connectstring"
        string strConn = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            string strCmd = "select CategoryID,CategoryName from Categories";//categories是資料表名稱
            using (SqlDataAdapter da=new SqlDataAdapter(strCmd, conn))//建立連線物件
            {
                DataSet ds = new DataSet();
                ds.DataSetName = "Categories";//根元素
                da.Fill(ds,"Category");//Category是dataset中的datatable名稱
                context.Response.ContentType = "text/xml";
                context.Response.Write(ds.GetXml());
            }
        }

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}