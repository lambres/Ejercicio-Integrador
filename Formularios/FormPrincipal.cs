using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormPrincipal : Form
    {

        /// <summary>
        /// Consutructor público que inicializa los componentes del formulario.
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento del boton click que realizar la apertura del formulario(registro de turnos)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Turno_Click(object sender, EventArgs e)
        {
            new FormRegistro().Show();
            this.Hide();
        }

        /// <summary>
        /// Evento del boton click que cierra la ejecución del programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Evento del boton click que realizar la apertura del formulario(lista de turnos)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_listaEspera_Click(object sender, EventArgs e)
        {
            new FormLista().Show();
            this.Hide();
        }

        /// <summary>
        /// Evento del timer tick que muestra la hora y actuliza a medida que va pasando el tiempo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tm_HoraFecha_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("f");
        }
    }
}
