namespace WindowsFormsPrincipal
{
    partial class FormCadastroDeGrupo
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
            this.buttonSalvarGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxtitulo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 80);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Renomear Grupo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonSalvarGrupo
            // 
            this.buttonSalvarGrupo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonSalvarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalvarGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSalvarGrupo.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSalvarGrupo.Location = new System.Drawing.Point(107, 313);
            this.buttonSalvarGrupo.Name = "buttonSalvarGrupo";
            this.buttonSalvarGrupo.Size = new System.Drawing.Size(169, 36);
            this.buttonSalvarGrupo.TabIndex = 9;
            this.buttonSalvarGrupo.Text = "Salvar grupo";
            this.buttonSalvarGrupo.UseVisualStyleBackColor = false;
            this.buttonSalvarGrupo.Click += new System.EventHandler(this.buttonArea1_Click);

            

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Grupo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Red;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSair.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSair.Location = new System.Drawing.Point(314, 313);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(74, 36);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataSource = typeof(Models.Grupo);
            // 
            // textBoxtitulo
            // 
            this.textBoxtitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxtitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "Titulo", true));
            this.textBoxtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtitulo.Location = new System.Drawing.Point(107, 228);
            this.textBoxtitulo.Name = "textBoxtitulo";
            this.textBoxtitulo.Size = new System.Drawing.Size(281, 30);
            this.textBoxtitulo.TabIndex = 1;
            // 
            // FormCadastroDeGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.textBoxtitulo);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonSalvarGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDeGrupo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Grupo";
            this.Load += new System.EventHandler(this.FormCadastroDeGrupo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSalvarGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private System.Windows.Forms.TextBox textBoxtitulo;
    }
}