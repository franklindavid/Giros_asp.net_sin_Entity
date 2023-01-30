using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Web.Interfaces
{
    public partial class frmGirosOf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string OFI_OFICINA_ID = Request.QueryString["OFI_OFICINA_ID"];
            try
            {
                Logica.Clases.Giros obclsOficinas = new Logica.Clases.Giros();
                DataSet dsConsulta = obclsOficinas.consultarOficinaGiro(OFI_OFICINA_ID);              

                if (dsConsulta.Tables[0].Rows.Count == 0) GridViewGirXOf.DataSource = null;
                else GridViewGirXOf.DataSource = dsConsulta;
                GridViewGirXOf.DataBind();
            }
            catch (Exception ex) { lblMensajeGir.Text = ex.Message; }
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int n = Convert.ToInt32(e.Row.Cells[3].Text);
                int sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }

                e.Row.Cells[3].Text = sum.ToString();
            }
        }
    }

}