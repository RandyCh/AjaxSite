using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = "1025";
        if (Request.QueryString["id"] != null)
        {
            id = Request.QueryString["id"];
        }
        //給予適當的名稱空間
        //步驟一建立連線物件
        //連線字串 https://www.connectionstrings.com/ 
        string strConn = "Server=.;Database=Northwind;Trusted_Connection=True;";
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            //步驟二透過command物件去刪除資料庫資料
            string strCmd = "delete member where id=@memberid";
            using (SqlCommand cmd = new SqlCommand(strCmd, conn))
            {
                cmd.Parameters.AddWithValue("@memberid", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            Response.Redirect("~/Read.aspx");
        }
    }
}