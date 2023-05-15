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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxAtribuicao = new System.Windows.Forms.CheckBox();
            this.checkBoxAtrasado = new System.Windows.Forms.CheckBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonDeletarEtapa = new System.Windows.Forms.Button();
            this.buttonAlterarEtapa = new System.Windows.Forms.Button();
            this.buttonInserirEtapa = new System.Windows.Forms.Button();
            this.buttonConvidarUsuario = new System.Windows.Forms.Button();
            this.buttonConcluir = new System.Windows.Forms.Button();
            this.tarefaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarefaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTarefaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etapaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaDataGridView)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 590);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 100);
            this.panel1.TabIndex = 4;
            // 
            // checkBoxAtribuicao
            // 
            this.checkBoxAtribuicao.AutoSize = true;
            this.checkBoxAtribuicao.Location = new System.Drawing.Point(477, 191);
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
            this.checkBoxAtrasado.Location = new System.Drawing.Point(369, 191);
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
            this.textBoxBuscar.Location = new System.Drawing.Point(272, 217);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(333, 28);
            this.textBoxBuscar.TabIndex = 9;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInserir.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonInserir.Location = new System.Drawing.Point(357, 251);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 26);
            this.buttonInserir.TabIndex = 10;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlterar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAlterar.Location = new System.Drawing.Point(443, 251);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 26);
            this.buttonAlterar.TabIndex = 10;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDeletar.Location = new System.Drawing.Point(530, 251);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 26);
            this.buttonDeletar.TabIndex = 10;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = false;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscar.Location = new System.Drawing.Point(272, 251);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 26);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Red;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSair.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSair.Location = new System.Drawing.Point(886, 635);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(74, 33);
            this.buttonSair.TabIndex = 12;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click_1);
            // 
            // buttonDeletarEtapa
            // 
            this.buttonDeletarEtapa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDeletarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletarEtapa.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDeletarEtapa.Location = new System.Drawing.Point(801, 251);
            this.buttonDeletarEtapa.Name = "buttonDeletarEtapa";
            this.buttonDeletarEtapa.Size = new System.Drawing.Size(75, 26);
            this.buttonDeletarEtapa.TabIndex = 14;
            this.buttonDeletarEtapa.Text = "Deletar";
            this.buttonDeletarEtapa.UseVisualStyleBackColor = false;
            this.buttonDeletarEtapa.Click += new System.EventHandler(this.buttonDeletarEtapa_Click_1);
            // 
            // buttonAlterarEtapa
            // 
            this.buttonAlterarEtapa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAlterarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlterarEtapa.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAlterarEtapa.Location = new System.Drawing.Point(714, 251);
            this.buttonAlterarEtapa.Name = "buttonAlterarEtapa";
            this.buttonAlterarEtapa.Size = new System.Drawing.Size(75, 26);
            this.buttonAlterarEtapa.TabIndex = 15;
            this.buttonAlterarEtapa.Text = "Alterar";
            this.buttonAlterarEtapa.UseVisualStyleBackColor = false;
            this.buttonAlterarEtapa.Click += new System.EventHandler(this.buttonAlterarEtapa_Click);
            // 
            // buttonInserirEtapa
            // 
            this.buttonInserirEtapa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonInserirEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInserirEtapa.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonInserirEtapa.Location = new System.Drawing.Point(628, 251);
            this.buttonInserirEtapa.Name = "buttonInserirEtapa";
            this.buttonInserirEtapa.Size = new System.Drawing.Size(75, 26);
            this.buttonInserirEtapa.TabIndex = 16;
            this.buttonInserirEtapa.Text = "Inserir";
            this.buttonInserirEtapa.UseVisualStyleBackColor = false;
            this.buttonInserirEtapa.Click += new System.EventHandler(this.buttonInserirEtapa_Click);
            // 
            // buttonConvidarUsuario
            // 
            this.buttonConvidarUsuario.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonConvidarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConvidarUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonConvidarUsuario.Location = new System.Drawing.Point(721, 635);
            this.buttonConvidarUsuario.Name = "buttonConvidarUsuario";
            this.buttonConvidarUsuario.Size = new System.Drawing.Size(141, 33);
            this.buttonConvidarUsuario.TabIndex = 17;
            this.buttonConvidarUsuario.Text = "Convidar Usuários";
            this.buttonConvidarUsuario.UseVisualStyleBackColor = false;
            // 
            // buttonConcluir
            // 
            this.buttonConcluir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConcluir.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonConcluir.Location = new System.Drawing.Point(886, 251);
            this.buttonConcluir.Name = "buttonConcluir";
            this.buttonConcluir.Size = new System.Drawing.Size(75, 26);
            this.buttonConcluir.TabIndex = 18;
            this.buttonConcluir.Text = "Concluir";
            this.buttonConcluir.UseVisualStyleBackColor = false;
            // 
            // tarefaDataGridView
            // 
            this.tarefaDataGridView.AllowUserToAddRows = false;
            this.tarefaDataGridView.AllowUserToDeleteRows = false;
            this.tarefaDataGridView.AllowUserToOrderColumns = true;
            this.tarefaDataGridView.AutoGenerateColumns = false;
            this.tarefaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tarefaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.tarefaDataGridView.DataSource = this.tarefaBindingSource1;
            this.tarefaDataGridView.Location = new System.Drawing.Point(272, 283);
            this.tarefaDataGridView.Name = "tarefaDataGridView";
            this.tarefaDataGridView.ReadOnly = true;
            this.tarefaDataGridView.RowHeadersWidth = 51;
            this.tarefaDataGridView.RowTemplate.Height = 24;
            this.tarefaDataGridView.Size = new System.Drawing.Size(333, 346);
            this.tarefaDataGridView.TabIndex = 18;
            this.tarefaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tarefaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeTarefa";
            this.dataGridViewTextBoxColumn3.HeaderText = "NomeTarefa";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tarefaBindingSource1
            // 
            this.tarefaBindingSource1.DataSource = typeof(Models.Tarefa);
            this.tarefaBindingSource1.CurrentChanged += new System.EventHandler(this.tarefaBindingSource1_CurrentChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeTarefaDataGridViewTextBoxColumn
            // 
            this.nomeTarefaDataGridViewTextBoxColumn.DataPropertyName = "NomeTarefa";
            this.nomeTarefaDataGridViewTextBoxColumn.HeaderText = "NomeTarefa";
            this.nomeTarefaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeTarefaDataGridViewTextBoxColumn.Name = "nomeTarefaDataGridViewTextBoxColumn";
            this.nomeTarefaDataGridViewTextBoxColumn.Width = 125;
            // 
            // etapaBindingSource
            // 
            this.etapaBindingSource.DataMember = "Etapa";
            this.etapaBindingSource.DataSource = this.tarefaBindingSource1;
            // 
            // etapaDataGridView
            // 
            this.etapaDataGridView.AllowUserToAddRows = false;
            this.etapaDataGridView.AllowUserToDeleteRows = false;
            this.etapaDataGridView.AllowUserToOrderColumns = true;
            this.etapaDataGridView.AutoGenerateColumns = false;
            this.etapaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.etapaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.etapaDataGridView.DataSource = this.etapaBindingSource;
            this.etapaDataGridView.Location = new System.Drawing.Point(628, 283);
            this.etapaDataGridView.Name = "etapaDataGridView";
            this.etapaDataGridView.ReadOnly = true;
            this.etapaDataGridView.RowHeadersWidth = 51;
            this.etapaDataGridView.RowTemplate.Height = 24;
            this.etapaDataGridView.Size = new System.Drawing.Size(333, 346);
            this.etapaDataGridView.TabIndex = 18;
            this.etapaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.etapaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NomeEtapa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome Etapa";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FormMenuDeTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1055, 685);
            this.Controls.Add(this.etapaDataGridView);
            this.Controls.Add(this.tarefaDataGridView);
            this.Controls.Add(this.buttonConcluir);
            this.Controls.Add(this.buttonConvidarUsuario);
            this.Controls.Add(this.buttonDeletarEtapa);
            this.Controls.Add(this.buttonAlterarEtapa);
            this.Controls.Add(this.buttonInserirEtapa);
            this.Controls.Add(this.buttonSair);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxAtribuicao;
        private System.Windows.Forms.CheckBox checkBoxAtrasado;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonDeletarEtapa;
        private System.Windows.Forms.Button buttonAlterarEtapa;
        private System.Windows.Forms.Button buttonInserirEtapa;
        private System.Windows.Forms.Button buttonConvidarUsuario;
        private System.Windows.Forms.Button buttonConcluir;
        private System.Windows.Forms.BindingSource tarefaBindingSource1;
        private System.Windows.Forms.DataGridView tarefaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTarefaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource etapaBindingSource;
        private System.Windows.Forms.DataGridView etapaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}