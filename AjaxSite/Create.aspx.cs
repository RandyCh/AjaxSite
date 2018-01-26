using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string strName ="";
        string strPassword ="";
        string strEmail ="";
        if (Request.QueryString["username"] != null)
        {
            strName = Request.QueryString["username"];
        }
        if (Request.QueryString["password"] != null)
        {
            strPassword = Request.QueryString["password"];
        }
        if (Request.QueryString["email"] != null)
        {
            strEmail = Request.QueryString["email"];
        }



        //使用者透過http post傳過來的資料
        //在server端用 Request.Form["欄位名稱"]來接受資料

        ////使用者透過http get傳過來的資料
        ////在server端 Request.QueryString["參數名稱"]
        //string strName = Request.Form["username"];
        //string strPassword = Request.Form["password"];
        //string strEmail = Request.Form["email"];
        //Literal1.Text = string.Format("{0}您好 ,你的電子郵件是{1}", strName, strEmail);
        //給予適當的名稱空間
        //步驟一建立連線物件
        ////連線字串 https://www.connectionstrings.com/  Trusted Connection:windows驗證 Standard Security:sa驗證
        string strConn = "Server=.;Database=Northwind;Trusted_Connection=True;";
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            //步驟二使用command物件,將資料寫進資料庫中
            string strCmd = "Insert into Member(Name,Password,Email)values(@UserName,@Password,@Email)";
            using (SqlCommand cmd = new SqlCommand(strCmd, conn))
            {
                cmd.Parameters.AddWithValue("@UserName", strName);
                cmd.Parameters.AddWithValue("@Password", strPassword);
                cmd.Parameters.AddWithValue("@Email", strEmail);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Literal1.Text = string.Format("{0}您好 ,你的電子郵件是{1}", strName, strEmail);
            }
        }

       


    }
}