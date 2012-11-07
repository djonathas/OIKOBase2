namespace Oiko
{
    partial class Form6_Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6_Relatorio));
            this.tabControl_A3_Relatorios_CRD = new System.Windows.Forms.TabControl();
            this.tabPage_A3_ReceDesp = new System.Windows.Forms.TabPage();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.panel_A3_BarGrafi_RecDesp = new System.Windows.Forms.Panel();
            this.label_A3_Grafi_RecDesp = new System.Windows.Forms.Label();
            this.tabPage_A3_LancCategoria = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.groupBox_A3_GrafiReceita = new System.Windows.Forms.GroupBox();
            this.listView_A3_ReceitaCatog = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_A3_BarReceita = new System.Windows.Forms.Panel();
            this.label_A3_BarReceita = new System.Windows.Forms.Label();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.groupBox_A3_GrafiDespesas = new System.Windows.Forms.GroupBox();
            this.listView_A3_DepesaCatog = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_A3_BarDespesas = new System.Windows.Forms.Panel();
            this.label_A3_BarDespesas = new System.Windows.Forms.Label();
            this.tabControl_A3_Relatorios_CRD.SuspendLayout();
            this.tabPage_A3_ReceDesp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.SuspendLayout();
            this.panel_A3_BarGrafi_RecDesp.SuspendLayout();
            this.tabPage_A3_LancCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.panel_A3_BarReceita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this.panel_A3_BarDespesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_A3_Relatorios_CRD
            // 
            this.tabControl_A3_Relatorios_CRD.Controls.Add(this.tabPage_A3_ReceDesp);
            this.tabControl_A3_Relatorios_CRD.Controls.Add(this.tabPage_A3_LancCategoria);
            this.tabControl_A3_Relatorios_CRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_A3_Relatorios_CRD.ItemSize = new System.Drawing.Size(185, 25);
            this.tabControl_A3_Relatorios_CRD.Location = new System.Drawing.Point(0, 0);
            this.tabControl_A3_Relatorios_CRD.Name = "tabControl_A3_Relatorios_CRD";
            this.tabControl_A3_Relatorios_CRD.Padding = new System.Drawing.Point(3, 3);
            this.tabControl_A3_Relatorios_CRD.SelectedIndex = 0;
            this.tabControl_A3_Relatorios_CRD.Size = new System.Drawing.Size(1002, 539);
            this.tabControl_A3_Relatorios_CRD.TabIndex = 14;
            // 
            // tabPage_A3_ReceDesp
            // 
            this.tabPage_A3_ReceDesp.Controls.Add(this.splitContainer11);
            this.tabPage_A3_ReceDesp.Controls.Add(this.panel_A3_BarGrafi_RecDesp);
            this.tabPage_A3_ReceDesp.Location = new System.Drawing.Point(4, 29);
            this.tabPage_A3_ReceDesp.Name = "tabPage_A3_ReceDesp";
            this.tabPage_A3_ReceDesp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_A3_ReceDesp.Size = new System.Drawing.Size(994, 506);
            this.tabPage_A3_ReceDesp.TabIndex = 1;
            this.tabPage_A3_ReceDesp.Text = "Gráfico - Recetias X Despesas";
            this.tabPage_A3_ReceDesp.UseVisualStyleBackColor = true;
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.Location = new System.Drawing.Point(3, 29);
            this.splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer11.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer11.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer11.Size = new System.Drawing.Size(988, 474);
            this.splitContainer11.SplitterDistance = 499;
            this.splitContainer11.TabIndex = 12;
            // 
            // panel_A3_BarGrafi_RecDesp
            // 
            this.panel_A3_BarGrafi_RecDesp.BackColor = System.Drawing.Color.SlateGray;
            this.panel_A3_BarGrafi_RecDesp.Controls.Add(this.label_A3_Grafi_RecDesp);
            this.panel_A3_BarGrafi_RecDesp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_A3_BarGrafi_RecDesp.Location = new System.Drawing.Point(3, 3);
            this.panel_A3_BarGrafi_RecDesp.Name = "panel_A3_BarGrafi_RecDesp";
            this.panel_A3_BarGrafi_RecDesp.Size = new System.Drawing.Size(988, 26);
            this.panel_A3_BarGrafi_RecDesp.TabIndex = 10;
            // 
            // label_A3_Grafi_RecDesp
            // 
            this.label_A3_Grafi_RecDesp.AutoSize = true;
            this.label_A3_Grafi_RecDesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_A3_Grafi_RecDesp.ForeColor = System.Drawing.Color.White;
            this.label_A3_Grafi_RecDesp.Location = new System.Drawing.Point(3, 4);
            this.label_A3_Grafi_RecDesp.Name = "label_A3_Grafi_RecDesp";
            this.label_A3_Grafi_RecDesp.Size = new System.Drawing.Size(288, 18);
            this.label_A3_Grafi_RecDesp.TabIndex = 14;
            this.label_A3_Grafi_RecDesp.Text = "GRÁFICO - RECEITAS X DESPESAS";
            // 
            // tabPage_A3_LancCategoria
            // 
            this.tabPage_A3_LancCategoria.Controls.Add(this.splitContainer7);
            this.tabPage_A3_LancCategoria.Location = new System.Drawing.Point(4, 29);
            this.tabPage_A3_LancCategoria.Name = "tabPage_A3_LancCategoria";
            this.tabPage_A3_LancCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_A3_LancCategoria.Size = new System.Drawing.Size(994, 506);
            this.tabPage_A3_LancCategoria.TabIndex = 0;
            this.tabPage_A3_LancCategoria.Text = "Gráfico - Lançamentos por Categorias";
            this.tabPage_A3_LancCategoria.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.splitContainer8);
            this.splitContainer7.Panel1.Controls.Add(this.panel_A3_BarReceita);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.splitContainer9);
            this.splitContainer7.Panel2.Controls.Add(this.panel_A3_BarDespesas);
            this.splitContainer7.Size = new System.Drawing.Size(988, 500);
            this.splitContainer7.SplitterDistance = 261;
            this.splitContainer7.TabIndex = 0;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 26);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.groupBox_A3_GrafiReceita);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.listView_A3_ReceitaCatog);
            this.splitContainer8.Size = new System.Drawing.Size(988, 235);
            this.splitContainer8.SplitterDistance = 473;
            this.splitContainer8.TabIndex = 10;
            // 
            // groupBox_A3_GrafiReceita
            // 
            this.groupBox_A3_GrafiReceita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_A3_GrafiReceita.Location = new System.Drawing.Point(0, 0);
            this.groupBox_A3_GrafiReceita.Name = "groupBox_A3_GrafiReceita";
            this.groupBox_A3_GrafiReceita.Size = new System.Drawing.Size(473, 235);
            this.groupBox_A3_GrafiReceita.TabIndex = 10;
            this.groupBox_A3_GrafiReceita.TabStop = false;
            this.groupBox_A3_GrafiReceita.Text = "Gráfico";
            // 
            // listView_A3_ReceitaCatog
            // 
            this.listView_A3_ReceitaCatog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader12,
            this.columnHeader13});
            this.listView_A3_ReceitaCatog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_A3_ReceitaCatog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_A3_ReceitaCatog.GridLines = true;
            this.listView_A3_ReceitaCatog.Location = new System.Drawing.Point(0, 0);
            this.listView_A3_ReceitaCatog.Name = "listView_A3_ReceitaCatog";
            this.listView_A3_ReceitaCatog.Size = new System.Drawing.Size(511, 235);
            this.listView_A3_ReceitaCatog.TabIndex = 8;
            this.listView_A3_ReceitaCatog.UseCompatibleStateImageBehavior = false;
            this.listView_A3_ReceitaCatog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Categoria";
            this.columnHeader6.Width = 372;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 39;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Valor";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 71;
            // 
            // panel_A3_BarReceita
            // 
            this.panel_A3_BarReceita.BackColor = System.Drawing.Color.ForestGreen;
            this.panel_A3_BarReceita.Controls.Add(this.label_A3_BarReceita);
            this.panel_A3_BarReceita.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_A3_BarReceita.Location = new System.Drawing.Point(0, 0);
            this.panel_A3_BarReceita.Name = "panel_A3_BarReceita";
            this.panel_A3_BarReceita.Size = new System.Drawing.Size(988, 26);
            this.panel_A3_BarReceita.TabIndex = 9;
            // 
            // label_A3_BarReceita
            // 
            this.label_A3_BarReceita.AutoSize = true;
            this.label_A3_BarReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_A3_BarReceita.ForeColor = System.Drawing.Color.White;
            this.label_A3_BarReceita.Location = new System.Drawing.Point(3, 4);
            this.label_A3_BarReceita.Name = "label_A3_BarReceita";
            this.label_A3_BarReceita.Size = new System.Drawing.Size(89, 18);
            this.label_A3_BarReceita.TabIndex = 14;
            this.label_A3_BarReceita.Text = "RECEITAS";
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Location = new System.Drawing.Point(0, 26);
            this.splitContainer9.Name = "splitContainer9";
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.groupBox_A3_GrafiDespesas);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.listView_A3_DepesaCatog);
            this.splitContainer9.Size = new System.Drawing.Size(988, 209);
            this.splitContainer9.SplitterDistance = 473;
            this.splitContainer9.TabIndex = 13;
            // 
            // groupBox_A3_GrafiDespesas
            // 
            this.groupBox_A3_GrafiDespesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_A3_GrafiDespesas.Location = new System.Drawing.Point(0, 0);
            this.groupBox_A3_GrafiDespesas.Name = "groupBox_A3_GrafiDespesas";
            this.groupBox_A3_GrafiDespesas.Size = new System.Drawing.Size(473, 209);
            this.groupBox_A3_GrafiDespesas.TabIndex = 13;
            this.groupBox_A3_GrafiDespesas.TabStop = false;
            this.groupBox_A3_GrafiDespesas.Text = "Gráfico";
            // 
            // listView_A3_DepesaCatog
            // 
            this.listView_A3_DepesaCatog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.listView_A3_DepesaCatog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_A3_DepesaCatog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_A3_DepesaCatog.GridLines = true;
            this.listView_A3_DepesaCatog.Location = new System.Drawing.Point(0, 0);
            this.listView_A3_DepesaCatog.Name = "listView_A3_DepesaCatog";
            this.listView_A3_DepesaCatog.Size = new System.Drawing.Size(511, 209);
            this.listView_A3_DepesaCatog.TabIndex = 11;
            this.listView_A3_DepesaCatog.UseCompatibleStateImageBehavior = false;
            this.listView_A3_DepesaCatog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Categoria";
            this.columnHeader14.Width = 372;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 39;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Valor";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 86;
            // 
            // panel_A3_BarDespesas
            // 
            this.panel_A3_BarDespesas.BackColor = System.Drawing.Color.Red;
            this.panel_A3_BarDespesas.Controls.Add(this.label_A3_BarDespesas);
            this.panel_A3_BarDespesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_A3_BarDespesas.Location = new System.Drawing.Point(0, 0);
            this.panel_A3_BarDespesas.Name = "panel_A3_BarDespesas";
            this.panel_A3_BarDespesas.Size = new System.Drawing.Size(988, 26);
            this.panel_A3_BarDespesas.TabIndex = 12;
            // 
            // label_A3_BarDespesas
            // 
            this.label_A3_BarDespesas.AutoSize = true;
            this.label_A3_BarDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_A3_BarDespesas.ForeColor = System.Drawing.Color.White;
            this.label_A3_BarDespesas.Location = new System.Drawing.Point(3, 4);
            this.label_A3_BarDespesas.Name = "label_A3_BarDespesas";
            this.label_A3_BarDespesas.Size = new System.Drawing.Size(96, 18);
            this.label_A3_BarDespesas.TabIndex = 14;
            this.label_A3_BarDespesas.Text = "DESPESAS";
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 539);
            this.Controls.Add(this.tabControl_A3_Relatorios_CRD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio";
            this.Text = "Relatorio - Oiko";
            this.tabControl_A3_Relatorios_CRD.ResumeLayout(false);
            this.tabPage_A3_ReceDesp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            this.panel_A3_BarGrafi_RecDesp.ResumeLayout(false);
            this.panel_A3_BarGrafi_RecDesp.PerformLayout();
            this.tabPage_A3_LancCategoria.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.panel_A3_BarReceita.ResumeLayout(false);
            this.panel_A3_BarReceita.PerformLayout();
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.panel_A3_BarDespesas.ResumeLayout(false);
            this.panel_A3_BarDespesas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_A3_Relatorios_CRD;
        private System.Windows.Forms.TabPage tabPage_A3_ReceDesp;
        private System.Windows.Forms.SplitContainer splitContainer11;
        private System.Windows.Forms.Panel panel_A3_BarGrafi_RecDesp;
        private System.Windows.Forms.Label label_A3_Grafi_RecDesp;
        private System.Windows.Forms.TabPage tabPage_A3_LancCategoria;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.GroupBox groupBox_A3_GrafiReceita;
        private System.Windows.Forms.ListView listView_A3_ReceitaCatog;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Panel panel_A3_BarReceita;
        private System.Windows.Forms.Label label_A3_BarReceita;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.GroupBox groupBox_A3_GrafiDespesas;
        private System.Windows.Forms.ListView listView_A3_DepesaCatog;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Panel panel_A3_BarDespesas;
        private System.Windows.Forms.Label label_A3_BarDespesas;
    }
}