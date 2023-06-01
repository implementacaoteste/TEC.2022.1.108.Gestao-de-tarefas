namespace WindowsFormsPrincipal
{
    partial class FormCadastroDeListaTarefas
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
            System.Windows.Forms.Label nomeListaLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listaDeTarefasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonArea1 = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.nomeListaTextBox = new System.Windows.Forms.TextBox();
            this.listaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomeListaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTarefasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeListaLabel
            // 
            nomeListaLabel.AutoSize = true;
            nomeListaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeListaLabel.Location = new System.Drawing.Point(53, 221);
            nomeListaLabel.Name = "nomeListaLabel";
            nomeListaLabel.Size = new System.Drawing.Size(141, 29);
            nomeListaLabel.TabIndex = 3;
            nomeListaLabel.Text = "Nome Lista:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 100);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de tarefas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonArea1
            // 
            this.buttonArea1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonArea1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonArea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonArea1.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonArea1.Location = new System.Drawing.Point(58, 364);
            this.buttonArea1.Name = "buttonArea1";
            this.buttonArea1.Size = new System.Drawing.Size(225, 42);
            this.buttonArea1.TabIndex = 2;
            this.buttonArea1.Text = "Salvar lista";
            this.buttonArea1.UseVisualStyleBackColor = false;
            this.buttonArea1.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Red;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSair.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSair.Location = new System.Drawing.Point(305, 364);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(102, 42);
            this.buttonSair.TabIndex = 1;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // nomeListaTextBox
            // 
            this.nomeListaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeListaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaBindingSource, "NomeLista", true));
            this.nomeListaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeListaTextBox.Location = new System.Drawing.Point(58, 272);
            this.nomeListaTextBox.Name = "nomeListaTextBox";
            this.nomeListaTextBox.Size = new System.Drawing.Size(349, 30);
            this.nomeListaTextBox.TabIndex = 0;
            // 
            // listaBindingSource
            // 
            this.listaBindingSource.DataSource = typeof(Models.Lista);
            // 
            // FormCadastroDeListaTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(459, 482);
            this.Controls.Add(this.nomeListaTextBox);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonArea1);
            this.Controls.Add(nomeListaLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDeListaTarefas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Lista Tarefas";
            this.Load += new System.EventHandler(this.FormCadastroDeListaTarefas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroDeListaTarefas_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTarefasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource listaDeTarefasBindingSource;
        private System.Windows.Forms.Button buttonArea1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.BindingSource listaBindingSource;
        private System.Windows.Forms.TextBox nomeListaTextBox;
    }
}