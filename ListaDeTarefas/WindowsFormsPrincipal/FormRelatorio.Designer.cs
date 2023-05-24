﻿namespace WindowsFormsPrincipal
{
    partial class FormRelatorio
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxCrescente = new System.Windows.Forms.CheckBox();
            this.checkBoxDecrescente = new System.Windows.Forms.CheckBox();
            this.contextMenuStripPermissao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.contextMenuStripPermissao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 87);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(213, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Relatorio de pontos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.usuarioDataGridView.ContextMenuStrip = this.contextMenuStripPermissao;
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(191, 197);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.RowHeadersWidth = 51;
            this.usuarioDataGridView.RowTemplate.Height = 24;
            this.usuarioDataGridView.Size = new System.Drawing.Size(444, 359);
            this.usuarioDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn5.HeaderText = "Score";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // checkBoxCrescente
            // 
            this.checkBoxCrescente.AutoSize = true;
            this.checkBoxCrescente.Location = new System.Drawing.Point(501, 156);
            this.checkBoxCrescente.Name = "checkBoxCrescente";
            this.checkBoxCrescente.Size = new System.Drawing.Size(134, 20);
            this.checkBoxCrescente.TabIndex = 8;
            this.checkBoxCrescente.Text = "Ordem Crescente";
            this.checkBoxCrescente.UseVisualStyleBackColor = true;
            this.checkBoxCrescente.CheckedChanged += new System.EventHandler(this.checkBoxCrescente_CheckedChanged);
            // 
            // checkBoxDecrescente
            // 
            this.checkBoxDecrescente.AutoSize = true;
            this.checkBoxDecrescente.Checked = true;
            this.checkBoxDecrescente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDecrescente.Location = new System.Drawing.Point(191, 156);
            this.checkBoxDecrescente.Name = "checkBoxDecrescente";
            this.checkBoxDecrescente.Size = new System.Drawing.Size(148, 20);
            this.checkBoxDecrescente.TabIndex = 9;
            this.checkBoxDecrescente.Text = "Ordem decrescente";
            this.checkBoxDecrescente.UseVisualStyleBackColor = true;
            this.checkBoxDecrescente.CheckedChanged += new System.EventHandler(this.checkBoxDecrescente_CheckedChanged);
            // 
            // contextMenuStripPermissao
            // 
            this.contextMenuStripPermissao.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPermissao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem,
            this.padrãoToolStripMenuItem});
            this.contextMenuStripPermissao.Name = "contextMenuStripPermissao";
            this.contextMenuStripPermissao.Size = new System.Drawing.Size(142, 52);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // padrãoToolStripMenuItem
            // 
            this.padrãoToolStripMenuItem.Name = "padrãoToolStripMenuItem";
            this.padrãoToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.padrãoToolStripMenuItem.Text = "Padrão";
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 568);
            this.Controls.Add(this.checkBoxDecrescente);
            this.Controls.Add(this.checkBoxCrescente);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRelatorio_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.contextMenuStripPermissao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.CheckBox checkBoxCrescente;
        private System.Windows.Forms.CheckBox checkBoxDecrescente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPermissao;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem padrãoToolStripMenuItem;
    }
}