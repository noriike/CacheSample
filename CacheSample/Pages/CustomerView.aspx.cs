using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CacheSample.Pages.Logic;
namespace CacheSample.Pages
{
    public partial class CustomerView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            var result=CustomerViewLogic.Read();

        }
    }
}