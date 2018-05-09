namespace KillTheRelatorio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritméticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadráticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harmônicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geométricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incertezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PadraoDigitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leituraAnalogicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoesRepetidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.desvioPadrãoExperimentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padraoCombinadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoLogLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deOcorrenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.TabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageHistograma = new System.Windows.Forms.TabPage();
            this.chartHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageLogLog = new System.Windows.Forms.TabPage();
            this.chartLogLog = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageTabela = new System.Windows.Forms.TabPage();
            this.dgvSimples = new System.Windows.Forms.DataGridView();
            this.tabPageOcorrencias = new System.Windows.Forms.TabPage();
            this.dgvOcorrencias = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlOpcoes = new System.Windows.Forms.TabControl();
            this.tabPageIncertezas = new System.Windows.Forms.TabPage();
            this.cbListaInc = new System.Windows.Forms.CheckBox();
            this.dgvIncertezas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            this.TabControlPrincipal.SuspendLayout();
            this.tabPageHistograma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistograma)).BeginInit();
            this.tabPageLogLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLogLog)).BeginInit();
            this.tabPageTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimples)).BeginInit();
            this.tabPageOcorrencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControlOpcoes.SuspendLayout();
            this.tabPageIncertezas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncertezas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.médiasToolStripMenuItem,
            this.incertezasToolStripMenuItem,
            this.histogramaToolStripMenuItem,
            this.gráficoLogLogToolStripMenuItem,
            this.tabelaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(108, 413);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // médiasToolStripMenuItem
            // 
            this.médiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritméticaToolStripMenuItem,
            this.quadráticaToolStripMenuItem,
            this.harmônicaToolStripMenuItem,
            this.geométricaToolStripMenuItem});
            this.médiasToolStripMenuItem.Name = "médiasToolStripMenuItem";
            this.médiasToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.médiasToolStripMenuItem.Text = "Médias";
            // 
            // aritméticaToolStripMenuItem
            // 
            this.aritméticaToolStripMenuItem.Name = "aritméticaToolStripMenuItem";
            this.aritméticaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aritméticaToolStripMenuItem.Text = "Aritmética";
            this.aritméticaToolStripMenuItem.Click += new System.EventHandler(this.aritmeticaToolStripMenuItem_Click);
            // 
            // quadráticaToolStripMenuItem
            // 
            this.quadráticaToolStripMenuItem.Name = "quadráticaToolStripMenuItem";
            this.quadráticaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.quadráticaToolStripMenuItem.Text = "Quadrática";
            this.quadráticaToolStripMenuItem.Click += new System.EventHandler(this.quadraticaToolStripMenuItem_Click);
            // 
            // harmônicaToolStripMenuItem
            // 
            this.harmônicaToolStripMenuItem.Name = "harmônicaToolStripMenuItem";
            this.harmônicaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.harmônicaToolStripMenuItem.Text = "Harmônica";
            this.harmônicaToolStripMenuItem.Click += new System.EventHandler(this.harmonicaToolStripMenuItem_Click);
            // 
            // geométricaToolStripMenuItem
            // 
            this.geométricaToolStripMenuItem.Name = "geométricaToolStripMenuItem";
            this.geométricaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.geométricaToolStripMenuItem.Text = "Geométrica";
            this.geométricaToolStripMenuItem.Click += new System.EventHandler(this.geometricaToolStripMenuItem_Click);
            // 
            // incertezasToolStripMenuItem
            // 
            this.incertezasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PadraoDigitalToolStripMenuItem,
            this.leituraAnalogicaToolStripMenuItem,
            this.medicoesRepetidasToolStripMenuItem,
            this.toolStripSeparator1,
            this.desvioPadrãoExperimentalToolStripMenuItem,
            this.padraoCombinadaToolStripMenuItem});
            this.incertezasToolStripMenuItem.Name = "incertezasToolStripMenuItem";
            this.incertezasToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.incertezasToolStripMenuItem.Text = "Incertezas";
            // 
            // PadraoDigitalToolStripMenuItem
            // 
            this.PadraoDigitalToolStripMenuItem.Name = "PadraoDigitalToolStripMenuItem";
            this.PadraoDigitalToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.PadraoDigitalToolStripMenuItem.Text = "Padrão de Leitura Digital";
            this.PadraoDigitalToolStripMenuItem.Click += new System.EventHandler(this.PadraoDigitalToolStripMenuItem_Click);
            // 
            // leituraAnalogicaToolStripMenuItem
            // 
            this.leituraAnalogicaToolStripMenuItem.Name = "leituraAnalogicaToolStripMenuItem";
            this.leituraAnalogicaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.leituraAnalogicaToolStripMenuItem.Text = "Padrão de Leitura Analógica";
            this.leituraAnalogicaToolStripMenuItem.Click += new System.EventHandler(this.leituraAnalogicaToolStripMenuItem_Click);
            // 
            // medicoesRepetidasToolStripMenuItem
            // 
            this.medicoesRepetidasToolStripMenuItem.Name = "medicoesRepetidasToolStripMenuItem";
            this.medicoesRepetidasToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.medicoesRepetidasToolStripMenuItem.Text = "Medições Repetidas";
            this.medicoesRepetidasToolStripMenuItem.Click += new System.EventHandler(this.medicoesRepetidasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // desvioPadrãoExperimentalToolStripMenuItem
            // 
            this.desvioPadrãoExperimentalToolStripMenuItem.Name = "desvioPadrãoExperimentalToolStripMenuItem";
            this.desvioPadrãoExperimentalToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.desvioPadrãoExperimentalToolStripMenuItem.Text = "Desvio Padrão Experimental";
            this.desvioPadrãoExperimentalToolStripMenuItem.Click += new System.EventHandler(this.desvioPadrãoExperimentalToolStripMenuItem_Click);
            // 
            // padraoCombinadaToolStripMenuItem
            // 
            this.padraoCombinadaToolStripMenuItem.Name = "padraoCombinadaToolStripMenuItem";
            this.padraoCombinadaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.padraoCombinadaToolStripMenuItem.Text = "Padrão Combinada";
            this.padraoCombinadaToolStripMenuItem.Click += new System.EventHandler(this.padraoCombinadaToolStripMenuItem_Click);
            // 
            // histogramaToolStripMenuItem
            // 
            this.histogramaToolStripMenuItem.Name = "histogramaToolStripMenuItem";
            this.histogramaToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.histogramaToolStripMenuItem.Text = "Histograma";
            this.histogramaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.histogramaToolStripMenuItem.Click += new System.EventHandler(this.histogramaToolStripMenuItem_Click);
            // 
            // gráficoLogLogToolStripMenuItem
            // 
            this.gráficoLogLogToolStripMenuItem.Name = "gráficoLogLogToolStripMenuItem";
            this.gráficoLogLogToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.gráficoLogLogToolStripMenuItem.Text = "Gráfico Log-Log";
            this.gráficoLogLogToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gráficoLogLogToolStripMenuItem.Click += new System.EventHandler(this.gráficoLogLogToolStripMenuItem_Click);
            // 
            // tabelaToolStripMenuItem
            // 
            this.tabelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplesToolStripMenuItem,
            this.deOcorrenciasToolStripMenuItem});
            this.tabelaToolStripMenuItem.Name = "tabelaToolStripMenuItem";
            this.tabelaToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.tabelaToolStripMenuItem.Text = "Tabela";
            // 
            // simplesToolStripMenuItem
            // 
            this.simplesToolStripMenuItem.Name = "simplesToolStripMenuItem";
            this.simplesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.simplesToolStripMenuItem.Text = "Simples";
            this.simplesToolStripMenuItem.Click += new System.EventHandler(this.simplesToolStripMenuItem_Click);
            // 
            // deOcorrenciasToolStripMenuItem
            // 
            this.deOcorrenciasToolStripMenuItem.Name = "deOcorrenciasToolStripMenuItem";
            this.deOcorrenciasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deOcorrenciasToolStripMenuItem.Text = "De Ocorrências";
            this.deOcorrenciasToolStripMenuItem.Click += new System.EventHandler(this.deOcorrenciasToolStripMenuItem_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.DimGray;
            this.lblResultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResultado.Location = new System.Drawing.Point(108, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(861, 29);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(6, 6);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "a:";
            this.txtA.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtA_MouseDoubleClick);
            // 
            // TabControlPrincipal
            // 
            this.TabControlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlPrincipal.Controls.Add(this.tabPageHistograma);
            this.TabControlPrincipal.Controls.Add(this.tabPageLogLog);
            this.TabControlPrincipal.Controls.Add(this.tabPageTabela);
            this.TabControlPrincipal.Controls.Add(this.tabPageOcorrencias);
            this.TabControlPrincipal.Location = new System.Drawing.Point(3, 14);
            this.TabControlPrincipal.Name = "TabControlPrincipal";
            this.TabControlPrincipal.SelectedIndex = 0;
            this.TabControlPrincipal.Size = new System.Drawing.Size(543, 354);
            this.TabControlPrincipal.TabIndex = 3;
            // 
            // tabPageHistograma
            // 
            this.tabPageHistograma.Controls.Add(this.chartHistograma);
            this.tabPageHistograma.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistograma.Name = "tabPageHistograma";
            this.tabPageHistograma.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistograma.Size = new System.Drawing.Size(535, 328);
            this.tabPageHistograma.TabIndex = 0;
            this.tabPageHistograma.Text = "histograma";
            this.tabPageHistograma.UseVisualStyleBackColor = true;
            // 
            // chartHistograma
            // 
            this.chartHistograma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartHistograma.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chartHistograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistograma.Legends.Add(legend1);
            this.chartHistograma.Location = new System.Drawing.Point(3, 3);
            this.chartHistograma.Name = "chartHistograma";
            this.chartHistograma.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Teal;
            series1.Legend = "Legend1";
            series1.Name = "Ocorrências";
            series1.YValuesPerPoint = 4;
            this.chartHistograma.Series.Add(series1);
            this.chartHistograma.Size = new System.Drawing.Size(529, 322);
            this.chartHistograma.TabIndex = 0;
            this.chartHistograma.Text = "Histograma";
            title1.Name = "Title1";
            this.chartHistograma.Titles.Add(title1);
            // 
            // tabPageLogLog
            // 
            this.tabPageLogLog.Controls.Add(this.chartLogLog);
            this.tabPageLogLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogLog.Name = "tabPageLogLog";
            this.tabPageLogLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogLog.Size = new System.Drawing.Size(535, 328);
            this.tabPageLogLog.TabIndex = 1;
            this.tabPageLogLog.Text = "log-log";
            this.tabPageLogLog.UseVisualStyleBackColor = true;
            // 
            // chartLogLog
            // 
            this.chartLogLog.BackColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.IsLogarithmic = true;
            chartArea2.AxisY.IsLogarithmic = true;
            chartArea2.Name = "ChartArea1";
            this.chartLogLog.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLogLog.Legends.Add(legend2);
            this.chartLogLog.Location = new System.Drawing.Point(3, 3);
            this.chartLogLog.Name = "chartLogLog";
            this.chartLogLog.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartLogLog.Series.Add(series2);
            this.chartLogLog.Size = new System.Drawing.Size(529, 323);
            this.chartLogLog.TabIndex = 0;
            this.chartLogLog.Text = "chart2";
            // 
            // tabPageTabela
            // 
            this.tabPageTabela.Controls.Add(this.dgvSimples);
            this.tabPageTabela.Location = new System.Drawing.Point(4, 22);
            this.tabPageTabela.Name = "tabPageTabela";
            this.tabPageTabela.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTabela.Size = new System.Drawing.Size(535, 328);
            this.tabPageTabela.TabIndex = 2;
            this.tabPageTabela.Text = "tabela simples";
            this.tabPageTabela.UseVisualStyleBackColor = true;
            // 
            // dgvSimples
            // 
            this.dgvSimples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSimples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimples.Location = new System.Drawing.Point(3, 3);
            this.dgvSimples.Name = "dgvSimples";
            this.dgvSimples.Size = new System.Drawing.Size(529, 322);
            this.dgvSimples.TabIndex = 0;
            // 
            // tabPageOcorrencias
            // 
            this.tabPageOcorrencias.Controls.Add(this.dgvOcorrencias);
            this.tabPageOcorrencias.Location = new System.Drawing.Point(4, 22);
            this.tabPageOcorrencias.Name = "tabPageOcorrencias";
            this.tabPageOcorrencias.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOcorrencias.Size = new System.Drawing.Size(535, 328);
            this.tabPageOcorrencias.TabIndex = 3;
            this.tabPageOcorrencias.Text = "tabela de ocorrencias";
            this.tabPageOcorrencias.UseVisualStyleBackColor = true;
            // 
            // dgvOcorrencias
            // 
            this.dgvOcorrencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOcorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcorrencias.Location = new System.Drawing.Point(3, 3);
            this.dgvOcorrencias.Name = "dgvOcorrencias";
            this.dgvOcorrencias.Size = new System.Drawing.Size(529, 322);
            this.dgvOcorrencias.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.tabControlOpcoes);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 354);
            this.panel1.TabIndex = 2;
            // 
            // tabControlOpcoes
            // 
            this.tabControlOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlOpcoes.Controls.Add(this.tabPageIncertezas);
            this.tabControlOpcoes.Controls.Add(this.tabPage2);
            this.tabControlOpcoes.Location = new System.Drawing.Point(3, 3);
            this.tabControlOpcoes.Name = "tabControlOpcoes";
            this.tabControlOpcoes.SelectedIndex = 0;
            this.tabControlOpcoes.Size = new System.Drawing.Size(283, 344);
            this.tabControlOpcoes.TabIndex = 1;
            // 
            // tabPageIncertezas
            // 
            this.tabPageIncertezas.BackColor = System.Drawing.Color.DimGray;
            this.tabPageIncertezas.Controls.Add(this.cbListaInc);
            this.tabPageIncertezas.Controls.Add(this.dgvIncertezas);
            this.tabPageIncertezas.Controls.Add(this.txtA);
            this.tabPageIncertezas.Location = new System.Drawing.Point(4, 22);
            this.tabPageIncertezas.Name = "tabPageIncertezas";
            this.tabPageIncertezas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIncertezas.Size = new System.Drawing.Size(275, 318);
            this.tabPageIncertezas.TabIndex = 0;
            this.tabPageIncertezas.Text = "Incertezas";
            // 
            // cbListaInc
            // 
            this.cbListaInc.AutoSize = true;
            this.cbListaInc.Location = new System.Drawing.Point(6, 187);
            this.cbListaInc.Name = "cbListaInc";
            this.cbListaInc.Size = new System.Drawing.Size(113, 17);
            this.cbListaInc.TabIndex = 2;
            this.cbListaInc.Text = "Mostrar Incertezas";
            this.cbListaInc.UseVisualStyleBackColor = true;
            this.cbListaInc.CheckStateChanged += new System.EventHandler(this.cbListaInc_CheckStateChanged);
            // 
            // dgvIncertezas
            // 
            this.dgvIncertezas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncertezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncertezas.Location = new System.Drawing.Point(6, 210);
            this.dgvIncertezas.Name = "dgvIncertezas";
            this.dgvIncertezas.Size = new System.Drawing.Size(263, 102);
            this.dgvIncertezas.TabIndex = 1;
            this.dgvIncertezas.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvIncertezas_UserDeletingRow);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(275, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(108, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TabControlPrincipal);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(861, 384);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(969, 413);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KILL THE RELATÓRIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControlPrincipal.ResumeLayout(false);
            this.tabPageHistograma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistograma)).EndInit();
            this.tabPageLogLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLogLog)).EndInit();
            this.tabPageTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimples)).EndInit();
            this.tabPageOcorrencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControlOpcoes.ResumeLayout(false);
            this.tabPageIncertezas.ResumeLayout(false);
            this.tabPageIncertezas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncertezas)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ToolStripMenuItem médiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritméticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadráticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harmônicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geométricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incertezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PadraoDigitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leituraAnalogicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoesRepetidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem desvioPadrãoExperimentalToolStripMenuItem;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TabControl TabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageHistograma;
        private System.Windows.Forms.TabPage tabPageLogLog;
        private System.Windows.Forms.ToolStripMenuItem histogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoLogLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem padraoCombinadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageTabela;
        private System.Windows.Forms.ToolStripMenuItem simplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deOcorrenciasToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageOcorrencias;
        private System.Windows.Forms.DataGridView dgvSimples;
        private System.Windows.Forms.DataGridView dgvOcorrencias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistograma;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLogLog;
        private System.Windows.Forms.TabControl tabControlOpcoes;
        private System.Windows.Forms.TabPage tabPageIncertezas;
        private System.Windows.Forms.DataGridView dgvIncertezas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbListaInc;
    }
}

