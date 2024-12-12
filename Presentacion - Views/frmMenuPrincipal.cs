using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapasPresentacion_Henry_Alvarez.Presentacion___Views
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autores.frmAutores frmAutores = new Autores.frmAutores();
            frmAutores.ShowDialog();
        }

        private void btnAutorTitulo_Click(object sender, EventArgs e)
        {
            AutorDelTitulo.frmAutorDelTitulo frmautoresti = new AutorDelTitulo.frmAutorDelTitulo();
            frmautoresti.ShowDialog();
        }

        private void bntDescuentos_Click(object sender, EventArgs e)
        {
            Descuentos.frmDescuentos frmdescuento = new Descuentos.frmDescuentos();
            frmdescuento.ShowDialog();
        }

        private void bntEmployee_Click(object sender, EventArgs e)
        {
            Employee.frmEmployee frmemployee = new Employee.frmEmployee();
            frmemployee.ShowDialog();
        }

        private void bntJobs_Click(object sender, EventArgs e)
        {
            Jobs.frmJobs frmemjobs = new Jobs.frmJobs();
            frmemjobs.ShowDialog();
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            Publishers.frmPublishers frmpublishers = new Publishers.frmPublishers();
            frmpublishers.ShowDialog();
        }

        private void btnPublishersInf_Click(object sender, EventArgs e)
        {
            PublishersInfo.frmPublishersInfo frmpublishersinfo = new PublishersInfo.frmPublishersInfo();
            frmpublishersinfo.ShowDialog();
        }

        private void btnRoysched_Click(object sender, EventArgs e)
        {
            Roysched.frmRoysched frmroysched = new Roysched.frmRoysched();
            frmroysched.ShowDialog();
        }

        private void btnStores_Click(object sender, EventArgs e)
        {
            Stores.frmStores frmstores = new Stores.frmStores();
            frmstores.ShowDialog();
        }

        private void bntTitulos_Click(object sender, EventArgs e)
        {
            Titulos.frmTitulos frmtitulos = new Titulos.frmTitulos();
            frmtitulos.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas.frmVentas frmventas = new Ventas.frmVentas();
            frmventas.ShowDialog();
        }
    }
}
