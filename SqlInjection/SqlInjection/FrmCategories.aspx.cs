using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlInjection
{
    public partial class FrmCategories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sqlStatement = @"SELECT [CategoryID],[CategoryName],[Description]FROM [NorthWind].[dbo].[Categories] order by [CategoryId] ASC";
            var connString =
                System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            var conn = new SqlConnection(connString);
            conn.Open();
            var cmd = new SqlCommand(sqlStatement, conn);
            
            this.dgCategorias.DataSource = cmd.ExecuteReader();
            this.dgCategorias.DataBind();

        }
    }
}