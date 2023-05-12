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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalvarEtapa = new System.Windows.Forms.Button();
            this.buttonCancelarEtapa = new System.Windows.Forms.Button();
            this.nomeEtapaTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxResponsavel = new System.Windows.Forms.ComboBox();
            this.etapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 80);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 9);
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
            this.panel2.Size = new System.Drawing.Size(107, 300);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Etapa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 193);
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
            this.buttonSalvarEtapa.Location = new System.Drawing.Point(213, 294);
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
            this.buttonCancelarEtapa.Location = new System.Drawing.Point(385, 294);
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
            this.nomeEtapaTextBox.Location = new System.Drawing.Point(216, 156);
            this.nomeEtapaTextBox.Name = "nomeEtapaTextBox";
            this.nomeEtapaTextBox.Size = new System.Drawing.Size(280, 30);
            this.nomeEtapaTextBox.TabIndex = 1;
            this.nomeEtapaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeEtapaTextBox_KeyDown);
            // 
            // comboBoxResponsavel
            // 
            this.comboBoxResponsavel.DataSource = this.usuarioBindingSource;
            this.comboBoxResponsavel.DisplayMember = "Nome";
            this.comboBoxResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxResponsavel.FormattingEnabled = true;
            this.comboBoxResponsavel.Location = new System.Drawing.Point(216, 214);
            this.comboBoxResponsavel.Name = "comboBoxResponsavel";
            this.comboBoxResponsavel.Size = new System.Drawing.Size(280, 33);
            this.comboBoxResponsavel.TabIndex = 3;
            this.comboBoxResponsavel.ValueMember = "Id";
            this.comboBoxResponsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxResponsavel_KeyDown);
            // 
            // etapaBindingSource
            // 
            this.etapaBindingSource.DataSource = typeof(Models.Etapa);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // FormCadastroEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 380);
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
    }
}