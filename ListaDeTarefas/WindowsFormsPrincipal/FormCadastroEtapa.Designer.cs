namespace WindowsFormsPrincipal
{
    partial class FormCadastroEtapa
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label label4;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalvarEtapa = new System.Windows.Forms.Button();
            this.buttonCancelarEtapa = new System.Windows.Forms.Button();
            this.nomeEtapaTextBox = new System.Windows.Forms.TextBox();
            this.etapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxResponsavel = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPontos = new System.Windows.Forms.ComboBox();
            dataLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(258, 265);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(39, 16);
            dataLabel.TabIndex = 8;
            dataLabel.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(258, 326);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 16);
            label4.TabIndex = 11;
            label4.Text = "Pontos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 80);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(276, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Etapa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 406);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Etapa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Responsável";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSalvarEtapa
            // 
            this.buttonSalvarEtapa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonSalvarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalvarEtapa.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSalvarEtapa.Location = new System.Drawing.Point(261, 414);
            this.buttonSalvarEtapa.Name = "buttonSalvarEtapa";
            this.buttonSalvarEtapa.Size = new System.Drawing.Size(111, 33);
            this.buttonSalvarEtapa.TabIndex = 4;
            this.buttonSalvarEtapa.Text = "Salvar";
            this.buttonSalvarEtapa.UseVisualStyleBackColor = false;
            this.buttonSalvarEtapa.Click += new System.EventHandler(this.buttonSalvarEtapa_Click);
            // 
            // buttonCancelarEtapa
            // 
            this.buttonCancelarEtapa.BackColor = System.Drawing.Color.Red;
            this.buttonCancelarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelarEtapa.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCancelarEtapa.Location = new System.Drawing.Point(430, 414);
            this.buttonCancelarEtapa.Name = "buttonCancelarEtapa";
            this.buttonCancelarEtapa.Size = new System.Drawing.Size(111, 33);
            this.buttonCancelarEtapa.TabIndex = 5;
            this.buttonCancelarEtapa.Text = "Cancelar";
            this.buttonCancelarEtapa.UseVisualStyleBackColor = false;
            this.buttonCancelarEtapa.Click += new System.EventHandler(this.buttonCancelarEtapa_Click_1);
            this.buttonCancelarEtapa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonCancelarEtapa_KeyDown);
            // 
            // nomeEtapaTextBox
            // 
            this.nomeEtapaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeEtapaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etapaBindingSource, "NomeEtapa", true));
            this.nomeEtapaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeEtapaTextBox.Location = new System.Drawing.Point(261, 167);
            this.nomeEtapaTextBox.Name = "nomeEtapaTextBox";
            this.nomeEtapaTextBox.Size = new System.Drawing.Size(280, 30);
            this.nomeEtapaTextBox.TabIndex = 1;
            this.nomeEtapaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeEtapaTextBox_KeyDown);
            // 
            // etapaBindingSource
            // 
            this.etapaBindingSource.DataSource = typeof(Models.Etapa);
            // 
            // comboBoxResponsavel
            // 
            this.comboBoxResponsavel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.etapaBindingSource, "IdUsuario", true));
            this.comboBoxResponsavel.DataSource = this.usuarioBindingSource;
            this.comboBoxResponsavel.DisplayMember = "Nome";
            this.comboBoxResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxResponsavel.FormattingEnabled = true;
            this.comboBoxResponsavel.Location = new System.Drawing.Point(261, 225);
            this.comboBoxResponsavel.Name = "comboBoxResponsavel";
            this.comboBoxResponsavel.Size = new System.Drawing.Size(280, 33);
            this.comboBoxResponsavel.TabIndex = 3;
            this.comboBoxResponsavel.ValueMember = "Id";
            this.comboBoxResponsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxResponsavel_KeyDown);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.etapaBindingSource, "Data", true));
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etapaBindingSource, "Data", true));
            this.dataDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(261, 284);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(280, 30);
            this.dataDateTimePicker.TabIndex = 9;
            this.dataDateTimePicker.Value = new System.DateTime(2023, 5, 15, 0, 0, 0, 0);
            // 
            // comboBoxPontos
            // 
            this.comboBoxPontos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etapaBindingSource, "Valor", true));
            this.comboBoxPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPontos.FormattingEnabled = true;
            this.comboBoxPontos.Items.AddRange(new object[] {
            "10",
            "50",
            "100"});
            this.comboBoxPontos.Location = new System.Drawing.Point(261, 345);
            this.comboBoxPontos.Name = "comboBoxPontos";
            this.comboBoxPontos.Size = new System.Drawing.Size(280, 33);
            this.comboBoxPontos.TabIndex = 10;
            // 
            // FormCadastroEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 486);
            this.Controls.Add(label4);
            this.Controls.Add(this.comboBoxPontos);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(this.comboBoxResponsavel);
            this.Controls.Add(this.nomeEtapaTextBox);
            this.Controls.Add(this.buttonCancelarEtapa);
            this.Controls.Add(this.buttonSalvarEtapa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormCadastroEtapa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de etapa";
            this.Load += new System.EventHandler(this.FormCadastroEtapa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalvarEtapa;
        private System.Windows.Forms.Button buttonCancelarEtapa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeEtapaTextBox;
        private System.Windows.Forms.ComboBox comboBoxResponsavel;
        private System.Windows.Forms.BindingSource etapaBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxPontos;
    }
}