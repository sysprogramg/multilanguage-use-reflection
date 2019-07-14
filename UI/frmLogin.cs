using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CultureResources;

namespace UI
{
    public partial class frmLogin : Form
    {
        #region Idioma
        private void AplicarIdioma()
        {
            try
            {
                // Recorro los controles para cambiar el idioma
                // En aquellos elementos que los textos deben ser en mayusculas se establece la propiedad tag = upper
                foreach (Control ctrl in Controls)
                {
                    string value = Idioma.getInstance.GetValueProperty(ctrl.Name.Substring(3));
                    if (string.IsNullOrEmpty(value)) continue;
                    if (ctrl is Label || ctrl is Button)
                        ctrl.Text = ctrl.Tag != null ? ctrl.Tag.ToString() == "upper" ? value.ToUpper() : value : value;
                }
            }
            catch (Exception ex)
            {
                // Formulario creado para mostar el error ocurrido
                using (frmError frm = new frmError(ex.Message, Idioma.getInstance.ErrorInesperado))
                    frm.ShowDialog(this);
            }

            // Cambia a Bold el label correspondiente al idioma actual
            foreach (Label lbl in (from c in panelIdioma.Controls.OfType<Label>()
                                   where !string.IsNullOrEmpty(c.Tag.ToString())
                                   select c))
                    lbl.Font = new Font("Microsoft Sans Serif", 8,
                        (lbl.Tag.ToString() == Thread.CurrentThread.CurrentUICulture.Name.ToUpper()) ? FontStyle.Bold 
                        : FontStyle.Regular);
        }

        /// <summary>
        /// Metodo invocado en el click del label del idioma seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambiarIdioma(object sender, EventArgs e)
        {
            try
            {
                string newCultureInfo = ((Label)sender).Tag.ToString();
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(newCultureInfo);
                AplicarIdioma();
                txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                using (frmError frm = new frmError(ex.Message, Idioma.getInstance.ErrorInesperado))
                    frm.ShowDialog(this);
            }
        }

        #endregion

        public frmLogin()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ES-AR");
            AplicarIdioma();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            picError.Visible = true;
            lblErrorLogin.Visible = true;
        }
    }
}
