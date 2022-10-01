
namespace WindowsFormsAppEjercicio06
{
    partial class frmComprarDolares
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cotizacionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dolaresTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.datosDataGridView = new System.Windows.Forms.DataGridView();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otraCompraButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de dólares:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(232, 35);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(113, 20);
            this.cantidadTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese la  cotización oficial del dólar:";
            // 
            // cotizacionTextBox
            // 
            this.cotizacionTextBox.Location = new System.Drawing.Point(232, 70);
            this.cotizacionTextBox.Name = "cotizacionTextBox";
            this.cotizacionTextBox.Size = new System.Drawing.Size(113, 20);
            this.cotizacionTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dólares en Caja:";
            // 
            // dolaresTextBox
            // 
            this.dolaresTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dolaresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolaresTextBox.Location = new System.Drawing.Point(232, 105);
            this.dolaresTextBox.Name = "dolaresTextBox";
            this.dolaresTextBox.Size = new System.Drawing.Size(113, 23);
            this.dolaresTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Image = global::WindowsFormsAppEjercicio06.Properties.Resources.ok_36px;
            this.OkButton.Location = new System.Drawing.Point(46, 151);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(96, 74);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Image = global::WindowsFormsAppEjercicio06.Properties.Resources.cancel_36px;
            this.cancelarButton.Location = new System.Drawing.Point(249, 151);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(96, 74);
            this.cancelarButton.TabIndex = 3;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // datosDataGridView
            // 
            this.datosDataGridView.AllowUserToAddRows = false;
            this.datosDataGridView.AllowUserToDeleteRows = false;
            this.datosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDescripcion,
            this.colImporte});
            this.datosDataGridView.Location = new System.Drawing.Point(46, 242);
            this.datosDataGridView.Name = "datosDataGridView";
            this.datosDataGridView.ReadOnly = true;
            this.datosDataGridView.Size = new System.Drawing.Size(299, 150);
            this.datosDataGridView.TabIndex = 3;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colImporte
            // 
            this.colImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            this.colImporte.Width = 67;
            // 
            // otraCompraButton
            // 
            this.otraCompraButton.Image = global::WindowsFormsAppEjercicio06.Properties.Resources.money_20px;
            this.otraCompraButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.otraCompraButton.Location = new System.Drawing.Point(232, 403);
            this.otraCompraButton.Name = "otraCompraButton";
            this.otraCompraButton.Size = new System.Drawing.Size(113, 47);
            this.otraCompraButton.TabIndex = 4;
            this.otraCompraButton.Text = "Otra compra";
            this.otraCompraButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.otraCompraButton.UseVisualStyleBackColor = true;
            this.otraCompraButton.Click += new System.EventHandler(this.otraCompraButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmComprarDolares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.otraCompraButton);
            this.Controls.Add(this.datosDataGridView);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.dolaresTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cotizacionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 489);
            this.Name = "frmComprarDolares";
            this.Text = "frmComprarDolares";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmComprarDolares_FormClosing);
            this.Load += new System.EventHandler(this.frmComprarDolares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cotizacionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dolaresTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.DataGridView datosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.Button otraCompraButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}