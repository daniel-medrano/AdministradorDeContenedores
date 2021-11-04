
namespace AdministradorDeContenedores
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cantidadJWTextBox = new System.Windows.Forms.TextBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.labelContenedorXGrande = new System.Windows.Forms.Label();
            this.labelContenedorGrande = new System.Windows.Forms.Label();
            this.labelContenedorMediano = new System.Windows.Forms.Label();
            this.labelContenedorPequeño = new System.Windows.Forms.Label();
            this.labelXGrande = new System.Windows.Forms.Label();
            this.labelGrande = new System.Windows.Forms.Label();
            this.labelPequeño = new System.Windows.Forms.Label();
            this.labelMediano = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLugares = new System.Windows.Forms.ComboBox();
            this.labelCostoTotal = new System.Windows.Forms.Label();
            this.labelCostoJWs = new System.Windows.Forms.Label();
            this.labelCostoTransporte = new System.Windows.Forms.Label();
            this.labelCostoEmpaque = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de JW:";
            // 
            // cantidadJWTextBox
            // 
            this.cantidadJWTextBox.Location = new System.Drawing.Point(111, 37);
            this.cantidadJWTextBox.Name = "cantidadJWTextBox";
            this.cantidadJWTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadJWTextBox.TabIndex = 1;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(136, 105);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // labelContenedorXGrande
            // 
            this.labelContenedorXGrande.AutoSize = true;
            this.labelContenedorXGrande.Location = new System.Drawing.Point(153, 144);
            this.labelContenedorXGrande.Name = "labelContenedorXGrande";
            this.labelContenedorXGrande.Size = new System.Drawing.Size(0, 13);
            this.labelContenedorXGrande.TabIndex = 3;
            // 
            // labelContenedorGrande
            // 
            this.labelContenedorGrande.AutoSize = true;
            this.labelContenedorGrande.Location = new System.Drawing.Point(153, 169);
            this.labelContenedorGrande.Name = "labelContenedorGrande";
            this.labelContenedorGrande.Size = new System.Drawing.Size(0, 13);
            this.labelContenedorGrande.TabIndex = 4;
            // 
            // labelContenedorMediano
            // 
            this.labelContenedorMediano.AutoSize = true;
            this.labelContenedorMediano.Location = new System.Drawing.Point(153, 197);
            this.labelContenedorMediano.Name = "labelContenedorMediano";
            this.labelContenedorMediano.Size = new System.Drawing.Size(0, 13);
            this.labelContenedorMediano.TabIndex = 5;
            // 
            // labelContenedorPequeño
            // 
            this.labelContenedorPequeño.AutoSize = true;
            this.labelContenedorPequeño.Location = new System.Drawing.Point(153, 222);
            this.labelContenedorPequeño.Name = "labelContenedorPequeño";
            this.labelContenedorPequeño.Size = new System.Drawing.Size(0, 13);
            this.labelContenedorPequeño.TabIndex = 6;
            // 
            // labelXGrande
            // 
            this.labelXGrande.AutoSize = true;
            this.labelXGrande.Location = new System.Drawing.Point(22, 144);
            this.labelXGrande.Name = "labelXGrande";
            this.labelXGrande.Size = new System.Drawing.Size(125, 13);
            this.labelXGrande.TabIndex = 7;
            this.labelXGrande.Text = "Contenedor Extragrande:";
            // 
            // labelGrande
            // 
            this.labelGrande.AutoSize = true;
            this.labelGrande.Location = new System.Drawing.Point(22, 169);
            this.labelGrande.Name = "labelGrande";
            this.labelGrande.Size = new System.Drawing.Size(103, 13);
            this.labelGrande.TabIndex = 8;
            this.labelGrande.Text = "Contenedor Grande:";
            // 
            // labelPequeño
            // 
            this.labelPequeño.AutoSize = true;
            this.labelPequeño.Location = new System.Drawing.Point(22, 222);
            this.labelPequeño.Name = "labelPequeño";
            this.labelPequeño.Size = new System.Drawing.Size(111, 13);
            this.labelPequeño.TabIndex = 10;
            this.labelPequeño.Text = "Contenedor Pequeño:";
            // 
            // labelMediano
            // 
            this.labelMediano.AutoSize = true;
            this.labelMediano.Location = new System.Drawing.Point(22, 197);
            this.labelMediano.Name = "labelMediano";
            this.labelMediano.Size = new System.Drawing.Size(109, 13);
            this.labelMediano.TabIndex = 9;
            this.labelMediano.Text = "Contenedor Mediano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Costo Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Costo Total de JWs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Costo de Transporte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Costo de Empaque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enviar al:";
            // 
            // comboBoxLugares
            // 
            this.comboBoxLugares.FormattingEnabled = true;
            this.comboBoxLugares.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxLugares.Items.AddRange(new object[] {
            "Central",
            "Sur",
            "Norte",
            "Pacífico",
            "Atlántico"});
            this.comboBoxLugares.Location = new System.Drawing.Point(111, 69);
            this.comboBoxLugares.Name = "comboBoxLugares";
            this.comboBoxLugares.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLugares.TabIndex = 16;
            // 
            // labelCostoTotal
            // 
            this.labelCostoTotal.AutoSize = true;
            this.labelCostoTotal.Location = new System.Drawing.Point(153, 335);
            this.labelCostoTotal.Name = "labelCostoTotal";
            this.labelCostoTotal.Size = new System.Drawing.Size(0, 13);
            this.labelCostoTotal.TabIndex = 20;
            // 
            // labelCostoJWs
            // 
            this.labelCostoJWs.AutoSize = true;
            this.labelCostoJWs.Location = new System.Drawing.Point(153, 310);
            this.labelCostoJWs.Name = "labelCostoJWs";
            this.labelCostoJWs.Size = new System.Drawing.Size(0, 13);
            this.labelCostoJWs.TabIndex = 19;
            // 
            // labelCostoTransporte
            // 
            this.labelCostoTransporte.AutoSize = true;
            this.labelCostoTransporte.Location = new System.Drawing.Point(153, 282);
            this.labelCostoTransporte.Name = "labelCostoTransporte";
            this.labelCostoTransporte.Size = new System.Drawing.Size(0, 13);
            this.labelCostoTransporte.TabIndex = 18;
            // 
            // labelCostoEmpaque
            // 
            this.labelCostoEmpaque.AutoSize = true;
            this.labelCostoEmpaque.Location = new System.Drawing.Point(153, 257);
            this.labelCostoEmpaque.Name = "labelCostoEmpaque";
            this.labelCostoEmpaque.Size = new System.Drawing.Size(0, 13);
            this.labelCostoEmpaque.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 366);
            this.Controls.Add(this.labelCostoTotal);
            this.Controls.Add(this.labelCostoJWs);
            this.Controls.Add(this.labelCostoTransporte);
            this.Controls.Add(this.labelCostoEmpaque);
            this.Controls.Add(this.comboBoxLugares);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPequeño);
            this.Controls.Add(this.labelMediano);
            this.Controls.Add(this.labelGrande);
            this.Controls.Add(this.labelXGrande);
            this.Controls.Add(this.labelContenedorPequeño);
            this.Controls.Add(this.labelContenedorMediano);
            this.Controls.Add(this.labelContenedorGrande);
            this.Controls.Add(this.labelContenedorXGrande);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.cantidadJWTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(249, 405);
            this.MinimumSize = new System.Drawing.Size(249, 405);
            this.Name = "Form1";
            this.Text = "Calculador De Costos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantidadJWTextBox;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Label labelContenedorXGrande;
        private System.Windows.Forms.Label labelContenedorGrande;
        private System.Windows.Forms.Label labelContenedorMediano;
        private System.Windows.Forms.Label labelContenedorPequeño;
        private System.Windows.Forms.Label labelXGrande;
        private System.Windows.Forms.Label labelGrande;
        private System.Windows.Forms.Label labelPequeño;
        private System.Windows.Forms.Label labelMediano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxLugares;
        private System.Windows.Forms.Label labelCostoTotal;
        private System.Windows.Forms.Label labelCostoJWs;
        private System.Windows.Forms.Label labelCostoTransporte;
        private System.Windows.Forms.Label labelCostoEmpaque;
    }
}

