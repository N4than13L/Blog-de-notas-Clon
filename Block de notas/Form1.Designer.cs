namespace Block_de_notas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirComoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirComoToolStripMenuItem
            // 
            this.abrirComoToolStripMenuItem.Name = "abrirComoToolStripMenuItem";
            this.abrirComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirComoToolStripMenuItem.Text = "Abrir";
            this.abrirComoToolStripMenuItem.Click += new System.EventHandler(this.abrirComoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Imprimir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem,
            this.adelanteToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.seleccionarTodoToolStripMenuItem,
            this.borrarTodoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // adelanteToolStripMenuItem
            // 
            this.adelanteToolStripMenuItem.Name = "adelanteToolStripMenuItem";
            this.adelanteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.adelanteToolStripMenuItem.Text = "Adelante";
            this.adelanteToolStripMenuItem.Click += new System.EventHandler(this.adelanteToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // borrarTodoToolStripMenuItem
            // 
            this.borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
            this.borrarTodoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.borrarTodoToolStripMenuItem.Text = "Borrar todo";
            this.borrarTodoToolStripMenuItem.Click += new System.EventHandler(this.borrarTodoToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorDeFuenteToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.colorDeFondoToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // colorDeFuenteToolStripMenuItem
            // 
            this.colorDeFuenteToolStripMenuItem.Name = "colorDeFuenteToolStripMenuItem";
            this.colorDeFuenteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.colorDeFuenteToolStripMenuItem.Text = "Color de fuente";
            this.colorDeFuenteToolStripMenuItem.Click += new System.EventHandler(this.colorDeFuenteToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // colorDeFondoToolStripMenuItem
            // 
            this.colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            this.colorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.colorDeFondoToolStripMenuItem.Text = "Color de Fondo";
            this.colorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.colorDeFondoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.temasToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // temasToolStripMenuItem
            // 
            this.temasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.oscuroToolStripMenuItem});
            this.temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            this.temasToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.temasToolStripMenuItem.Text = "Temas";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // oscuroToolStripMenuItem
            // 
            this.oscuroToolStripMenuItem.Name = "oscuroToolStripMenuItem";
            this.oscuroToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.oscuroToolStripMenuItem.Text = "Oscuro";
            this.oscuroToolStripMenuItem.Click += new System.EventHandler(this.oscuroToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "block de notas: area de trabajo ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirComoToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem atrasToolStripMenuItem;
        private ToolStripMenuItem adelanteToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private ToolStripMenuItem borrarTodoToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem formatoToolStripMenuItem;
        private ToolStripMenuItem colorDeFuenteToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private ToolStripMenuItem colorDeFondoToolStripMenuItem;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private PrintDialog printDialog1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem temasToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem oscuroToolStripMenuItem;
    }
}