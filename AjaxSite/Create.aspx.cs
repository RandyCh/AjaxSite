using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //使用者透過http post傳過來的資料
        //在server端用 Request.Form["欄位名稱"]來接受資料

        //使用者透過http get傳過來的資料
        //在server端 Request.QueryString["參數名稱"]
        string strName = Request.Form["username"];
        string strPassword = Request.Form["password"];
        string strEmail = Request.Form["email"];
        Literal1.Text = string.Format("{0}您好 ,你的電子郵件是{1}", strName, strEmail);
    }
}