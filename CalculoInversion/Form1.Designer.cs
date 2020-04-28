namespace CalculoInversion
{
    partial class Form1
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
            this.labelDeposito = new System.Windows.Forms.Label();
            this.textBoxDeposito = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelDividendo = new System.Windows.Forms.Label();
            this.textBoxDividendo = new System.Windows.Forms.TextBox();
            this.labelNumAcciones = new System.Windows.Forms.Label();
            this.labelDividendoTotal = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelInversionTotal = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelCustodia = new System.Windows.Forms.Label();
            this.labelIngresoAnual = new System.Windows.Forms.Label();
            this.textBoxCustodia = new System.Windows.Forms.TextBox();
            this.checkBoxInternacional = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelDeposito
            // 
            this.labelDeposito.AutoSize = true;
            this.labelDeposito.Location = new System.Drawing.Point(29, 27);
            this.labelDeposito.Name = "labelDeposito";
            this.labelDeposito.Size = new System.Drawing.Size(49, 13);
            this.labelDeposito.TabIndex = 0;
            this.labelDeposito.Text = "Depósito";
            // 
            // textBoxDeposito
            // 
            this.textBoxDeposito.Location = new System.Drawing.Point(125, 24);
            this.textBoxDeposito.Name = "textBoxDeposito";
            this.textBoxDeposito.Size = new System.Drawing.Size(180, 20);
            this.textBoxDeposito.TabIndex = 1;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(125, 74);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(180, 20);
            this.textBoxPrecio.TabIndex = 2;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(29, 77);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(90, 13);
            this.labelPrecio.TabIndex = 3;
            this.labelPrecio.Text = "Precio por acción";
            // 
            // labelDividendo
            // 
            this.labelDividendo.AutoSize = true;
            this.labelDividendo.Location = new System.Drawing.Point(29, 126);
            this.labelDividendo.Name = "labelDividendo";
            this.labelDividendo.Size = new System.Drawing.Size(47, 13);
            this.labelDividendo.TabIndex = 4;
            this.labelDividendo.Text = "Divendo";
            // 
            // textBoxDividendo
            // 
            this.textBoxDividendo.Location = new System.Drawing.Point(125, 123);
            this.textBoxDividendo.Name = "textBoxDividendo";
            this.textBoxDividendo.Size = new System.Drawing.Size(180, 20);
            this.textBoxDividendo.TabIndex = 5;
            // 
            // labelNumAcciones
            // 
            this.labelNumAcciones.AutoSize = true;
            this.labelNumAcciones.Location = new System.Drawing.Point(29, 234);
            this.labelNumAcciones.Name = "labelNumAcciones";
            this.labelNumAcciones.Size = new System.Drawing.Size(163, 13);
            this.labelNumAcciones.TabIndex = 6;
            this.labelNumAcciones.Text = "Número de acciones compradas:";
            // 
            // labelDividendoTotal
            // 
            this.labelDividendoTotal.AutoSize = true;
            this.labelDividendoTotal.Location = new System.Drawing.Point(29, 265);
            this.labelDividendoTotal.Name = "labelDividendoTotal";
            this.labelDividendoTotal.Size = new System.Drawing.Size(81, 13);
            this.labelDividendoTotal.TabIndex = 7;
            this.labelDividendoTotal.Text = "Dividendo total:";
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Location = new System.Drawing.Point(29, 338);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(173, 13);
            this.labelTiempo.TabIndex = 8;
            this.labelTiempo.Text = "Tiempo para recuperar la inversión:";
            // 
            // labelInversionTotal
            // 
            this.labelInversionTotal.AutoSize = true;
            this.labelInversionTotal.Location = new System.Drawing.Point(29, 371);
            this.labelInversionTotal.Name = "labelInversionTotal";
            this.labelInversionTotal.Size = new System.Drawing.Size(79, 13);
            this.labelInversionTotal.TabIndex = 9;
            this.labelInversionTotal.Text = "Inversión total: ";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(107, 421);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 10;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelCustodia
            // 
            this.labelCustodia.AutoSize = true;
            this.labelCustodia.Location = new System.Drawing.Point(29, 164);
            this.labelCustodia.Name = "labelCustodia";
            this.labelCustodia.Size = new System.Drawing.Size(48, 13);
            this.labelCustodia.TabIndex = 11;
            this.labelCustodia.Text = "Custodia";
            // 
            // labelIngresoAnual
            // 
            this.labelIngresoAnual.AutoSize = true;
            this.labelIngresoAnual.Location = new System.Drawing.Point(29, 300);
            this.labelIngresoAnual.Name = "labelIngresoAnual";
            this.labelIngresoAnual.Size = new System.Drawing.Size(90, 13);
            this.labelIngresoAnual.TabIndex = 12;
            this.labelIngresoAnual.Text = "Ingresos anuales:";
            // 
            // textBoxCustodia
            // 
            this.textBoxCustodia.Location = new System.Drawing.Point(125, 161);
            this.textBoxCustodia.Name = "textBoxCustodia";
            this.textBoxCustodia.Size = new System.Drawing.Size(180, 20);
            this.textBoxCustodia.TabIndex = 13;
            // 
            // checkBoxInternacional
            // 
            this.checkBoxInternacional.AutoSize = true;
            this.checkBoxInternacional.Location = new System.Drawing.Point(32, 203);
            this.checkBoxInternacional.Name = "checkBoxInternacional";
            this.checkBoxInternacional.Size = new System.Drawing.Size(87, 17);
            this.checkBoxInternacional.TabIndex = 14;
            this.checkBoxInternacional.Text = "Internacional";
            this.checkBoxInternacional.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 471);
            this.Controls.Add(this.checkBoxInternacional);
            this.Controls.Add(this.textBoxCustodia);
            this.Controls.Add(this.labelIngresoAnual);
            this.Controls.Add(this.labelCustodia);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelInversionTotal);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.labelDividendoTotal);
            this.Controls.Add(this.labelNumAcciones);
            this.Controls.Add(this.textBoxDividendo);
            this.Controls.Add(this.labelDividendo);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxDeposito);
            this.Controls.Add(this.labelDeposito);
            this.Name = "Form1";
            this.Text = "Datos de inversión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeposito;
        private System.Windows.Forms.TextBox textBoxDeposito;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDividendo;
        private System.Windows.Forms.TextBox textBoxDividendo;
        private System.Windows.Forms.Label labelNumAcciones;
        private System.Windows.Forms.Label labelDividendoTotal;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelInversionTotal;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelCustodia;
        private System.Windows.Forms.Label labelIngresoAnual;
        private System.Windows.Forms.TextBox textBoxCustodia;
        private System.Windows.Forms.CheckBox checkBoxInternacional;
    }
}

