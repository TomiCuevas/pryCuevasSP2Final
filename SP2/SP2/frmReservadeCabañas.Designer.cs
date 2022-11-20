
namespace SP2
{
    partial class frmReservadeCabañas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservadeCabañas));
            this.grpTipoDeCabaña = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grpAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTelevisor = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.grpFormasDePago = new System.Windows.Forms.GroupBox();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.grpTitularDeLaReserva = new System.Windows.Forms.GroupBox();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpTipoDeCabaña.SuspendLayout();
            this.grpAdicionales.SuspendLayout();
            this.grpFormasDePago.SuspendLayout();
            this.grpTitularDeLaReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTipoDeCabaña
            // 
            this.grpTipoDeCabaña.Controls.Add(this.txtDias);
            this.grpTipoDeCabaña.Controls.Add(this.cmbPersonas);
            this.grpTipoDeCabaña.Controls.Add(this.cmbTipo);
            this.grpTipoDeCabaña.Controls.Add(this.lblDias);
            this.grpTipoDeCabaña.Controls.Add(this.lblPersonas);
            this.grpTipoDeCabaña.Controls.Add(this.lblTipo);
            this.grpTipoDeCabaña.Location = new System.Drawing.Point(13, 13);
            this.grpTipoDeCabaña.Margin = new System.Windows.Forms.Padding(4);
            this.grpTipoDeCabaña.Name = "grpTipoDeCabaña";
            this.grpTipoDeCabaña.Padding = new System.Windows.Forms.Padding(4);
            this.grpTipoDeCabaña.Size = new System.Drawing.Size(611, 95);
            this.grpTipoDeCabaña.TabIndex = 0;
            this.grpTipoDeCabaña.TabStop = false;
            this.grpTipoDeCabaña.Text = "Tipo de Cabaña";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(497, 36);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(77, 22);
            this.txtDias.TabIndex = 5;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(325, 36);
            this.cmbPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(85, 24);
            this.cmbPersonas.TabIndex = 4;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(73, 36);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(148, 24);
            this.cmbTipo.TabIndex = 3;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(449, 39);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(35, 16);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Días";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(249, 39);
            this.lblPersonas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(65, 16);
            this.lblPersonas.TabIndex = 1;
            this.lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(28, 39);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // grpAdicionales
            // 
            this.grpAdicionales.Controls.Add(this.chkTelevisor);
            this.grpAdicionales.Controls.Add(this.chkHeladera);
            this.grpAdicionales.Controls.Add(this.chkCocina);
            this.grpAdicionales.Location = new System.Drawing.Point(371, 116);
            this.grpAdicionales.Margin = new System.Windows.Forms.Padding(4);
            this.grpAdicionales.Name = "grpAdicionales";
            this.grpAdicionales.Padding = new System.Windows.Forms.Padding(4);
            this.grpAdicionales.Size = new System.Drawing.Size(205, 146);
            this.grpAdicionales.TabIndex = 1;
            this.grpAdicionales.TabStop = false;
            this.grpAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            this.chkTelevisor.AutoSize = true;
            this.chkTelevisor.Location = new System.Drawing.Point(32, 96);
            this.chkTelevisor.Margin = new System.Windows.Forms.Padding(4);
            this.chkTelevisor.Name = "chkTelevisor";
            this.chkTelevisor.Size = new System.Drawing.Size(86, 20);
            this.chkTelevisor.TabIndex = 2;
            this.chkTelevisor.Text = "&Televisor";
            this.chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(32, 66);
            this.chkHeladera.Margin = new System.Windows.Forms.Padding(4);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(86, 20);
            this.chkHeladera.TabIndex = 1;
            this.chkHeladera.Text = "&Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(32, 37);
            this.chkCocina.Margin = new System.Windows.Forms.Padding(4);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(71, 20);
            this.chkCocina.TabIndex = 0;
            this.chkCocina.Text = "&Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // grpFormasDePago
            // 
            this.grpFormasDePago.Controls.Add(this.cmbTarjeta);
            this.grpFormasDePago.Controls.Add(this.lblTarjetas);
            this.grpFormasDePago.Controls.Add(this.optTarjeta);
            this.grpFormasDePago.Controls.Add(this.optEfectivo);
            this.grpFormasDePago.Location = new System.Drawing.Point(13, 116);
            this.grpFormasDePago.Margin = new System.Windows.Forms.Padding(4);
            this.grpFormasDePago.Name = "grpFormasDePago";
            this.grpFormasDePago.Padding = new System.Windows.Forms.Padding(4);
            this.grpFormasDePago.Size = new System.Drawing.Size(346, 146);
            this.grpFormasDePago.TabIndex = 2;
            this.grpFormasDePago.TabStop = false;
            this.grpFormasDePago.Text = "Forma de Pago";
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(116, 94);
            this.cmbTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(219, 24);
            this.cmbTarjeta.TabIndex = 3;
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(113, 66);
            this.lblTarjetas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(57, 16);
            this.lblTarjetas.TabIndex = 2;
            this.lblTarjetas.Text = "Tarjetas";
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(25, 66);
            this.optTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(71, 20);
            this.optTarjeta.TabIndex = 1;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "&Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.optTarjeta_CheckedChanged);
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(25, 37);
            this.optEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(76, 20);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "&Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // grpTitularDeLaReserva
            // 
            this.grpTitularDeLaReserva.Controls.Add(this.txtTelefonos);
            this.grpTitularDeLaReserva.Controls.Add(this.txtNombre);
            this.grpTitularDeLaReserva.Controls.Add(this.lblTelefonos);
            this.grpTitularDeLaReserva.Controls.Add(this.lblNombre);
            this.grpTitularDeLaReserva.Location = new System.Drawing.Point(1, 362);
            this.grpTitularDeLaReserva.Margin = new System.Windows.Forms.Padding(4);
            this.grpTitularDeLaReserva.Name = "grpTitularDeLaReserva";
            this.grpTitularDeLaReserva.Padding = new System.Windows.Forms.Padding(4);
            this.grpTitularDeLaReserva.Size = new System.Drawing.Size(597, 143);
            this.grpTitularDeLaReserva.TabIndex = 3;
            this.grpTitularDeLaReserva.TabStop = false;
            this.grpTitularDeLaReserva.Text = "Titular de la Reserva";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(116, 84);
            this.txtTelefonos.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(459, 22);
            this.txtTelefonos.TabIndex = 3;
            this.txtTelefonos.TextChanged += new System.EventHandler(this.txtTelefonos_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 34);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(457, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTelefonos
            // 
            this.lblTelefonos.AutoSize = true;
            this.lblTelefonos.Location = new System.Drawing.Point(28, 87);
            this.lblTelefonos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonos.Name = "lblTelefonos";
            this.lblTelefonos.Size = new System.Drawing.Size(68, 16);
            this.lblTelefonos.TabIndex = 1;
            this.lblTelefonos.Text = "Teléfonos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 38);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(606, 464);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(144, 41);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmReservadeCabañas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::SP2.Properties.Resources.fondo_cabañas;
            this.ClientSize = new System.Drawing.Size(840, 518);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpFormasDePago);
            this.Controls.Add(this.grpAdicionales);
            this.Controls.Add(this.grpTipoDeCabaña);
            this.Controls.Add(this.grpTitularDeLaReserva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReservadeCabañas";
            this.Text = "Reservas de Cabañas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTipoDeCabaña.ResumeLayout(false);
            this.grpTipoDeCabaña.PerformLayout();
            this.grpAdicionales.ResumeLayout(false);
            this.grpAdicionales.PerformLayout();
            this.grpFormasDePago.ResumeLayout(false);
            this.grpFormasDePago.PerformLayout();
            this.grpTitularDeLaReserva.ResumeLayout(false);
            this.grpTitularDeLaReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipoDeCabaña;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox grpAdicionales;
        private System.Windows.Forms.CheckBox chkTelevisor;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.GroupBox grpFormasDePago;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.GroupBox grpTitularDeLaReserva;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
    }
}

