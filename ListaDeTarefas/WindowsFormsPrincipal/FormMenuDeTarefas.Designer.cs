namespace WindowsFormsPrincipal
{
    partial class FormMenuDeTarefas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonGrupo3 = new System.Windows.Forms.Button();
            this.buttonGrupo2 = new System.Windows.Forms.Button();
            this.buttonGrupo1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxAtribuicao = new System.Windows.Forms.CheckBox();
            this.checkBoxAtrasado = new System.Windows.Forms.CheckBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.tarefaDataGridView = new System.Windows.Forms.DataGridView();
            this.etapaDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSair = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(485, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tarefas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.buttonGrupo3);
            this.panel2.Controls.Add(this.buttonGrupo2);
            this.panel2.Controls.Add(this.buttonGrupo1);
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 478);
            this.panel2.TabIndex = 5;
            // 
            // buttonGrupo3
            // 
            this.buttonGrupo3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrupo3.Location = new System.Drawing.Point(0, 395);
            this.buttonGrupo3.Name = "buttonGrupo3";
            this.buttonGrupo3.Size = new System.Drawing.Size(162, 35);
            this.buttonGrupo3.TabIndex = 1;
            this.buttonGrupo3.Text = "Grupo 3";
            this.buttonGrupo3.UseVisualStyleBackColor = true;
            // 
            // buttonGrupo2
            // 
            this.buttonGrupo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrupo2.Location = new System.Drawing.Point(0, 363);
            this.buttonGrupo2.Name = "buttonGrupo2";
            this.buttonGrupo2.Size = new System.Drawing.Size(162, 35);
            this.buttonGrupo2.TabIndex = 2;
            this.buttonGrupo2.Text = "Grupo 2";
            this.buttonGrupo2.UseVisualStyleBackColor = true;
            // 
            // buttonGrupo1
            // 
            this.buttonGrupo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrupo1.Location = new System.Drawing.Point(0, 331);
            this.buttonGrupo1.Name = "buttonGrupo1";
            this.buttonGrupo1.Size = new System.Drawing.Size(162, 35);
            this.buttonGrupo1.TabIndex = 3;
            this.buttonGrupo1.Text = "Grupo 1";
            this.buttonGrupo1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 100);
            this.panel1.TabIndex = 4;
            // 
            // checkBoxAtribuicao
            // 
            this.checkBoxAtribuicao.AutoSize = true;
            this.checkBoxAtribuicao.Location = new System.Drawing.Point(812, 126);
            this.checkBoxAtribuicao.Name = "checkBoxAtribuicao";
            this.checkBoxAtribuicao.Size = new System.Drawing.Size(128, 20);
            this.checkBoxAtribuicao.TabIndex = 8;
            this.checkBoxAtribuicao.Text = "Atribuidas a mim";
            this.checkBoxAtribuicao.UseVisualStyleBackColor = true;
            this.checkBoxAtribuicao.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxAtrasado
            // 
            this.checkBoxAtrasado.AutoSize = true;
            this.checkBoxAtrasado.Location = new System.Drawing.Point(715, 126);
            this.checkBoxAtrasado.Name = "checkBoxAtrasado";
            this.checkBoxAtrasado.Size = new System.Drawing.Size(91, 20);
            this.checkBoxAtrasado.TabIndex = 8;
            this.checkBoxAtrasado.Text = "Em Atraso";
            this.checkBoxAtrasado.UseVisualStyleBackColor = true;
            this.checkBoxAtrasado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Location = new System.Drawing.Point(252, 152);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(362, 28);
            this.textBoxBuscar.TabIndex = 9;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInserir.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonInserir.Location = new System.Drawing.Point(703, 153);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 26);
            this.buttonInserir.TabIndex = 10;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlterar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAlterar.Location = new System.Drawing.Point(784, 152);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 26);
            this.buttonAlterar.TabIndex = 10;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDeletar.Location = new System.Drawing.Point(865, 152);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 26);
            this.buttonDeletar.TabIndex = 10;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscar.Location = new System.Drawing.Point(620, 154);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 26);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // tarefaDataGridView
            // 
            this.tarefaDataGridView.AllowUserToAddRows = false;
            this.tarefaDataGridView.AllowUserToDeleteRows = false;
            this.tarefaDataGridView.AutoGenerateColumns = false;
            this.tarefaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tarefaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.tarefaDataGridView.DataSource = this.tarefaBindingSource;
            this.tarefaDataGridView.Location = new System.Drawing.Point(252, 202);
            this.tarefaDataGridView.Name = "tarefaDataGridView";
            this.tarefaDataGridView.ReadOnly = true;
            this.tarefaDataGridView.RowHeadersWidth = 51;
            this.tarefaDataGridView.RowTemplate.Height = 24;
            this.tarefaDataGridView.Size = new System.Drawing.Size(333, 324);
            this.tarefaDataGridView.TabIndex = 11;
            // 
            // etapaDataGridView
            // 
            this.etapaDataGridView.AllowUserToAddRows = false;
            this.etapaDataGridView.AllowUserToDeleteRows = false;
            this.etapaDataGridView.AutoGenerateColumns = false;
            this.etapaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.etapaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.etapaDataGridView.DataSource = this.etapaBindingSource;
            this.etapaDataGridView.Location = new System.Drawing.Point(607, 202);
            this.etapaDataGridView.Name = "etapaDataGridView";
            this.etapaDataGridView.ReadOnly = true;
            this.etapaDataGridView.RowHeadersWidth = 51;
            this.etapaDataGridView.RowTemplate.Height = 24;
            this.etapaDataGridView.Size = new System.Drawing.Size(333, 324);
            this.etapaDataGridView.TabIndex = 11;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Red;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSair.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSair.Location = new System.Drawing.Point(862, 554);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(74, 33);
            this.buttonSair.TabIndex = 12;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeEtapa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Etapas";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // etapaBindingSource
            // 
            this.etapaBindingSource.DataMember = "Etapa";
            this.etapaBindingSource.DataSource = this.tarefaBindingSource;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataSource = typeof(Models.Tarefa);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeTarefa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tarefas";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FormMenuDeTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1012, 594);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.etapaDataGridView);
            this.Controls.Add(this.tarefaDataGridView);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.checkBoxAtrasado);
            this.Controls.Add(this.checkBoxAtribuicao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FormMenuDeTarefas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormMenuDeTarefas";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGrupo3;
        private System.Windows.Forms.Button buttonGrupo2;
        private System.Windows.Forms.Button buttonGrupo1;
        private System.Windows.Forms.CheckBox checkBoxAtribuicao;
        private System.Windows.Forms.CheckBox checkBoxAtrasado;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private System.Windows.Forms.DataGridView tarefaDataGridView;
        private System.Windows.Forms.BindingSource etapaBindingSource;
        private System.Windows.Forms.DataGridView etapaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonSair;
    }
}