using System.Windows.Forms;

namespace Block_de_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); 
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colorFuente = colorDialog1.ShowDialog();

            if (colorFuente == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fuente = fontDialog1.ShowDialog();
            if(fuente == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void abrirComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            System.IO.StringReader abrir = new System.IO.StringReader(openFileDialog1.FileName);

            richTextBox1.Text = abrir.ReadToEnd();
            abrir.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            System.IO.StreamWriter guardar = new StreamWriter(saveFileDialog1.FileName);
            guardar.WriteLine(richTextBox1.Text);
            guardar.Close();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarComo = new SaveFileDialog();
            StreamWriter streamWriter = null;
            guardarComo.Filter = "Text *(.txt)|*.txt|HTML(*.html*)*|html|Todos los archivos(*.*)|*.*)";
            guardarComo.CheckFileExists = true;
            guardarComo.Title = "Guardar como";
            guardarComo.ShowDialog(this);

            try
            {
                streamWriter = System.IO.File.AppendText(guardarComo.FileName);
                streamWriter.Write(richTextBox1.Text);
                streamWriter.Flush();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog(richTextBox1);
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info _info = new Info();
            _info.Show();
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ForeColor = Color.Black;

            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.ForeColor = Color.Black;
        }

        private void oscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = SystemColors.GrayText;
            menuStrip1.ForeColor = Color.White;

            richTextBox1.BackColor = SystemColors.GrayText;
            richTextBox1.ForeColor = Color.White;
        }

    }
}