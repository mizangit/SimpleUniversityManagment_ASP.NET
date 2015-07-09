using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace University_Management_System
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void deparmtmentButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Department_Entry.aspx");
        }

        protected void studentButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Entry.aspx");
        }
    }
}