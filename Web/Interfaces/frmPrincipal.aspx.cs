using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace Web.Interfaces
{
    public partial class frmPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                

                Logica.Clases.Oficinas obclsOficinas = new Logica.Clases.Oficinas();
                DataSet dsConsulta = obclsOficinas.consultarGirosXOfi();

                if (dsConsulta.Tables[0].Rows.Count == 0) GridViewGirXOf.DataSource = null;
                else GridViewGirXOf.DataSource = dsConsulta;

                GridViewGirXOf.DataBind();
            }
            catch (Exception ex) { lblMensajeOf.Text = ex.Message; }
        }
        //CORRESPONSAL
        protected void btnConsultarCor_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeCor.Text = "";
                if (string.IsNullOrEmpty(txtIdCor.Text)) throw new Exception("Por favor ingrese el Id de la corresponsal");

                Logica.Clases.Corresponsales obclsCorresponsales = new Logica.Clases.Corresponsales();
                DataSet dsConsulta = obclsCorresponsales.consultar(Convert.ToInt64(txtIdCor.Text));

                if (dsConsulta.Tables[0].Rows.Count == 0) gvwDatos.DataSource = null;
                else gvwDatos.DataSource = dsConsulta;

                gvwDatos.DataBind();
            }
            catch (Exception ex) { lblMensajeCor.Text = ex.Message; }
        }

        protected void btnCrearCor_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeCor.Text = "";
                if (string.IsNullOrEmpty(txtIdCor.Text)) throw new Exception("Por favor ingrese el Id de la corresponsal");
                if (string.IsNullOrEmpty(txtNomCor.Text)) throw new Exception("Por favor ingrese el Nombre de la corresponsal");

                Logica.Clases.Corresponsales obclsCorresponsales = new Logica.Clases.Corresponsales();

                lblMensajeCor.Text = obclsCorresponsales.create(Convert.ToInt64(txtIdCor.Text),
                    txtNomCor.Text);
            }
            catch (Exception ex) { lblMensajeCor.Text = ex.Message; }
        }

        protected void btnModificarCor_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeCor.Text = "";
                if (string.IsNullOrEmpty(txtIdCor.Text)) throw new Exception("Por favor ingrese el Id de la corresponsal");
                if (string.IsNullOrEmpty(txtNomCor.Text)) throw new Exception("Por favor ingrese el Nombre de la corresponsal");

                Logica.Clases.Corresponsales obclsCorresponsales = new Logica.Clases.Corresponsales();

                lblMensajeCor.Text = obclsCorresponsales.actualizar(Convert.ToInt64(txtIdCor.Text),
                    txtNomCor.Text);
            }
            catch (Exception ex) { lblMensajeCor.Text = ex.Message; }
        }

        protected void btnEliminarCor_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeCor.Text = "";
                if (string.IsNullOrEmpty(txtIdCor.Text)) throw new Exception("Por favor ingrese el Id de la corresponsal");
                
                Logica.Clases.Corresponsales obclsCorresponsales = new Logica.Clases.Corresponsales();

                lblMensajeCor.Text = obclsCorresponsales.eliminar(Convert.ToInt64(txtIdCor.Text));
            }
            catch (Exception ex) { lblMensajeCor.Text = ex.Message; }
        }

        ///OFICINA
        protected void btnConsultarOf_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeOf.Text = "";
                if (string.IsNullOrEmpty(txtIdOf.Text)) throw new Exception("Por favor ingrese el Id de la oficina!");

                Logica.Clases.Oficinas obclsOficinas = new Logica.Clases.Oficinas();
                DataSet dsConsulta = obclsOficinas.consultar(Convert.ToInt64(txtIdOf.Text));

                if (dsConsulta.Tables[0].Rows.Count == 0) GridViewOf.DataSource = null;
                else GridViewOf.DataSource = dsConsulta;

                GridViewOf.DataBind();
            }
            catch (Exception ex) { lblMensajeOf.Text = ex.Message; }
        }

        protected void btnCrearOf_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeOf.Text = "";
                if (string.IsNullOrEmpty(txtIdOf.Text)) throw new Exception("Por favor ingrese la Id de la oficina!");
                if (string.IsNullOrEmpty(txtNomOf.Text)) throw new Exception("Por favor ingrese el nombre de la oficina!");
                if (string.IsNullOrEmpty(txtIdCorOf.Text)) throw new Exception("Por favor ingrese el Id de la corresponsal de la oficina!");

                Logica.Clases.Oficinas obclsOficinas = new Logica.Clases.Oficinas();

                lblMensajeOf.Text = obclsOficinas.create(
                    Convert.ToInt64(txtIdOf.Text),
                    txtNomOf.Text, 
                    Convert.ToInt64(txtIdCorOf.Text
                    ));
            }
            catch (Exception ex) { lblMensajeOf.Text = ex.Message; }
        }

        protected void btnModificarOf_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeOf.Text = "";
                if (string.IsNullOrEmpty(txtIdOf.Text)) throw new Exception("Por favor ingrese la Id de la oficina!");
                if (string.IsNullOrEmpty(txtNomOf.Text)) throw new Exception("Por favor ingrese el nombre de la oficina!");
                if (string.IsNullOrEmpty(txtIdCorOf.Text)) throw new Exception("Por favor ingrese el Id de la corresponsal de la oficina!");

                Logica.Clases.Oficinas obclsOficinas = new Logica.Clases.Oficinas();

                lblMensajeOf.Text = obclsOficinas.actualizar(Convert.ToInt64(txtIdOf.Text),
                    txtNomOf.Text,
                    Convert.ToInt64(txtIdCorOf.Text)
                    );
            }
            catch (Exception ex) { lblMensajeOf.Text = ex.Message; }
        }

        protected void btnEliminarOf_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeOf.Text = "";
                if (string.IsNullOrEmpty(txtIdOf.Text)) throw new Exception("Por favor ingrese la Id de la oficina!");

                Logica.Clases.Oficinas obclsCorresponsales = new Logica.Clases.Oficinas();

                lblMensajeOf.Text = obclsCorresponsales.eliminar(Convert.ToInt64(txtIdOf.Text));
            }
            catch (Exception ex) { lblMensajeOf.Text = ex.Message; }
        }
        ///GIROS
        protected void btnConsultarGir_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeGir.Text = "";
                if (string.IsNullOrEmpty(txtIdGir.Text)) throw new Exception("Por favor ingrese el Id de la giro!");

                Logica.Clases.Giros obclsGiros = new Logica.Clases.Giros();
                DataSet dsConsulta = obclsGiros.consultar(Convert.ToInt64(txtIdGir.Text));

                if (dsConsulta.Tables[0].Rows.Count == 0) GridViewGir.DataSource = null;
                else GridViewGir.DataSource = dsConsulta;

                GridViewGir.DataBind();
            }
            catch (Exception ex) { lblMensajeGir.Text = ex.Message; }
        }

        protected void btnCrearGir_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeGir.Text = "";
                if (string.IsNullOrEmpty(txtIdGir.Text)) throw new Exception("Por favor ingrese la Id del giro!");
                if (string.IsNullOrEmpty(txtNomGir.Text)) throw new Exception("Por favor ingrese el nombre del giro!");
                if (string.IsNullOrEmpty(txtIdOfGir.Text)) throw new Exception("Por favor ingrese el Id de la oficina del giro!");

                Logica.Clases.Giros obclsGiros = new Logica.Clases.Giros();

                lblMensajeGir.Text = obclsGiros.create(
                    Convert.ToInt64(txtIdGir.Text),
                    txtNomGir.Text,
                    Convert.ToInt64(txtIdOfGir.Text
                    ));
            }
            catch (Exception ex) { lblMensajeGir.Text = ex.Message; }
        }

        protected void btnModificarGir_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeGir.Text = "";
                if (string.IsNullOrEmpty(txtIdGir.Text)) throw new Exception("Por favor ingrese la Id del giro!");
                if (string.IsNullOrEmpty(txtNomGir.Text)) throw new Exception("Por favor ingrese el nombre del giro!");
                if (string.IsNullOrEmpty(txtIdOfGir.Text)) throw new Exception("Por favor ingrese el Id de la oficina del giro!");

                Logica.Clases.Giros obclsGiros = new Logica.Clases.Giros();

                lblMensajeGir.Text = obclsGiros.actualizar(
                    Convert.ToInt64(txtIdGir.Text),
                    txtNomGir.Text,
                    Convert.ToInt64(txtIdOfGir.Text)
                    );
            }
            catch (Exception ex) { lblMensajeGir.Text = ex.Message; }
        }

        protected void btnEliminarGir_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensajeGir.Text = "";
                if (string.IsNullOrEmpty(txtIdGir.Text)) throw new Exception("Por favor ingrese la Id del giro!");

                Logica.Clases.Giros obclsGiros = new Logica.Clases.Giros();

                lblMensajeGir.Text = obclsGiros.eliminar(Convert.ToInt64(txtIdGir.Text));
            }
            catch (Exception ex) { lblMensajeGir.Text = ex.Message; }
        }
    }
}