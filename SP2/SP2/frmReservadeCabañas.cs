using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP2
{
    public partial class frmReservadeCabañas : Form
    {
        private const float TIPOA = 20;
        public const float TIPOB = 34;
        const float COCINA = 1;
        const float HELADERA = 1.5f;
        const float TELEVISOR = 2;
        const float PORPERSONA = 1;
        const float RECARGO_10 = 10;
        const float RECARGO_20 = 20;

        public frmReservadeCabañas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Tipo A");
            cmbTipo.Items.Add("Tipo B");
            cmbTipo.SelectedIndex = 0;

            txtDias.Text = "1";
           
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
     
            optEfectivo.Checked = true; 

            txtNombre.Text = "";
            txtTelefonos.Text = "";

            cmbTarjeta.Items.Clear();
            cmbTarjeta.Items.Add("Card Red");
            cmbTarjeta.Items.Add("Card Green");
            cmbTarjeta.Items.Add("Card Blue");


            btnAceptar.Enabled = false;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int I = 0;
            cmbPersonas.Items.Clear();

            
            if (cmbTipo.SelectedIndex == 0) 
            {
                for (I = 1; I <= 4; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            } 
            else 
            { 
                for (I = 1; I <= 8; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }
           
            cmbPersonas.SelectedIndex = 0;
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            
            cmbTarjeta.Enabled = false;
            cmbTarjeta.SelectedIndex = -1;
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            
            cmbTarjeta.Enabled = true;
            cmbTarjeta.SelectedIndex = 0;
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
     
            if (txtDias.Text != "" && txtDias.Text != "0" && 
                txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            } else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
            if (txtDias.Text != "" && txtDias.Text != "0" && 
                txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtTelefonos_TextChanged(object sender, EventArgs e)
        {
            
            if (txtDias.Text != "" && txtDias.Text != "0" && 
                txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float PrecioBase;
            float Opcionales;
            float Recargo;
            int Dias;
            float Total;
            
            Dias = int.Parse(txtDias.Text);
      
            if (cmbTipo.SelectedIndex == 0)
            {
                PrecioBase = TIPOA;
            } else
            {
                PrecioBase = TIPOB;
            }
        
            PrecioBase = PrecioBase + (PORPERSONA * int.Parse(cmbPersonas.Text));
            
            Opcionales = 0;
            if (chkCocina.Checked == true)
            {
                Opcionales = Opcionales + COCINA;
            }
            if (chkHeladera.Checked == true)
            {
                Opcionales = Opcionales + HELADERA;
            }
            if (chkTelevisor.Checked == true)
            {
                Opcionales = Opcionales + TELEVISOR;
            }
           
            Total = (PrecioBase + Opcionales) * Dias;

            
            if (optTarjeta.Checked == true)
            {
                
                if (cmbTarjeta.SelectedIndex == 0)
                {
                    Recargo = Total * RECARGO_10 / 100; 
                } else {
                    Recargo = Total * RECARGO_20 / 100; 
                }
                Total = Total + Recargo; 
            }

            MessageBox.Show("Total = US$ " + Total.ToString(), "Importe de la reserva",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbTipo.SelectedIndex = 0;
            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            optEfectivo.Checked = true; 
            txtNombre.Text = "";
            txtTelefonos.Text = "";
        }

    }
}
