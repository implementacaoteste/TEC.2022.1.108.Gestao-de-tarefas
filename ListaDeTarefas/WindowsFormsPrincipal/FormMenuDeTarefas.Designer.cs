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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuDeTarefas));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.radioButtonPrivado = new System.Windows.Forms.RadioButton();
            this.radioButtonPublico = new System.Windows.Forms.RadioButton();
            this.buttonCodigo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxAtribuicao = new System.Windows.Forms.CheckBox();
            this.checkBoxAtrasado = new System.Windows.Forms.CheckBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonDeletarEtapa = new System.Windows.Forms.Button();
            this.buttonAlterarEtapa = new System.Windows.Forms.Button();
            this.buttonInserirEtapa = new System.Windows.Forms.Button();
            this.tarefaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarefaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTarefaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etapaDataGridView = new System.Windows.Forms.DataGridView();
            this.etapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonVisualizarRanking = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxHoje = new System.Windows.Forms.CheckBox();
            this.checkBoxAmanha = new System.Windows.Forms.CheckBox();
            this.checkBoxSemana = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(418, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tarefas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.labelCodigo);
            this.panel2.Controls.Add(this.radioButtonPrivado);
            this.panel2.Controls.Add(this.radioButtonPublico);
            this.panel2.Controls.Add(this.buttonCodigo);
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 590);
            this.panel2.TabIndex = 12;
            // 
            // labelCodigo
            // 
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelCodigo.Location = new System.Drawing.Point(12, 547);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(128, 25);
            this.labelCodigo.TabIndex = 24;
            this.labelCodigo.Text = "**************";
            this.labelCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCodigo.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // radioButtonPrivado
            // 
            this.radioButtonPrivado.AutoSize = true;
            this.radioButtonPrivado.Location = new System.Drawing.Point(12, 433);
            this.radioButtonPrivado.Name = "radioButtonPrivado";
            this.radioButtonPrivado.Size = new System.Drawing.Size(75, 20);
            this.radioButtonPrivado.TabIndex = 23;
            this.radioButtonPrivado.TabStop = true;
            this.radioButtonPrivado.Text = "Privado";
            this.radioButtonPrivado.UseVisualStyleBackColor = true;
            this.radioButtonPrivado.CheckedChanged += new System.EventHandler(this.radioButtonPrivado_CheckedChanged);
            // 
            // radioButtonPublico
            // 
            this.radioButtonPublico.AutoSize = true;
            this.radioButtonPublico.Location = new System.Drawing.Point(12, 459);
            this.radioButtonPublico.Name = "radioButtonPublico";
            this.radioButtonPublico.Size = new System.Drawing.Size(73, 20);
            this.radioButtonPublico.TabIndex = 22;
            this.radioButtonPublico.TabStop = true;
            this.radioButtonPublico.Text = "Público";
            this.radioButtonPublico.UseVisualStyleBackColor = true;
            this.radioButtonPublico.CheckedChanged += new System.EventHandler(this.radioButtonPublico_CheckedChanged);
            // 
            // buttonCodigo
            // 
            this.buttonCodigo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCodigo.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCodigo.Location = new System.Drawing.Point(12, 485);
            this.buttonCodigo.Name = "buttonCodigo";
            this.buttonCodigo.Size = new System.Drawing.Size(128, 48);
            this.buttonCodigo.TabIndex = 20;
            this.buttonCodigo.Text = "Exibir código de convite";
            this.buttonCodigo.UseVisualStyleBackColor = false;
            this.buttonCodigo.Click += new System.EventHandler(this.buttonCodigo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 100);
            this.panel1.TabIndex = 13;
            // 
            // checkBoxAtribuicao
            // 
            this.checkBoxAtribuicao.AutoSize = true;
            this.checkBoxAtribuicao.Location = new System.Drawing.Point(298, 201);
            this.checkBoxAtribuicao.Name = "checkBoxAtribuicao";
            this.checkBoxAtribuicao.Size = new System.Drawing.Size(128, 20);
            this.checkBoxAtribuicao.TabIndex = 11;
            this.checkBoxAtribuicao.Text = "Atribuidas a mim";
            this.checkBoxAtribuicao.UseVisualStyleBackColor = true;
            this.checkBoxAtribuicao.CheckedChanged += new System.EventHandler(this.checkBoxAtribuicao_CheckedChanged_1);
            // 
            // checkBoxAtrasado
            // 
            this.checkBoxAtrasado.AutoSize = true;
            this.checkBoxAtrasado.Location = new System.Drawing.Point(200, 201);
            this.checkBoxAtrasado.Name = "checkBoxAtrasado";
            this.checkBoxAtrasado.Size = new System.Drawing.Size(91, 20);
            this.checkBoxAtrasado.TabIndex = 10;
            this.checkBoxAtrasado.Text = "Em Atraso";
            this.checkBoxAtrasado.UseVisualStyleBackColor = true;
            this.checkBoxAtrasado.CheckedChanged += new System.EventHandler(this.checkBoxAtrasado_CheckedChanged);
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInserir.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonInserir.Location = new System.Drawing.Point(287, 166);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 26);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlterar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAlterar.Location = new System.Drawing.Point(374, 166);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 26);
            this.buttonAlterar.TabIndex = 3;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDeletar.Location = new System.Drawing.Point(458, 166);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 26);
            this.buttonDeletar.TabIndex = 4;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = false;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscar.Location = new System.Drawing.Point(200, 166);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 26);
            this.buttonBuscar.TabIndex = 1;
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
            this.buttonSair.Location = new System.Drawing.Point(929, 608);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(74, 33);
            this.buttonSair.TabIndex = 9;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click_1);
            // 
            // buttonDeletarEtapa
            // 
            this.buttonDeletarEtapa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDeletarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletarEtapa.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDeletarEtapa.Location = new System.Drawing.Point(706, 166);
            this.buttonDeletarEtapa.Name = "buttonDeletarEtapa";
            this.buttonDeletarEtapa.Size = new System.Drawing.Size(68, 26);
            this.buttonDeletarEtapa.TabIndex = 7;
            this.buttonDeletarEtapa.Text = "Deletar";
            this.buttonDeletarEtapa.UseVisualStyleBackColor = false;
            this.buttonDeletarEtapa.Click += new System.EventHandler(this.buttonDeletarEtapa_Click_1);
            // 
            // buttonAlterarEtapa
            // 
            this.buttonAlterarEtapa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAlterarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlterarEtapa.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAlterarEtapa.Location = new System.Drawing.Point(632, 166);
            this.buttonAlterarEtapa.Name = "buttonAlterarEtapa";
            this.buttonAlterarEtapa.Size = new System.Drawing.Size(68, 26);
            this.buttonAlterarEtapa.TabIndex = 6;
            this.buttonAlterarEtapa.Text = "Alterar";
            this.buttonAlterarEtapa.UseVisualStyleBackColor = false;
            this.buttonAlterarEtapa.Click += new System.EventHandler(this.buttonAlterarEtapa_Click);
            // 
            // buttonInserirEtapa
            // 
            this.buttonInserirEtapa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonInserirEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInserirEtapa.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonInserirEtapa.Location = new System.Drawing.Point(558, 166);
            this.buttonInserirEtapa.Name = "buttonInserirEtapa";
            this.buttonInserirEtapa.Size = new System.Drawing.Size(68, 26);
            this.buttonInserirEtapa.TabIndex = 5;
            this.buttonInserirEtapa.Text = "Inserir";
            this.buttonInserirEtapa.UseVisualStyleBackColor = false;
            this.buttonInserirEtapa.Click += new System.EventHandler(this.buttonInserirEtapa_Click);
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
            this.tarefaDataGridView.Location = new System.Drawing.Point(199, 229);
            this.tarefaDataGridView.Name = "tarefaDataGridView";
            this.tarefaDataGridView.ReadOnly = true;
            this.tarefaDataGridView.RowHeadersVisible = false;
            this.tarefaDataGridView.RowHeadersWidth = 51;
            this.tarefaDataGridView.RowTemplate.Height = 24;
            this.tarefaDataGridView.Size = new System.Drawing.Size(333, 346);
            this.tarefaDataGridView.TabIndex = 14;
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
            // etapaDataGridView
            // 
            this.etapaDataGridView.AllowUserToAddRows = false;
            this.etapaDataGridView.AllowUserToDeleteRows = false;
            this.etapaDataGridView.AllowUserToOrderColumns = true;
            this.etapaDataGridView.AutoGenerateColumns = false;
            this.etapaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.etapaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Data,
            this.Valor,
            this.Status});
            this.etapaDataGridView.DataSource = this.etapaBindingSource;
            this.etapaDataGridView.Location = new System.Drawing.Point(557, 229);
            this.etapaDataGridView.Name = "etapaDataGridView";
            this.etapaDataGridView.RowHeadersVisible = false;
            this.etapaDataGridView.RowHeadersWidth = 51;
            this.etapaDataGridView.RowTemplate.Height = 24;
            this.etapaDataGridView.Size = new System.Drawing.Size(446, 346);
            this.etapaDataGridView.TabIndex = 15;
            this.etapaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.etapaDataGridView_CellClick);
            this.etapaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.etapaDataGridView_CellContentClick);
            // 
            // etapaBindingSource
            // 
            this.etapaBindingSource.DataMember = "Etapa";
            this.etapaBindingSource.DataSource = this.tarefaBindingSource1;
            this.etapaBindingSource.CurrentChanged += new System.EventHandler(this.etapaBindingSource_CurrentChanged);
            // 
            // buttonVisualizarRanking
            // 
            this.buttonVisualizarRanking.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonVisualizarRanking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVisualizarRanking.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonVisualizarRanking.Location = new System.Drawing.Point(199, 608);
            this.buttonVisualizarRanking.Name = "buttonVisualizarRanking";
            this.buttonVisualizarRanking.Size = new System.Drawing.Size(141, 33);
            this.buttonVisualizarRanking.TabIndex = 8;
            this.buttonVisualizarRanking.Text = "Visualizar Ranking";
            this.buttonVisualizarRanking.UseVisualStyleBackColor = false;
            this.buttonVisualizarRanking.Click += new System.EventHandler(this.buttonVisualizarRanking_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxHoje
            // 
            this.checkBoxHoje.AutoSize = true;
            this.checkBoxHoje.Location = new System.Drawing.Point(558, 201);
            this.checkBoxHoje.Name = "checkBoxHoje";
            this.checkBoxHoje.Size = new System.Drawing.Size(58, 20);
            this.checkBoxHoje.TabIndex = 16;
            this.checkBoxHoje.Text = "Hoje";
            this.checkBoxHoje.UseVisualStyleBackColor = true;
            // 
            // checkBoxAmanha
            // 
            this.checkBoxAmanha.AutoSize = true;
            this.checkBoxAmanha.Location = new System.Drawing.Point(625, 201);
            this.checkBoxAmanha.Name = "checkBoxAmanha";
            this.checkBoxAmanha.Size = new System.Drawing.Size(79, 20);
            this.checkBoxAmanha.TabIndex = 17;
            this.checkBoxAmanha.Text = "Amanhã";
            this.checkBoxAmanha.UseVisualStyleBackColor = true;
            // 
            // checkBoxSemana
            // 
            this.checkBoxSemana.AutoSize = true;
            this.checkBoxSemana.Location = new System.Drawing.Point(710, 201);
            this.checkBoxSemana.Name = "checkBoxSemana";
            this.checkBoxSemana.Size = new System.Drawing.Size(80, 20);
            this.checkBoxSemana.TabIndex = 18;
            this.checkBoxSemana.Text = "Semena";
            this.checkBoxSemana.UseVisualStyleBackColor = true;
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
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.Width = 125;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.Width = 50;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 50;
            // 
            // FormMenuDeTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1043, 685);
            this.Controls.Add(this.checkBoxSemana);
            this.Controls.Add(this.checkBoxAmanha);
            this.Controls.Add(this.checkBoxHoje);
            this.Controls.Add(this.buttonVisualizarRanking);
            this.Controls.Add(this.etapaDataGridView);
            this.Controls.Add(this.tarefaDataGridView);
            this.Controls.Add(this.buttonDeletarEtapa);
            this.Controls.Add(this.buttonAlterarEtapa);
            this.Controls.Add(this.buttonInserirEtapa);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.checkBoxAtrasado);
            this.Controls.Add(this.checkBoxAtribuicao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FormMenuDeTarefas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.Load += new System.EventHandler(this.FormMenuDeTarefas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenuDeTarefas_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxAtribuicao;
        private System.Windows.Forms.CheckBox checkBoxAtrasado;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonDeletarEtapa;
        private System.Windows.Forms.Button buttonAlterarEtapa;
        private System.Windows.Forms.Button buttonInserirEtapa;
        private System.Windows.Forms.BindingSource tarefaBindingSource1;
        private System.Windows.Forms.DataGridView tarefaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTarefaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource etapaBindingSource;
        private System.Windows.Forms.DataGridView etapaDataGridView;
        private System.Windows.Forms.Button buttonVisualizarRanking;
        private System.Windows.Forms.Button buttonCodigo;
        private System.Windows.Forms.RadioButton radioButtonPrivado;
        private System.Windows.Forms.RadioButton radioButtonPublico;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxHoje;
        private System.Windows.Forms.CheckBox checkBoxAmanha;
        private System.Windows.Forms.CheckBox checkBoxSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}