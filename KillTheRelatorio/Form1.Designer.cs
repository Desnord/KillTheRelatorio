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
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritméticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadráticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harmônicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geométricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponderadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incertezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PadraoDigitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leituraAnalogicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoesRepetidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.desvioPadrãoExperimentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.médiasToolStripMenuItem,
            this.incertezasToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // médiasToolStripMenuItem
            // 
            this.médiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritméticaToolStripMenuItem,
            this.quadráticaToolStripMenuItem,
            this.harmônicaToolStripMenuItem,
            this.geométricaToolStripMenuItem,
            this.ponderadaToolStripMenuItem});
            this.médiasToolStripMenuItem.Name = "médiasToolStripMenuItem";
            this.médiasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
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
            // ponderadaToolStripMenuItem
            // 
            this.ponderadaToolStripMenuItem.Name = "ponderadaToolStripMenuItem";
            this.ponderadaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ponderadaToolStripMenuItem.Text = "Ponderada";
            this.ponderadaToolStripMenuItem.Click += new System.EventHandler(this.ponderadaToolStripMenuItem_Click);
            // 
            // incertezasToolStripMenuItem
            // 
            this.incertezasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PadraoDigitalToolStripMenuItem,
            this.leituraAnalogicaToolStripMenuItem,
            this.medicoesRepetidasToolStripMenuItem,
            this.toolStripSeparator1,
            this.desvioPadrãoExperimentalToolStripMenuItem});
            this.incertezasToolStripMenuItem.Name = "incertezasToolStripMenuItem";
            this.incertezasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
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
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.BackColor = System.Drawing.SystemColors.Window;
            this.lblResultado.Location = new System.Drawing.Point(12, 39);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(632, 27);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtA);
            this.panel1.Location = new System.Drawing.Point(15, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 329);
            this.panel1.TabIndex = 2;
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
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(6, 28);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(656, 426);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem ponderadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incertezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PadraoDigitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leituraAnalogicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoesRepetidasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem desvioPadrãoExperimentalToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
    }
}

