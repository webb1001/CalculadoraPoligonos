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
            this.cuadradoTabPage = new System.Windows.Forms.TabPage();
            this.circuloTabPage = new System.Windows.Forms.TabPage();
            this.rectanguloTabPage = new System.Windows.Forms.TabPage();
            this.pentagonoTabPage = new System.Windows.Forms.TabPage();
            this.trianguloLado1 = new System.Windows.Forms.Label();
            this.trianguloAltura = new System.Windows.Forms.Label();
            this.cuadradoLado = new System.Windows.Forms.Label();
            this.pentagonoLado = new System.Windows.Forms.Label();
            this.pentagonoApotema = new System.Windows.Forms.Label();
            this.circuloRadio = new System.Windows.Forms.Label();
            this.rectanguloAlto = new System.Windows.Forms.Label();
            this.rectanguloAncho = new System.Windows.Forms.Label();
            this.trianguloTextBox1 = new System.Windows.Forms.TextBox();
            this.trianguloTextBox4 = new System.Windows.Forms.TextBox();
            this.cuadradoTextBox1 = new System.Windows.Forms.TextBox();
            this.circuloTextBox1 = new System.Windows.Forms.TextBox();
            this.rectanguloTextBox1 = new System.Windows.Forms.TextBox();
            this.rectanguloTextBox2 = new System.Windows.Forms.TextBox();
            this.pentagonoTextBox1 = new System.Windows.Forms.TextBox();
            this.pentagonoTextBox2 = new System.Windows.Forms.TextBox();
            this.trianguloLado2 = new System.Windows.Forms.Label();
            this.trianguloLado3 = new System.Windows.Forms.Label();
            this.trianguloTextBox2 = new System.Windows.Forms.TextBox();
            this.trianguloTextBox3 = new System.Windows.Forms.TextBox();
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
            this.botonPerimetro.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonArea
            // 
            this.botonArea.Location = new System.Drawing.Point(391, 334);
            this.botonArea.Name = "botonArea";
            this.botonArea.Size = new System.Drawing.Size(96, 23);
            this.botonArea.TabIndex = 2;
            this.botonArea.Text = "Calcular Area";
            this.botonArea.UseVisualStyleBackColor = true;
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
            this.poligonosTabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // poligonosTabControl
            // 
            this.poligonosTabControl.Controls.Add(this.trianguloTextBox3);
            this.poligonosTabControl.Controls.Add(this.trianguloTextBox2);
            this.poligonosTabControl.Controls.Add(this.trianguloLado3);
            this.poligonosTabControl.Controls.Add(this.trianguloLado2);
            this.poligonosTabControl.Controls.Add(this.trianguloTextBox1);
            this.poligonosTabControl.Controls.Add(this.trianguloTextBox4);
            this.poligonosTabControl.Controls.Add(this.trianguloAltura);
            this.poligonosTabControl.Controls.Add(this.trianguloLado1);
            this.poligonosTabControl.Location = new System.Drawing.Point(4, 22);
            this.poligonosTabControl.Name = "poligonosTabControl";
            this.poligonosTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.poligonosTabControl.Size = new System.Drawing.Size(471, 220);
            this.poligonosTabControl.TabIndex = 0;
            this.poligonosTabControl.Text = "Triangulo";
            this.poligonosTabControl.UseVisualStyleBackColor = true;
            this.poligonosTabControl.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cuadradoTabPage
            // 
            this.cuadradoTabPage.Controls.Add(this.cuadradoTextBox1);
            this.cuadradoTabPage.Controls.Add(this.cuadradoLado);
            this.cuadradoTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTabPage.Name = "cuadradoTabPage";
            this.cuadradoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cuadradoTabPage.Size = new System.Drawing.Size(471, 220);
            this.cuadradoTabPage.TabIndex = 1;
            this.cuadradoTabPage.Text = "Cuadrado";
            this.cuadradoTabPage.UseVisualStyleBackColor = true;
            this.cuadradoTabPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // circuloTabPage
            // 
            this.circuloTabPage.Controls.Add(this.circuloTextBox1);
            this.circuloTabPage.Controls.Add(this.circuloRadio);
            this.circuloTabPage.Location = new System.Drawing.Point(4, 22);
            this.circuloTabPage.Name = "circuloTabPage";
            this.circuloTabPage.Size = new System.Drawing.Size(471, 220);
            this.circuloTabPage.TabIndex = 2;
            this.circuloTabPage.Text = "Circulo";
            this.circuloTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanguloTabPage
            // 
            this.rectanguloTabPage.Controls.Add(this.rectanguloTextBox2);
            this.rectanguloTabPage.Controls.Add(this.rectanguloTextBox1);
            this.rectanguloTabPage.Controls.Add(this.rectanguloAncho);
            this.rectanguloTabPage.Controls.Add(this.rectanguloAlto);
            this.rectanguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanguloTabPage.Name = "rectanguloTabPage";
            this.rectanguloTabPage.Size = new System.Drawing.Size(471, 220);
            this.rectanguloTabPage.TabIndex = 3;
            this.rectanguloTabPage.Text = "Rectangulo";
            this.rectanguloTabPage.UseVisualStyleBackColor = true;
            // 
            // pentagonoTabPage
            // 
            this.pentagonoTabPage.Controls.Add(this.pentagonoTextBox2);
            this.pentagonoTabPage.Controls.Add(this.pentagonoTextBox1);
            this.pentagonoTabPage.Controls.Add(this.pentagonoApotema);
            this.pentagonoTabPage.Controls.Add(this.pentagonoLado);
            this.pentagonoTabPage.Location = new System.Drawing.Point(4, 22);
            this.pentagonoTabPage.Name = "pentagonoTabPage";
            this.pentagonoTabPage.Size = new System.Drawing.Size(471, 220);
            this.pentagonoTabPage.TabIndex = 4;
            this.pentagonoTabPage.Text = "Pentagono";
            this.pentagonoTabPage.UseVisualStyleBackColor = true;
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
            // trianguloAltura
            // 
            this.trianguloAltura.AutoSize = true;
            this.trianguloAltura.Location = new System.Drawing.Point(46, 102);
            this.trianguloAltura.Name = "trianguloAltura";
            this.trianguloAltura.Size = new System.Drawing.Size(37, 13);
            this.trianguloAltura.TabIndex = 5;
            this.trianguloAltura.Text = "Altura:";
            // 
            // cuadradoLado
            // 
            this.cuadradoLado.AutoSize = true;
            this.cuadradoLado.Location = new System.Drawing.Point(50, 27);
            this.cuadradoLado.Name = "cuadradoLado";
            this.cuadradoLado.Size = new System.Drawing.Size(34, 13);
            this.cuadradoLado.TabIndex = 0;
            this.cuadradoLado.Text = "Lado:";
            this.cuadradoLado.Click += new System.EventHandler(this.label4_Click);
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
            // pentagonoApotema
            // 
            this.pentagonoApotema.AutoSize = true;
            this.pentagonoApotema.Location = new System.Drawing.Point(47, 51);
            this.pentagonoApotema.Name = "pentagonoApotema";
            this.pentagonoApotema.Size = new System.Drawing.Size(52, 13);
            this.pentagonoApotema.TabIndex = 1;
            this.pentagonoApotema.Text = "Apotema:";
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
            // rectanguloAlto
            // 
            this.rectanguloAlto.AutoSize = true;
            this.rectanguloAlto.Location = new System.Drawing.Point(66, 22);
            this.rectanguloAlto.Name = "rectanguloAlto";
            this.rectanguloAlto.Size = new System.Drawing.Size(28, 13);
            this.rectanguloAlto.TabIndex = 0;
            this.rectanguloAlto.Text = "Alto:";
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
            // trianguloTextBox1
            // 
            this.trianguloTextBox1.Location = new System.Drawing.Point(89, 15);
            this.trianguloTextBox1.Name = "trianguloTextBox1";
            this.trianguloTextBox1.Size = new System.Drawing.Size(100, 20);
            this.trianguloTextBox1.TabIndex = 4;
            // 
            // trianguloTextBox4
            // 
            this.trianguloTextBox4.Location = new System.Drawing.Point(89, 99);
            this.trianguloTextBox4.Name = "trianguloTextBox4";
            this.trianguloTextBox4.Size = new System.Drawing.Size(100, 20);
            this.trianguloTextBox4.TabIndex = 5;
            // 
            // cuadradoTextBox1
            // 
            this.cuadradoTextBox1.Location = new System.Drawing.Point(90, 24);
            this.cuadradoTextBox1.Name = "cuadradoTextBox1";
            this.cuadradoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.cuadradoTextBox1.TabIndex = 2;
            // 
            // circuloTextBox1
            // 
            this.circuloTextBox1.Location = new System.Drawing.Point(94, 26);
            this.circuloTextBox1.Name = "circuloTextBox1";
            this.circuloTextBox1.Size = new System.Drawing.Size(100, 20);
            this.circuloTextBox1.TabIndex = 1;
            // 
            // rectanguloTextBox1
            // 
            this.rectanguloTextBox1.Location = new System.Drawing.Point(100, 19);
            this.rectanguloTextBox1.Name = "rectanguloTextBox1";
            this.rectanguloTextBox1.Size = new System.Drawing.Size(100, 20);
            this.rectanguloTextBox1.TabIndex = 2;
            // 
            // rectanguloTextBox2
            // 
            this.rectanguloTextBox2.Location = new System.Drawing.Point(100, 42);
            this.rectanguloTextBox2.Name = "rectanguloTextBox2";
            this.rectanguloTextBox2.Size = new System.Drawing.Size(100, 20);
            this.rectanguloTextBox2.TabIndex = 3;
            // 
            // pentagonoTextBox1
            // 
            this.pentagonoTextBox1.Location = new System.Drawing.Point(105, 25);
            this.pentagonoTextBox1.Name = "pentagonoTextBox1";
            this.pentagonoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.pentagonoTextBox1.TabIndex = 2;
            // 
            // pentagonoTextBox2
            // 
            this.pentagonoTextBox2.Location = new System.Drawing.Point(105, 48);
            this.pentagonoTextBox2.Name = "pentagonoTextBox2";
            this.pentagonoTextBox2.Size = new System.Drawing.Size(100, 20);
            this.pentagonoTextBox2.TabIndex = 3;
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
            // trianguloLado3
            // 
            this.trianguloLado3.AutoSize = true;
            this.trianguloLado3.Location = new System.Drawing.Point(46, 75);
            this.trianguloLado3.Name = "trianguloLado3";
            this.trianguloLado3.Size = new System.Drawing.Size(43, 13);
            this.trianguloLado3.TabIndex = 7;
            this.trianguloLado3.Text = "Lado 3:";
            // 
            // trianguloTextBox2
            // 
            this.trianguloTextBox2.Location = new System.Drawing.Point(89, 42);
            this.trianguloTextBox2.Name = "trianguloTextBox2";
            this.trianguloTextBox2.Size = new System.Drawing.Size(100, 20);
            this.trianguloTextBox2.TabIndex = 8;
            // 
            // trianguloTextBox3
            // 
            this.trianguloTextBox3.Location = new System.Drawing.Point(89, 72);
            this.trianguloTextBox3.Name = "trianguloTextBox3";
            this.trianguloTextBox3.Size = new System.Drawing.Size(100, 20);
            this.trianguloTextBox3.TabIndex = 9;
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox trianguloTextBox1;
        private System.Windows.Forms.TextBox trianguloTextBox4;
        private System.Windows.Forms.TextBox cuadradoTextBox1;
        private System.Windows.Forms.Label cuadradoLado;
        private System.Windows.Forms.TextBox circuloTextBox1;
        private System.Windows.Forms.Label circuloRadio;
        private System.Windows.Forms.TextBox rectanguloTextBox2;
        private System.Windows.Forms.TextBox rectanguloTextBox1;
        private System.Windows.Forms.Label rectanguloAncho;
        private System.Windows.Forms.Label rectanguloAlto;
        private System.Windows.Forms.TextBox pentagonoTextBox2;
        private System.Windows.Forms.TextBox pentagonoTextBox1;
        private System.Windows.Forms.Label pentagonoApotema;
        private System.Windows.Forms.Label pentagonoLado;
        private System.Windows.Forms.TextBox trianguloTextBox3;
        private System.Windows.Forms.TextBox trianguloTextBox2;
        private System.Windows.Forms.Label trianguloLado3;
        private System.Windows.Forms.Label trianguloLado2;
    }
}

