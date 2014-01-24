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
using System.Web.Caching;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            Cache["CurTime:"] = DateTime.Now;
            Cache.Insert("SesName", ".Net Intermediate Session");
        }

        Label1.Text = DateTime.Now.ToLongTimeString();
        Label2.Text = Cache["SesName"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
