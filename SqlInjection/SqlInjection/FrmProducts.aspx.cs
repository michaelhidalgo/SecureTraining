using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlInjection
{
    public partial class FrmProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var connString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            var context = HttpContext.Current;
            if (context!=null)
            {
                var request = context.Request;
                var queryId = request["productId"];

                var sqlStatement = String.Format("SELECT [ProductName],[SupplierID],[CategoryID],[QuantityPerUnit],[UnitPrice]," +
                                                 "[UnitsInStock],[UnitsOnOrder],[ReorderLevel],[Discontinued]" +
                                                 "FROM [NorthWind].[dbo].[Products] WHERE CategoryID ={0}", queryId);
                
                var conn = new SqlConnection(connString);
                conn.Open();
                var cmd = new SqlCommand(sqlStatement, conn);

                this.dgProduct.DataSource = cmd.ExecuteReader();
                this.dgProduct.DataBind();
                this.Label1.Text = String.Format("Mostrando {0} productos", this.dgProduct.Rows.Count.ToString());
            }
        }
    }
}