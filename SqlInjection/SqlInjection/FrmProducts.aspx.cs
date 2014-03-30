using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Web;
using System.Text;
namespace SqlInjection
{
    public partial class FrmProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var pattern = @"^\d+$";

            var connString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

            var context = HttpContext.Current;
            var request = context.Request;
            var queryId = request["Categoria"];

           

            if (!String.IsNullOrEmpty(queryId))
            {

                var sqlStatement =
                    String.Format(
                        "SELECT [ProductName],[SupplierID],[CategoryID],[QuantityPerUnit],[UnitPrice]," +
                        "[UnitsInStock],[UnitsOnOrder],[Discontinued]" +
                        "FROM [NorthWind].[dbo].[Products] WHERE CategoryID = {0}",queryId);


                using (var conn = new SqlConnection(connString))
                {
                    using (var cmd = new SqlCommand(sqlStatement, conn))
                    {
                        conn.Open();
                        
                        this.dgProduct.DataSource = cmd.ExecuteReader();
                        this.dgProduct.DataBind();
                        this.Label1.Text = String.Format("Mostrando {0} productos", this.dgProduct.Rows.Count.ToString());
                    }
                }

            }
        }
    }
}