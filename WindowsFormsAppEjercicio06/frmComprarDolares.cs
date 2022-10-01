using System;
using System.Windows.Forms;

namespace WindowsFormsAppEjercicio06
{
    public partial class frmComprarDolares : Form
    {
        public frmComprarDolares()
        {
            InitializeComponent();
        }
        private decimal cantidadDolares;
        private decimal cotizacionDolares;

        private decimal totalCostoDolares;
        private decimal totalImpuestoPais;
        private decimal totalRecargoGanancias;
        private decimal totalPagar;

        const float porcImpuestoPais = 0.30f;
        const float porcRecargoGanancias = 0.30f;

        private decimal stockDolares = 50000;


        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //Calculos
                totalCostoDolares = cantidadDolares * cotizacionDolares;
                totalImpuestoPais = totalCostoDolares * (decimal)porcImpuestoPais;
                totalRecargoGanancias = totalCostoDolares * (decimal)porcRecargoGanancias;
                totalPagar = totalCostoDolares + totalImpuestoPais + totalRecargoGanancias;
                //Mostrar la información

                //Creo la fila sin division
                DataGridViewRow r = ConstruirFila();
                ////Creo las celdas
                //r.CreateCells(datosDataGridView);
                //Pongo contenido en cada celda
                SetearFila(r, "Costo Dólares", totalCostoDolares);
                //r.Cells[colDescripcion.Index].Value = "Costo Dólares";
                //r.Cells[colImporte.Index].Value = totalCostoDolares;

                //agrego la fila a la grilla
                AgregarFila(r);
                //datosDataGridView.Rows.Add(r);
                var r2 = ConstruirFila();
                SetearFila(r2, "Impuesto PAIS", totalImpuestoPais);
                AgregarFila(r2);
                var r3 = ConstruirFila();
                SetearFila(r3, "Recargo Ganancias", totalRecargoGanancias);
                AgregarFila(r3);
                var r4 = ConstruirFila();
                SetearFila(r4, "Total a Pagar", totalPagar);
                AgregarFila(r4);
                stockDolares -= cantidadDolares;
                dolaresTextBox.Text = stockDolares.ToString();

                InicializarControles();
            }
        }

        private void InicializarControles()
        {
            cantidadTextBox.Clear();
            cotizacionTextBox.Clear();
        }

        private void AgregarFila(DataGridViewRow r)
        {
            datosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, string desc, decimal imp)
        {
            r.Cells[colDescripcion.Index].Value = desc;
            r.Cells[colImporte.Index].Value = imp.ToString("C2");
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(datosDataGridView);
            return r;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!decimal.TryParse(cantidadTextBox.Text, out cantidadDolares))
            {
                valido = false;
                errorProvider1.SetError(cantidadTextBox, "Cantidad no válida");
            }
            else if (cantidadDolares <= 0 || cantidadDolares > 200)
            {
                valido = false;
                errorProvider1.SetError(cantidadTextBox, "La cantidad debe estar entre 1 y 200");
            }
            if (!decimal.TryParse(cotizacionTextBox.Text, out cotizacionDolares))
            {
                valido = false;
                errorProvider1.SetError(cotizacionTextBox, "Cotización no válida");
            }
            else if (cotizacionDolares <= 0 || cotizacionDolares > int.MaxValue)
            {
                valido = false;
                errorProvider1.SetError(cantidadTextBox, "La cotización debe ser positiva");
            }
            return valido;

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            InicializarControles();
            cantidadTextBox.Focus();
        }

        private void frmComprarDolares_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir del programa?", "Confirmar Salida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;//suspendo el cierre del formulario
            }
        }

        private void otraCompraButton_Click(object sender, EventArgs e)
        {
            datosDataGridView.Rows.Clear();
            cantidadTextBox.Focus();
        }

        private void frmComprarDolares_Load(object sender, EventArgs e)
        {
            dolaresTextBox.Text = 50000.ToString();
            dolaresTextBox.Enabled = false;
        }

    }
}
