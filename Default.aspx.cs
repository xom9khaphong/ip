using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Địa chỉ ip của bạn = " + getipaddress();
    }
    public string getipaddress()
    {
        string visitor = string.Empty;
        if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
        {
            visitor = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();

        }
        else if(System.Web.HttpContext.Current.Request.UserHostAddress.Length!=null)
        {
            visitor = System.Web.HttpContext.Current.Request.UserHostAddress;
        }
        return visitor;
    }
}