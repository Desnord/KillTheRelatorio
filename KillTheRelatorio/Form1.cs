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
using System.Windows.Forms.DataVisualization.Charting;

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
            valores = new List<double>();

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

            tabControlOpcoes.Appearance = TabAppearance.FlatButtons;
            tabControlOpcoes.ItemSize = new Size(0, 1);
            tabControlOpcoes.SizeMode = TabSizeMode.Fixed;
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

        //Outros calculos
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


        //---------------------------------------------------------------------------------//
        private void txtA_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);

                if(opcao == 1)
                {
                    double ipa =  Incertezas.IncPadLeituraAnalog(a);
                    incertezas.Add(ipa);
                    lblResultado.Text = "\u2C99 (analógica): " + ipa.ToString("N20");
                }
                else
                {
                    double ipd = Incertezas.IncPadLeituraDig(a);
                    incertezas.Add(ipd);
                    lblResultado.Text = "\u2C99 (digital): " + ipd.ToString("N20");
                }
            }
            catch(Exception)
            { }

            txtA.Text = "a:";
            txtA.Enabled = false;
        }


        //Tab Control Principal
        //---------------------------------------------------------------------------------//
        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                valores.Sort();

                DataTable dt = new DataTable();

                dt.Columns.Add("valores");

                foreach (double item in valores)
                {
                    var row = dt.NewRow();

                    row[0] = item;

                    dt.Rows.Add(row);
                }

                /*DataTable dt = new DataTable();

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
                }*/

                dgvSimples.DataSource = dt;
                TabControlPrincipal.SelectedTab = tabPageTabela;
            }
            catch(Exception)
            {

            }
        }

        private void deOcorrenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            try
            {
                valores.Sort();
                double deltaX = (valores[valores.Count - 1] - valores[0]) / Math.Pow(valores.Count, 0.5);
                string deltaXstr = deltaX.ToString();
                deltaXstr = deltaXstr.Substring(0, 6);
                deltaX = Convert.ToDouble(deltaXstr);


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
                        ocorre = 1;
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
                        ocorre = 1;

                        if(i == valores.Count-1)
                        {
                            row[1] = ocorre;
                            dt.Rows.Add(row);
                        }
                    }
                }

                dgvOcorrencias.DataSource = dt;
                TabControlPrincipal.SelectedTab = tabPageOcorrencias;
            }
            catch (Exception)
            { }
        }

        private void histogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.chartHistograma.Series["Ocorrências"].Points.Clear();

                valores.Sort();
                double deltaX = (valores[valores.Count - 1] - valores[0]) / Math.Pow(valores.Count, 0.5);
                string deltaXstr = deltaX.ToString();
                deltaXstr = deltaXstr.Substring(0, 6);
                deltaX = Convert.ToDouble(deltaXstr);

                DataTable dt = new DataTable();

                dt.Columns.Add("Intervalo");
                dt.Columns.Add("Ocorrências");

                var row = dt.NewRow();
                double atual = valores[0];
                int ocorre = 0;

                for (int i = 0; i < valores.Count; i++)
                {
                    if (atual == valores[0] && i == 0)
                    {
                        row[0] = "[ " + atual + " ; " + (atual + deltaX) + " )";
                        ocorre = 1;
                    }

                    else if (valores[i] >= atual && valores[i] < atual + deltaX)
                    {
                        ocorre++;
                    }
                    else if (valores[i] >= atual + deltaX)
                    {
                        atual += deltaX;
                        row[1] = ocorre;
                        dt.Rows.Add(row);

                        row = dt.NewRow();
                        row[0] = "[ " + atual + " ; " + (atual + deltaX) + " )";
                        ocorre = 1;

                        if (i == valores.Count - 1)
                        {
                            row[1] = ocorre;
                            dt.Rows.Add(row);
                        }
                    }
                }

                dgvOcorrencias.DataSource = dt;
            }
            catch (Exception)
            { }

            try
            {
                for(int i=0;i< dgvOcorrencias.RowCount;i++)
                {
                    this.chartHistograma.Series["Ocorrências"].Points.AddXY(dgvOcorrencias.Rows[i].Cells[0].Value, dgvOcorrencias.Rows[i].Cells[1].Value);
                }
            }
            catch(Exception)
            { }

            TabControlPrincipal.SelectedTab = tabPageHistograma;
        }

        private void gráficoLogLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // TabControlPrincipal.SelectedTab = tabPageLogLog;
        }
        //---------------------------------------------------------------------------------//
        private void cbListaInc_CheckStateChanged(object sender, EventArgs e)
        {
            if(cbListaInc.Checked)
            {
                try
                {
                    incertezas.Sort();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("incertezas");

                    foreach (double item in incertezas)
                    {
                        var row = dt.NewRow();

                        row[0] = item.ToString("N20");

                        dt.Rows.Add(row);
                    }

                    dgvIncertezas.DataSource = dt;
                }
                catch(Exception)
                {

                }
            }
            else
            {
                dgvIncertezas.DataSource = new DataTable();
            }
        }

        private void dgvIncertezas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                int indexDel = e.Row.Index;
                incertezas.RemoveAt(indexDel);
            }
            catch (Exception)
            {

            }
        }

    }
}
