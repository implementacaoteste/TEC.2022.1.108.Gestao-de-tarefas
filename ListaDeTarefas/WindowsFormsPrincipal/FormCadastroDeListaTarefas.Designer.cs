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
            this.nomeListaTextBox = new System.Windows.Forms.TextBox();
            this.buttonArea1 = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            nomeListaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTarefasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 100);
            this.panel1.TabIndex = 1;
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
            // listaDeTarefasBindingSource
            // 
            this.listaDeTarefasBindingSource.DataSource = typeof(Models.ListaDeTarefas);
            // 
            // nomeListaLabel
            // 
            nomeListaLabel.AutoSize = true;
            nomeListaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeListaLabel.Location = new System.Drawing.Point(53, 210);
            nomeListaLabel.Name = "nomeListaLabel";
            nomeListaLabel.Size = new System.Drawing.Size(141, 29);
            nomeListaLabel.TabIndex = 2;
            nomeListaLabel.Text = "Nome Lista:";
            // 
            // nomeListaTextBox
            // 
            this.nomeListaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeTarefasBindingSource, "NomeLista", true));
            this.nomeListaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeListaTextBox.Location = new System.Drawing.Point(58, 242);
            this.nomeListaTextBox.Name = "nomeListaTextBox";
            this.nomeListaTextBox.Size = new System.Drawing.Size(349, 30);
            this.nomeListaTextBox.TabIndex = 3;
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
            this.buttonArea1.TabIndex = 5;
            this.buttonArea1.Text = "Criar lista";
            this.buttonArea1.UseVisualStyleBackColor = false;
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
            this.buttonSair.TabIndex = 14;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            // 
            // FormCadastroDeListaTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 482);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonArea1);
            this.Controls.Add(nomeListaLabel);
            this.Controls.Add(this.nomeListaTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDeListaTarefas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Lista Tarefas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTarefasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource listaDeTarefasBindingSource;
        private System.Windows.Forms.TextBox nomeListaTextBox;
        private System.Windows.Forms.Button buttonArea1;
        private System.Windows.Forms.Button buttonSair;
    }
}