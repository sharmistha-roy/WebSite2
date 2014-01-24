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

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Name"] = TextBox1.Text;
        Response.Write("Name added into session variable");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("unique session id:" + Session.SessionID);
        Response.Write("<br/><br/>");
        Response.Write("\nName: " +Session["Name"].ToString());
    }
}
