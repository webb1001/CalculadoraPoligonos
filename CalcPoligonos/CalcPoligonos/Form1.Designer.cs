namespace CalcPoligonos
{
    partial class CalculadoraPoligonos
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
            this.titulo = new System.Windows.Forms.Label();
            this.botonPerimetro = new System.Windows.Forms.Button();
            this.botonArea = new System.Windows.Forms.Button();
            this.poligonosTabControl1 = new System.Windows.Forms.TabControl();
            this.poligonosTabControl = new System.Windows.Forms.TabPage();
            this.trianguloLado3TextBox = new System.Windows.Forms.TextBox();
            this.trianguloLado2TextBox = new System.Windows.Forms.TextBox();
            this.trianguloLado3 = new System.Windows.Forms.Label();
            this.trianguloLado2 = new System.Windows.Forms.Label();
            this.trianguloLado1TextBox = new System.Windows.Forms.TextBox();
            this.trianguloAlturaTextBox = new System.Windows.Forms.TextBox();
            this.trianguloAltura = new System.Windows.Forms.Label();
            this.trianguloLado1 = new System.Windows.Forms.Label();
            this.cuadradoTabPage = new System.Windows.Forms.TabPage();
            this.cuadradoLadoTextBox = new System.Windows.Forms.TextBox();
            this.cuadradoLado = new System.Windows.Forms.Label();
            this.circuloTabPage = new System.Windows.Forms.TabPage();
            this.circuloRadioTextBox = new System.Windows.Forms.TextBox();
            this.circuloRadio = new System.Windows.Forms.Label();
            this.rectanguloTabPage = new System.Windows.Forms.TabPage();
            this.rectanguloAnchoTextBox = new System.Windows.Forms.TextBox();
            this.rectanguloAltoTextBox = new System.Windows.Forms.TextBox();
            this.rectanguloAncho = new System.Windows.Forms.Label();
            this.rectanguloAlto = new System.Windows.Forms.Label();
            this.pentagonoTabPage = new System.Windows.Forms.TabPage();
            this.pentagonoApotemaTextBox = new System.Windows.Forms.TextBox();
            this.pentagonoLadoTextBox = new System.Windows.Forms.TextBox();
            this.pentagonoApotema = new System.Windows.Forms.Label();
            this.pentagonoLado = new System.Windows.Forms.Label();
            this.poligonosTabControl1.SuspendLayout();
            this.poligonosTabControl.SuspendLayout();
            this.cuadradoTabPage.SuspendLayout();
            this.circuloTabPage.SuspendLayout();
            this.rectanguloTabPage.SuspendLayout();
            this.pentagonoTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(121, 48);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(259, 25);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Calculadora de Poligonos";
            // 
            // botonPerimetro
            // 
            this.botonPerimetro.Location = new System.Drawing.Point(253, 334);
            this.botonPerimetro.Name = "botonPerimetro";
            this.botonPerimetro.Size = new System.Drawing.Size(117, 23);
            this.botonPerimetro.TabIndex = 1;
            this.botonPerimetro.Text = "Calcular Perimetro";
            this.botonPerimetro.UseVisualStyleBackColor = true;
            this.botonPerimetro.Click += new System.EventHandler(this.botonPerimetro_Click);
            // 
            // botonArea
            // 
            this.botonArea.Location = new System.Drawing.Point(391, 334);
            this.botonArea.Name = "botonArea";
            this.botonArea.Size = new System.Drawing.Size(96, 23);
            this.botonArea.TabIndex = 2;
            this.botonArea.Text = "Calcular Area";
            this.botonArea.UseVisualStyleBackColor = true;
            this.botonArea.Click += new System.EventHandler(this.botonArea_Click);
            // 
            // poligonosTabControl1
            // 
            this.poligonosTabControl1.Controls.Add(this.poligonosTabControl);
            this.poligonosTabControl1.Controls.Add(this.cuadradoTabPage);
            this.poligonosTabControl1.Controls.Add(this.circuloTabPage);
            this.poligonosTabControl1.Controls.Add(this.rectanguloTabPage);
            this.poligonosTabControl1.Controls.Add(this.pentagonoTabPage);
            this.poligonosTabControl1.Location = new System.Drawing.Point(12, 86);
            this.poligonosTabControl1.Name = "poligonosTabControl1";
            this.poligonosTabControl1.SelectedIndex = 0;
            this.poligonosTabControl1.Size = new System.Drawing.Size(479, 246);
            this.poligonosTabControl1.TabIndex = 3;
            this.poligonosTabControl1.SelectedIndexChanged += new System.EventHandler(this.poligonosTabControl1_SelectedIndexChanged);
            // 
            // poligonosTabControl
            // 
            this.poligonosTabControl.Controls.Add(this.trianguloLado3TextBox);
            this.poligonosTabControl.Controls.Add(this.trianguloLado2TextBox);
            this.poligonosTabControl.Controls.Add(this.trianguloLado3);
            this.poligonosTabControl.Controls.Add(this.trianguloLado2);
            this.poligonosTabControl.Controls.Add(this.trianguloLado1TextBox);
            this.poligonosTabControl.Controls.Add(this.trianguloAlturaTextBox);
            this.poligonosTabControl.Controls.Add(this.trianguloAltura);
            this.poligonosTabControl.Controls.Add(this.trianguloLado1);
            this.poligonosTabControl.Location = new System.Drawing.Point(4, 22);
            this.poligonosTabControl.Name = "poligonosTabControl";
            this.poligonosTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.poligonosTabControl.Size = new System.Drawing.Size(471, 220);
            this.poligonosTabControl.TabIndex = 0;
            this.poligonosTabControl.Text = "Triangulo";
            this.poligonosTabControl.UseVisualStyleBackColor = true;
            // 
            // trianguloLado3TextBox
            // 
            this.trianguloLado3TextBox.Location = new System.Drawing.Point(89, 68);
            this.trianguloLado3TextBox.Name = "trianguloLado3TextBox";
            this.trianguloLado3TextBox.Size = new System.Drawing.Size(100, 20);
            this.trianguloLado3TextBox.TabIndex = 9;
            this.trianguloLado3TextBox.Leave += new System.EventHandler(this.trianguloLado3TextBox_Leave);
            // 
            // trianguloLado2TextBox
            // 
            this.trianguloLado2TextBox.Location = new System.Drawing.Point(89, 42);
            this.trianguloLado2TextBox.Name = "trianguloLado2TextBox";
            this.trianguloLado2TextBox.Size = new System.Drawing.Size(100, 20);
            this.trianguloLado2TextBox.TabIndex = 8;
            this.trianguloLado2TextBox.Leave += new System.EventHandler(this.trianguloLado2TextBox_Leave);
            // 
            // trianguloLado3
            // 
            this.trianguloLado3.AutoSize = true;
            this.trianguloLado3.Location = new System.Drawing.Point(46, 71);
            this.trianguloLado3.Name = "trianguloLado3";
            this.trianguloLado3.Size = new System.Drawing.Size(43, 13);
            this.trianguloLado3.TabIndex = 7;
            this.trianguloLado3.Text = "Lado 3:";
            // 
            // trianguloLado2
            // 
            this.trianguloLado2.AutoSize = true;
            this.trianguloLado2.Location = new System.Drawing.Point(46, 45);
            this.trianguloLado2.Name = "trianguloLado2";
            this.trianguloLado2.Size = new System.Drawing.Size(43, 13);
            this.trianguloLado2.TabIndex = 6;
            this.trianguloLado2.Text = "Lado 2:";
            // 
            // trianguloLado1TextBox
            // 
            this.trianguloLado1TextBox.Location = new System.Drawing.Point(89, 15);
            this.trianguloLado1TextBox.Name = "trianguloLado1TextBox";
            this.trianguloLado1TextBox.Size = new System.Drawing.Size(100, 20);
            this.trianguloLado1TextBox.TabIndex = 4;
            this.trianguloLado1TextBox.TextChanged += new System.EventHandler(this.trianguloLado1TextBox_TextChanged);
            this.trianguloLado1TextBox.Leave += new System.EventHandler(this.trianguloLado1TextBox_Leave);
            // 
            // trianguloAlturaTextBox
            // 
            this.trianguloAlturaTextBox.Location = new System.Drawing.Point(89, 94);
            this.trianguloAlturaTextBox.Name = "trianguloAlturaTextBox";
            this.trianguloAlturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.trianguloAlturaTextBox.TabIndex = 5;
            this.trianguloAlturaTextBox.Leave += new System.EventHandler(this.trianguloAlturaTextBox_Leave);
            // 
            // trianguloAltura
            // 
            this.trianguloAltura.AutoSize = true;
            this.trianguloAltura.Location = new System.Drawing.Point(46, 97);
            this.trianguloAltura.Name = "trianguloAltura";
            this.trianguloAltura.Size = new System.Drawing.Size(37, 13);
            this.trianguloAltura.TabIndex = 5;
            this.trianguloAltura.Text = "Altura:";
            // 
            // trianguloLado1
            // 
            this.trianguloLado1.AutoSize = true;
            this.trianguloLado1.Location = new System.Drawing.Point(46, 18);
            this.trianguloLado1.Name = "trianguloLado1";
            this.trianguloLado1.Size = new System.Drawing.Size(43, 13);
            this.trianguloLado1.TabIndex = 4;
            this.trianguloLado1.Text = "Lado 1:";
            // 
            // cuadradoTabPage
            // 
            this.cuadradoTabPage.Controls.Add(this.cuadradoLadoTextBox);
            this.cuadradoTabPage.Controls.Add(this.cuadradoLado);
            this.cuadradoTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTabPage.Name = "cuadradoTabPage";
            this.cuadradoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cuadradoTabPage.Size = new System.Drawing.Size(471, 220);
            this.cuadradoTabPage.TabIndex = 1;
            this.cuadradoTabPage.Text = "Cuadrado";
            this.cuadradoTabPage.UseVisualStyleBackColor = true;
            // 
            // cuadradoLadoTextBox
            // 
            this.cuadradoLadoTextBox.Location = new System.Drawing.Point(90, 24);
            this.cuadradoLadoTextBox.Name = "cuadradoLadoTextBox";
            this.cuadradoLadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cuadradoLadoTextBox.TabIndex = 2;
            this.cuadradoLadoTextBox.Leave += new System.EventHandler(this.cuadradoLadoTextBox_Leave);
            // 
            // cuadradoLado
            // 
            this.cuadradoLado.AutoSize = true;
            this.cuadradoLado.Location = new System.Drawing.Point(50, 27);
            this.cuadradoLado.Name = "cuadradoLado";
            this.cuadradoLado.Size = new System.Drawing.Size(34, 13);
            this.cuadradoLado.TabIndex = 0;
            this.cuadradoLado.Text = "Lado:";
            // 
            // circuloTabPage
            // 
            this.circuloTabPage.Controls.Add(this.circuloRadioTextBox);
            this.circuloTabPage.Controls.Add(this.circuloRadio);
            this.circuloTabPage.Location = new System.Drawing.Point(4, 22);
            this.circuloTabPage.Name = "circuloTabPage";
            this.circuloTabPage.Size = new System.Drawing.Size(471, 220);
            this.circuloTabPage.TabIndex = 2;
            this.circuloTabPage.Text = "Circulo";
            this.circuloTabPage.UseVisualStyleBackColor = true;
            // 
            // circuloRadioTextBox
            // 
            this.circuloRadioTextBox.Location = new System.Drawing.Point(94, 26);
            this.circuloRadioTextBox.Name = "circuloRadioTextBox";
            this.circuloRadioTextBox.Size = new System.Drawing.Size(100, 20);
            this.circuloRadioTextBox.TabIndex = 1;
            this.circuloRadioTextBox.Leave += new System.EventHandler(this.circuloRadioTextBox_Leave);
            // 
            // circuloRadio
            // 
            this.circuloRadio.AutoSize = true;
            this.circuloRadio.Location = new System.Drawing.Point(50, 29);
            this.circuloRadio.Name = "circuloRadio";
            this.circuloRadio.Size = new System.Drawing.Size(38, 13);
            this.circuloRadio.TabIndex = 0;
            this.circuloRadio.Text = "Radio:";
            // 
            // rectanguloTabPage
            // 
            this.rectanguloTabPage.Controls.Add(this.rectanguloAnchoTextBox);
            this.rectanguloTabPage.Controls.Add(this.rectanguloAltoTextBox);
            this.rectanguloTabPage.Controls.Add(this.rectanguloAncho);
            this.rectanguloTabPage.Controls.Add(this.rectanguloAlto);
            this.rectanguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanguloTabPage.Name = "rectanguloTabPage";
            this.rectanguloTabPage.Size = new System.Drawing.Size(471, 220);
            this.rectanguloTabPage.TabIndex = 3;
            this.rectanguloTabPage.Text = "Rectangulo";
            this.rectanguloTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanguloAnchoTextBox
            // 
            this.rectanguloAnchoTextBox.Location = new System.Drawing.Point(100, 42);
            this.rectanguloAnchoTextBox.Name = "rectanguloAnchoTextBox";
            this.rectanguloAnchoTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectanguloAnchoTextBox.TabIndex = 3;
            this.rectanguloAnchoTextBox.Leave += new System.EventHandler(this.rectanguloAnchoTextBox_Leave);
            // 
            // rectanguloAltoTextBox
            // 
            this.rectanguloAltoTextBox.Location = new System.Drawing.Point(100, 19);
            this.rectanguloAltoTextBox.Name = "rectanguloAltoTextBox";
            this.rectanguloAltoTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectanguloAltoTextBox.TabIndex = 2;
            this.rectanguloAltoTextBox.Leave += new System.EventHandler(this.rectanguloAltoTextBox_Leave);
            // 
            // rectanguloAncho
            // 
            this.rectanguloAncho.AutoSize = true;
            this.rectanguloAncho.Location = new System.Drawing.Point(53, 45);
            this.rectanguloAncho.Name = "rectanguloAncho";
            this.rectanguloAncho.Size = new System.Drawing.Size(41, 13);
            this.rectanguloAncho.TabIndex = 1;
            this.rectanguloAncho.Text = "Ancho:";
            // 
            // rectanguloAlto
            // 
            this.rectanguloAlto.AutoSize = true;
            this.rectanguloAlto.Location = new System.Drawing.Point(66, 22);
            this.rectanguloAlto.Name = "rectanguloAlto";
            this.rectanguloAlto.Size = new System.Drawing.Size(28, 13);
            this.rectanguloAlto.TabIndex = 0;
            this.rectanguloAlto.Text = "Alto:";
            // 
            // pentagonoTabPage
            // 
            this.pentagonoTabPage.Controls.Add(this.pentagonoApotemaTextBox);
            this.pentagonoTabPage.Controls.Add(this.pentagonoLadoTextBox);
            this.pentagonoTabPage.Controls.Add(this.pentagonoApotema);
            this.pentagonoTabPage.Controls.Add(this.pentagonoLado);
            this.pentagonoTabPage.Location = new System.Drawing.Point(4, 22);
            this.pentagonoTabPage.Name = "pentagonoTabPage";
            this.pentagonoTabPage.Size = new System.Drawing.Size(471, 220);
            this.pentagonoTabPage.TabIndex = 4;
            this.pentagonoTabPage.Text = "Pentagono";
            this.pentagonoTabPage.UseVisualStyleBackColor = true;
            // 
            // pentagonoApotemaTextBox
            // 
            this.pentagonoApotemaTextBox.Location = new System.Drawing.Point(105, 48);
            this.pentagonoApotemaTextBox.Name = "pentagonoApotemaTextBox";
            this.pentagonoApotemaTextBox.Size = new System.Drawing.Size(100, 20);
            this.pentagonoApotemaTextBox.TabIndex = 3;
            this.pentagonoApotemaTextBox.Leave += new System.EventHandler(this.pentagonoApotemaTextBox_Leave);
            // 
            // pentagonoLadoTextBox
            // 
            this.pentagonoLadoTextBox.Location = new System.Drawing.Point(105, 25);
            this.pentagonoLadoTextBox.Name = "pentagonoLadoTextBox";
            this.pentagonoLadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.pentagonoLadoTextBox.TabIndex = 2;
            this.pentagonoLadoTextBox.Leave += new System.EventHandler(this.pentagonoLadoTextBox_Leave);
            // 
            // pentagonoApotema
            // 
            this.pentagonoApotema.AutoSize = true;
            this.pentagonoApotema.Location = new System.Drawing.Point(47, 51);
            this.pentagonoApotema.Name = "pentagonoApotema";
            this.pentagonoApotema.Size = new System.Drawing.Size(52, 13);
            this.pentagonoApotema.TabIndex = 1;
            this.pentagonoApotema.Text = "Apotema:";
            // 
            // pentagonoLado
            // 
            this.pentagonoLado.AutoSize = true;
            this.pentagonoLado.Location = new System.Drawing.Point(65, 28);
            this.pentagonoLado.Name = "pentagonoLado";
            this.pentagonoLado.Size = new System.Drawing.Size(34, 13);
            this.pentagonoLado.TabIndex = 0;
            this.pentagonoLado.Text = "Lado:";
            // 
            // CalculadoraPoligonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.poligonosTabControl1);
            this.Controls.Add(this.botonArea);
            this.Controls.Add(this.botonPerimetro);
            this.Controls.Add(this.titulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CalculadoraPoligonos";
            this.Text = "Interfaz";
            this.poligonosTabControl1.ResumeLayout(false);
            this.poligonosTabControl.ResumeLayout(false);
            this.poligonosTabControl.PerformLayout();
            this.cuadradoTabPage.ResumeLayout(false);
            this.cuadradoTabPage.PerformLayout();
            this.circuloTabPage.ResumeLayout(false);
            this.circuloTabPage.PerformLayout();
            this.rectanguloTabPage.ResumeLayout(false);
            this.rectanguloTabPage.PerformLayout();
            this.pentagonoTabPage.ResumeLayout(false);
            this.pentagonoTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button botonPerimetro;
        private System.Windows.Forms.Button botonArea;
        private System.Windows.Forms.TabControl poligonosTabControl1;
        private System.Windows.Forms.TabPage poligonosTabControl;
        private System.Windows.Forms.TabPage cuadradoTabPage;
        private System.Windows.Forms.TabPage circuloTabPage;
        private System.Windows.Forms.TabPage rectanguloTabPage;
        private System.Windows.Forms.TabPage pentagonoTabPage;
        private System.Windows.Forms.Label trianguloAltura;
        private System.Windows.Forms.Label trianguloLado1;
        private System.Windows.Forms.TextBox trianguloLado1TextBox;
        private System.Windows.Forms.TextBox trianguloAlturaTextBox;
        private System.Windows.Forms.TextBox cuadradoLadoTextBox;
        private System.Windows.Forms.Label cuadradoLado;
        private System.Windows.Forms.TextBox circuloRadioTextBox;
        private System.Windows.Forms.Label circuloRadio;
        private System.Windows.Forms.TextBox rectanguloAnchoTextBox;
        private System.Windows.Forms.TextBox rectanguloAltoTextBox;
        private System.Windows.Forms.Label rectanguloAncho;
        private System.Windows.Forms.Label rectanguloAlto;
        private System.Windows.Forms.TextBox pentagonoApotemaTextBox;
        private System.Windows.Forms.TextBox pentagonoLadoTextBox;
        private System.Windows.Forms.Label pentagonoApotema;
        private System.Windows.Forms.Label pentagonoLado;
        private System.Windows.Forms.TextBox trianguloLado3TextBox;
        private System.Windows.Forms.TextBox trianguloLado2TextBox;
        private System.Windows.Forms.Label trianguloLado3;
        private System.Windows.Forms.Label trianguloLado2;
    }
}

