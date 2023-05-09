namespace WindowsFormsPrincipal
{
    partial class FormCadastrarTarefas
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
            System.Windows.Forms.Label nomeTarefaLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTarefaTextBox = new System.Windows.Forms.TextBox();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            nomeTarefaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 100);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adicionar Tarefas";
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataSource = typeof(Models.Tarefa);
            // 
            // nomeTarefaLabel
            // 
            nomeTarefaLabel.AutoSize = true;
            nomeTarefaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeTarefaLabel.Location = new System.Drawing.Point(161, 199);
            nomeTarefaLabel.Name = "nomeTarefaLabel";
            nomeTarefaLabel.Size = new System.Drawing.Size(132, 25);
            nomeTarefaLabel.TabIndex = 2;
            nomeTarefaLabel.Text = "Nome Tarefa:";
            // 
            // nomeTarefaTextBox
            // 
            this.nomeTarefaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "NomeTarefa", true));
            this.nomeTarefaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTarefaTextBox.Location = new System.Drawing.Point(299, 196);
            this.nomeTarefaTextBox.Name = "nomeTarefaTextBox";
            this.nomeTarefaTextBox.Size = new System.Drawing.Size(233, 30);
            this.nomeTarefaTextBox.TabIndex = 3;
            // 
            // buttonCriar
            // 
            this.buttonCriar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCriar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCriar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCriar.Location = new System.Drawing.Point(166, 314);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(174, 40);
            this.buttonCriar.TabIndex = 9;
            this.buttonCriar.Text = "Criar tarefa";
            this.buttonCriar.UseVisualStyleBackColor = false;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Red;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSair.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSair.Location = new System.Drawing.Point(458, 314);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(74, 33);
            this.buttonSair.TabIndex = 13;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormCadastrarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 390);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(nomeTarefaLabel);
            this.Controls.Add(this.nomeTarefaTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastrarTarefas";
            this.Text = "FormCadastrarTarefas";
            this.Load += new System.EventHandler(this.FormCadastrarTarefas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private System.Windows.Forms.TextBox nomeTarefaTextBox;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonSair;
    }
}