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
        int opcao = 0;
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
            
            TabControlPrincipal.Appearance = TabAppearance.FlatButtons;
            TabControlPrincipal.ItemSize = new Size(0, 1);
            TabControlPrincipal.SizeMode = TabSizeMode.Fixed;
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
            txtA.Enabled = true;
            txtA.Text = "";
            txtA.Focus();
            opcao = 1;
        }

        private void PadraoDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtA.Enabled = true;
            txtA.Text = "";
            txtA.Focus();
            opcao = 0;
        }

        private void medicoesRepetidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double mda = Convert.ToDouble(Medias.MediaAritmetica(valores));
                double imr = Convert.ToDouble(Incertezas.IncMedicoesRep(mda, valores));

                incertezas.Add(imr);
                lblResultado.Text = "\u2C99 (medições repetidas): " + imr;
            }
            catch (Exception)
            { }
        }

        private void padraoCombinadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = "\u2C99 (combinada): " + Incertezas.IncertezaPadraoCombinada(incertezas);
            }
            catch(Exception)
            { }
        }

        private void txtA_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);

                if(opcao == 1)
                {
                    double ipa = Convert.ToDouble(Incertezas.IncPadLeituraAnalog(a));
                    incertezas.Add(ipa);
                    lblResultado.Text = "\u2C99 (analógica): " + ipa;
                }
                else
                {
                    double ipd = Convert.ToDouble(Incertezas.IncPadLeituraDig(a));
                    incertezas.Add(ipd);
                    lblResultado.Text = "\u2C99 (digital): " + ipd;
                }
            }
            catch(Exception)
            { }

            txtA.Text = "a:";
            txtA.Enabled = false;
        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                valores.Sort();

                DataTable dt = new DataTable();

                dt.Columns.Add("");
                dt.Columns.Add("");
                dt.Columns.Add("");
                dt.Columns.Add("");
                dt.Columns.Add("");

                int cont = 0;
                var row = dt.NewRow();

                for (int i = 0; i < valores.Count; i++)
                {
                    if (cont == 4)
                    {
                        row[cont] = valores[i];
                        dt.Rows.Add(row);
                        row = dt.NewRow();
                        cont = 0;
                    }
                    else
                    {
                        row[cont] = valores[i];
                        cont++;
                    }
                }

                if (valores.Count < 5)
                {
                    dt.Rows.Add(row);
                }

                dgvSimples.DataSource = dt;
                TabControlPrincipal.SelectedTab = tabPageTabela;
            }
            catch(Exception)
            {

            }
        }

        private void deOcorrenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*
            try
            {
                valores.Sort();
                double deltaX = (valores[valores.Count - 1] - valores[0]) / Math.Pow(valores.Count, 0.5);

                DataTable dt = new DataTable();

                dt.Columns.Add("Intervalo");
                dt.Columns.Add("Ocorrências");

                var row = dt.NewRow();
                double atual = valores[0];
                int ocorre = 0;

                for (int i = 0; i < valores.Count; i++)
                {
                    if(atual == valores[0] && i == 0)
                    {
                        row[0] = "[ " + atual + " ; " + (atual + deltaX) + " )";
                    }

                    else if(valores[i] >= atual && valores[i] < atual+deltaX)
                    {
                        ocorre++;
                    }
                    else if(valores[i] >= atual+deltaX)
                    {
                        atual += deltaX;
                        row[1] = ocorre;
                        dt.Rows.Add(row);

                        row = dt.NewRow();
                        row[0] = "[ " + atual + " ; " + (atual + deltaX) + " )";
                        ocorre = 0;
                    }
                }

                dgvOcorrencias.DataSource = dt;
                TabControlPrincipal.SelectedTab = tabPageOcorrencias;
            }
            catch (Exception)
            { }*/
        }
    }
}
