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

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Response.Cookies["UserName"].Value = " ";
            Label1.Text = "Guest, Welcome to Dot Net Session";
        }
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            if (TextBox1.Text != string.Empty)
                Response.Cookies["UserName"].Value = TextBox1.Text;
            if (Request.Cookies["UserName"] != null)
                Label1.Text = "Dear Mam" + Request.Cookies["UserName"].Value + ", Welcome to Dot Net Session";
            else
                Label1.Text = "Guest, Welcome to Dot Net Session";
           }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ViewState["Name"] = TextBox1.Text.ToString();
        Label1.Text = "your name is saved in view state";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string name = (string)ViewState["Name"];
        Label1.Text = "Hi " + name + " Reading from view state";
        Response.Write("Hi " + name + " Reading from view state");
    }
}
