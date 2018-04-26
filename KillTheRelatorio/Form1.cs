using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillTheRelatorio
{
    public partial class Form1 : Form
    {
        List<double> valores = new List<double>();
        List<double> incertezas = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nomeDoArquivo = dlgAbrir.FileName;
                    StreamReader arquivo = new StreamReader(nomeDoArquivo);
                    string linhaLida = "";

                    while ((linhaLida = arquivo.ReadLine()) != null)
                    {
                        double valor = Convert.ToDouble(linhaLida);
                        valores.Add(valor);
                    }
                    arquivo.Close();
                }
                catch(Exception)
                { }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // calculo de médias
        //----------------------------------------------------------------------------------//
        private void aritmeticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = "Média Aritmética: " + Medias.MediaAritmetica(valores);
            }
            catch
            { }
        }

        private void quadraticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = "Média Quadrática: " + Medias.MediaQuadratica(valores);
            }
            catch
            { }
        }

        private void harmonicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = "Média Harmônica: " + Medias.MediaHarmonica(valores);
            }
            catch
            { }
        }

        private void geometricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = "Média Geométrica: " + Medias.MediaGeometrica(valores);
            }
            catch
            { }
        }

        private void ponderadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------------------------------//

        private void desvioPadrãoExperimentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double mda = Convert.ToDouble(Medias.MediaAritmetica(valores));

                lblResultado.Text = "\u03C3 (desvio-padrão): " + Incertezas.DesvioPadraoExp(mda,valores);
            }
            catch (Exception)
            {}

        }

        private void leituraAnalogicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PadraoDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
