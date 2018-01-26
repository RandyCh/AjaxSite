using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Read : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {     string strData = "";
        //給予適當的名稱空間
        //步驟一建立連線物件
        //連線字串 https://www.connectionstrings.com/ 
        string strConn = "Server=.;Database=Northwind;Trusted_Connection=True;";
        using (SqlConnection conn=new SqlConnection(strConn))
        {
            //步驟二透過command物件去資料庫讀取資料
            string strCmd = "select * from member";
            using(SqlCommand cmd=new SqlCommand(strCmd, conn))
            {
                //步驟三透過command物件的excuteReader的方法
                //產生dataReader物件
                //開啟連線
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //ado.net
                ////步驟四透過DateReader讀取資料
                while (dr.Read())//當有資料dr.read=true
                {
                    //    //dr["Name"]
                    //    //顯示資料
                    strData += string.Format("<tr><td>{0}</td>", dr["Id"]);
                    strData += string.Format("<td>{0}</td>", dr["Name"]);
                    strData += string.Format("<td>{0}</td>", dr["Password"]);
                    strData += string.Format("<td>{0}</td>", dr["Email"]);
                    strData += string.Format("<td><a href='delete.aspx?id={0}' class='btn btn-danger'>刪除</a><a href='edit.aspx?id={0}' class='btn btn-primary'>編輯</a></td></tr>", dr["Id"]);
                }

                //strData += ("  Connection State = " + conn.State);
                conn.Close();
                //strData +=("  Connection State = " + conn.State);
            }
             //strData += ("  Connection State = " + conn.State);
             //Literal1.Text = strData;

        }

       
    }
}