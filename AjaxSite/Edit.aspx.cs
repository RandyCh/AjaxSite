using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = "1";
        if (Request.QueryString["id"] != null)
        {
            id = Request.QueryString["id"];
        }
        string strConn = "Server=.;Database=Northwind;Trusted_Connection=True;";
        using (SqlConnection conn = new SqlConnection(strConn))
        {
            //步驟二透過command物件去資料庫讀取資料
            string strCmd = "select * from member where id=@id";
            using (SqlCommand cmd = new SqlCommand(strCmd, conn))
            {
                //步驟三透過command物件的excuteReader的方法
                //產生dataReader物件
                //開啟連線
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //ado.net
                string strData = "";
                ////步驟四透過DateReader讀取資料
                if(dr.Read())//當有資料dr.read=true
                {
                    //    //dr["Name"]
                    //    //顯示資料
                    strData += string.Format("<div class='form-group'><div class='form-group'><label for='username'>姓名</label><input type='text' name='UserNmae' class='form-control col-8-xs' id='username' value='{0}'></div>", dr["Name"]);
                    strData += string.Format("<div class='form-group'><div class='form-group'><label for='email' class='col-2-sm'>Email</label><input type='text' name='email' class='form-control col-8-xs' id='email' value='{0}'></div></div>", dr["Email"]);
                }
                Literal1.Text = strData;
                conn.Close();
                
                
            }
           
            

        }


    }
}