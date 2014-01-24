using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlConnection con = new SqlConnection("Data Source=CSE_SHARMISTHAR\\SQLEXPRESS1;Initial Catalog=Student;Integrated Security=True");
        con.Open();
        //SqlCommand cmd = new SqlCommand("select Emp_id from std", con);
        SqlCommand cmd= new SqlCommand("insert into std(Emp_id,Emp_name,Emp_age,Emp_dept) Values(3,'Jayeeta',26,'sce')",con);
        SqlCommand cmd1 = new SqlCommand("delete from std where Emp_id=3", con);

        cmd.ExecuteNonQuery();
       // cmd1.ExecuteNonQuery();
        SqlDataAdapter adp= new SqlDataAdapter("select * from std",con);
        DataSet ds= new DataSet();
        adp.Fill(ds,"Student details");
        //SqlDataReader reader = cmd.ExecuteReader();
       // GridView1.DataSource = reader;
        //GridView1.DataBind();
        //reader.Close();
        con.Close();
        GridView1.DataSource=ds;
        GridView1.DataBind();
    }
}
