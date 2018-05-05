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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtA = new System.Windows.Forms.TextBox();
            this.TabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageHistograma = new System.Windows.Forms.TabPage();
            this.tabPageLogLog = new System.Windows.Forms.TabPage();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoLogLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padraoCombinadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageTabela = new System.Windows.Forms.TabPage();
            this.tabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deOcorrenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageOcorrencias = new System.Windows.Forms.TabPage();
            this.dgvSimples = new System.Windows.Forms.DataGridView();
            this.dgvOcorrencias = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabControlPrincipal.SuspendLayout();
            this.tabPageTabela.SuspendLayout();
            this.tabPageOcorrencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
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
            this.menuStrip1.Size = new System.Drawing.Size(108, 413);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.aritméticaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aritméticaToolStripMenuItem.Text = "Aritmética";
            this.aritméticaToolStripMenuItem.Click += new System.EventHandler(this.aritmeticaToolStripMenuItem_Click);
            // 
            // quadráticaToolStripMenuItem
            // 
            this.quadráticaToolStripMenuItem.Name = "quadráticaToolStripMenuItem";
            this.quadráticaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quadráticaToolStripMenuItem.Text = "Quadrática";
            this.quadráticaToolStripMenuItem.Click += new System.EventHandler(this.quadraticaToolStripMenuItem_Click);
            // 
            // harmônicaToolStripMenuItem
            // 
            this.harmônicaToolStripMenuItem.Name = "harmônicaToolStripMenuItem";
            this.harmônicaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.harmônicaToolStripMenuItem.Text = "Harmônica";
            this.harmônicaToolStripMenuItem.Click += new System.EventHandler(this.harmonicaToolStripMenuItem_Click);
            // 
            // geométricaToolStripMenuItem
            // 
            this.geométricaToolStripMenuItem.Name = "geométricaToolStripMenuItem";
            this.geométricaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.BackColor = System.Drawing.SystemColors.Window;
            this.lblResultado.Location = new System.Drawing.Point(117, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(840, 32);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtA);
            this.panel1.Location = new System.Drawing.Point(111, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 345);
            this.panel1.TabIndex = 2;
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(3, 3);
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
            this.TabControlPrincipal.Location = new System.Drawing.Point(489, 56);
            this.TabControlPrincipal.Name = "TabControlPrincipal";
            this.TabControlPrincipal.SelectedIndex = 0;
            this.TabControlPrincipal.Size = new System.Drawing.Size(468, 345);
            this.TabControlPrincipal.TabIndex = 3;
            // 
            // tabPageHistograma
            // 
            this.tabPageHistograma.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistograma.Name = "tabPageHistograma";
            this.tabPageHistograma.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistograma.Size = new System.Drawing.Size(460, 319);
            this.tabPageHistograma.TabIndex = 0;
            this.tabPageHistograma.Text = "histograma";
            this.tabPageHistograma.UseVisualStyleBackColor = true;
            // 
            // tabPageLogLog
            // 
            this.tabPageLogLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogLog.Name = "tabPageLogLog";
            this.tabPageLogLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogLog.Size = new System.Drawing.Size(460, 319);
            this.tabPageLogLog.TabIndex = 1;
            this.tabPageLogLog.Text = "log-log";
            this.tabPageLogLog.UseVisualStyleBackColor = true;
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // histogramaToolStripMenuItem
            // 
            this.histogramaToolStripMenuItem.Name = "histogramaToolStripMenuItem";
            this.histogramaToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.histogramaToolStripMenuItem.Text = "Histograma";
            this.histogramaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // gráficoLogLogToolStripMenuItem
            // 
            this.gráficoLogLogToolStripMenuItem.Name = "gráficoLogLogToolStripMenuItem";
            this.gráficoLogLogToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.gráficoLogLogToolStripMenuItem.Text = "Gráfico Log-Log";
            this.gráficoLogLogToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // padraoCombinadaToolStripMenuItem
            // 
            this.padraoCombinadaToolStripMenuItem.Name = "padraoCombinadaToolStripMenuItem";
            this.padraoCombinadaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.padraoCombinadaToolStripMenuItem.Text = "Padrão Combinada";
            this.padraoCombinadaToolStripMenuItem.Click += new System.EventHandler(this.padraoCombinadaToolStripMenuItem_Click);
            // 
            // tabPageTabela
            // 
            this.tabPageTabela.Controls.Add(this.dgvSimples);
            this.tabPageTabela.Location = new System.Drawing.Point(4, 22);
            this.tabPageTabela.Name = "tabPageTabela";
            this.tabPageTabela.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTabela.Size = new System.Drawing.Size(460, 319);
            this.tabPageTabela.TabIndex = 2;
            this.tabPageTabela.Text = "tabela simples";
            this.tabPageTabela.UseVisualStyleBackColor = true;
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
            // tabPageOcorrencias
            // 
            this.tabPageOcorrencias.Controls.Add(this.dgvOcorrencias);
            this.tabPageOcorrencias.Location = new System.Drawing.Point(4, 22);
            this.tabPageOcorrencias.Name = "tabPageOcorrencias";
            this.tabPageOcorrencias.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOcorrencias.Size = new System.Drawing.Size(460, 319);
            this.tabPageOcorrencias.TabIndex = 3;
            this.tabPageOcorrencias.Text = "tabela de ocorrencias";
            this.tabPageOcorrencias.UseVisualStyleBackColor = true;
            // 
            // dgvSimples
            // 
            this.dgvSimples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSimples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimples.Location = new System.Drawing.Point(6, 6);
            this.dgvSimples.Name = "dgvSimples";
            this.dgvSimples.Size = new System.Drawing.Size(448, 307);
            this.dgvSimples.TabIndex = 0;
            // 
            // dgvOcorrencias
            // 
            this.dgvOcorrencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOcorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcorrencias.Location = new System.Drawing.Point(7, 7);
            this.dgvOcorrencias.Name = "dgvOcorrencias";
            this.dgvOcorrencias.Size = new System.Drawing.Size(450, 306);
            this.dgvOcorrencias.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(969, 413);
            this.Controls.Add(this.TabControlPrincipal);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KILL THE RELATÓRIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabControlPrincipal.ResumeLayout(false);
            this.tabPageTabela.ResumeLayout(false);
            this.tabPageOcorrencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
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
    }
}

