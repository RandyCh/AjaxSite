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
    {
        //給予適當的名稱空間
        //步驟一建立連線物件
        //連線字串 https://www.connectionstrings.com/ 
        string strConn = "Server=.;Database=Northwind;Trusted_Connection=True;";
        using (SqlConnection conn=new SqlConnection(strConn))
        {
            //步驟二透過command物件去資料庫讀取資料
            string strCmd = "select * from Memeber";
            using(SqlCommand cmd=new SqlCommand(strCmd, conn))
            {
                //步驟三透過command物件的excuteReader的方法
                //產生dataReader物件
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //ado.net
                string strDate = "";
                //步驟四透過DateReader讀取資料
                while (dr.Read())//當有資料dr.read=true
                {
                    //dr["Name"]
                    //顯示資料
                    strDate += string.Format("<tr><td>(0)</td>", dr["Id"]);
                    strDate += string.Format("<tr><td>(0)</td>", dr["Name"]);
                    strDate += string.Format("<tr><td>(0)</td>", dr["Password"]);
                    strDate += string.Format("<tr><td>(0)</td></tr>", dr["email"]);

                }
                conn.Close();
                Literal1.Text = strDate;
            }
            
        }
    }
}