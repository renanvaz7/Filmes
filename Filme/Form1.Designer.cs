namespace Filme
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Tipo = new System.Windows.Forms.GroupBox();
            this.rbnFilme = new System.Windows.Forms.RadioButton();
            this.rbnSerie = new System.Windows.Forms.RadioButton();
            this.label_genero = new System.Windows.Forms.Label();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.label_Autor = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label_lancamento = new System.Windows.Forms.Label();
            this.groupBox_situacao = new System.Windows.Forms.GroupBox();
            this.rbnAssistido = new System.Windows.Forms.RadioButton();
            this.rbnDesejo = new System.Windows.Forms.RadioButton();
            this.listViewCadastro = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rbnAssistindo = new System.Windows.Forms.RadioButton();
            this.groupBox_Tipo.SuspendLayout();
            this.groupBox_situacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Filmes e Séries";
            // 
            // groupBox_Tipo
            // 
            this.groupBox_Tipo.Controls.Add(this.rbnFilme);
            this.groupBox_Tipo.Controls.Add(this.rbnSerie);
            this.groupBox_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Tipo.Location = new System.Drawing.Point(12, 107);
            this.groupBox_Tipo.Name = "groupBox_Tipo";
            this.groupBox_Tipo.Size = new System.Drawing.Size(176, 65);
            this.groupBox_Tipo.TabIndex = 1;
            this.groupBox_Tipo.TabStop = false;
            this.groupBox_Tipo.Text = "Tipo:";
            // 
            // rbnFilme
            // 
            this.rbnFilme.AutoSize = true;
            this.rbnFilme.Location = new System.Drawing.Point(6, 32);
            this.rbnFilme.Name = "rbnFilme";
            this.rbnFilme.Size = new System.Drawing.Size(65, 24);
            this.rbnFilme.TabIndex = 2;
            this.rbnFilme.TabStop = true;
            this.rbnFilme.Text = "Filme";
            this.rbnFilme.UseVisualStyleBackColor = true;
            this.rbnFilme.CheckedChanged += new System.EventHandler(this.rbnFilme_CheckedChanged);
            // 
            // rbnSerie
            // 
            this.rbnSerie.AutoSize = true;
            this.rbnSerie.Location = new System.Drawing.Point(106, 32);
            this.rbnSerie.Name = "rbnSerie";
            this.rbnSerie.Size = new System.Drawing.Size(64, 24);
            this.rbnSerie.TabIndex = 1;
            this.rbnSerie.TabStop = true;
            this.rbnSerie.Text = "Série";
            this.rbnSerie.UseVisualStyleBackColor = true;
            this.rbnSerie.CheckedChanged += new System.EventHandler(this.rbnFilme_CheckedChanged);
            // 
            // label_genero
            // 
            this.label_genero.AutoSize = true;
            this.label_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_genero.Location = new System.Drawing.Point(190, 207);
            this.label_genero.Name = "label_genero";
            this.label_genero.Size = new System.Drawing.Size(67, 20);
            this.label_genero.TabIndex = 2;
            this.label_genero.Text = "Gênero:";
            // 
            // txt_Autor
            // 
            this.txt_Autor.Location = new System.Drawing.Point(314, 170);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(258, 20);
            this.txt_Autor.TabIndex = 3;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nome.Location = new System.Drawing.Point(190, 276);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(55, 20);
            this.label_Nome.TabIndex = 4;
            this.label_Nome.Text = "Nome:";
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(314, 209);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(258, 20);
            this.txt_genero.TabIndex = 5;
            // 
            // label_Autor
            // 
            this.label_Autor.AutoSize = true;
            this.label_Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Autor.Location = new System.Drawing.Point(190, 168);
            this.label_Autor.Name = "label_Autor";
            this.label_Autor.Size = new System.Drawing.Size(52, 20);
            this.label_Autor.TabIndex = 6;
            this.label_Autor.Text = "Autor:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(314, 278);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(258, 20);
            this.txt_Nome.TabIndex = 8;
            // 
            // label_lancamento
            // 
            this.label_lancamento.AutoSize = true;
            this.label_lancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lancamento.Location = new System.Drawing.Point(190, 242);
            this.label_lancamento.Name = "label_lancamento";
            this.label_lancamento.Size = new System.Drawing.Size(102, 20);
            this.label_lancamento.TabIndex = 9;
            this.label_lancamento.Text = "Lançamento:";
            // 
            // groupBox_situacao
            // 
            this.groupBox_situacao.Controls.Add(this.rbnAssistindo);
            this.groupBox_situacao.Controls.Add(this.rbnAssistido);
            this.groupBox_situacao.Controls.Add(this.rbnDesejo);
            this.groupBox_situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_situacao.Location = new System.Drawing.Point(588, 107);
            this.groupBox_situacao.Name = "groupBox_situacao";
            this.groupBox_situacao.Size = new System.Drawing.Size(200, 104);
            this.groupBox_situacao.TabIndex = 10;
            this.groupBox_situacao.TabStop = false;
            this.groupBox_situacao.Text = "Situação";
            // 
            // rbnAssistido
            // 
            this.rbnAssistido.AutoSize = true;
            this.rbnAssistido.Location = new System.Drawing.Point(6, 32);
            this.rbnAssistido.Name = "rbnAssistido";
            this.rbnAssistido.Size = new System.Drawing.Size(91, 24);
            this.rbnAssistido.TabIndex = 2;
            this.rbnAssistido.TabStop = true;
            this.rbnAssistido.Text = "Assistido";
            this.rbnAssistido.UseVisualStyleBackColor = true;
            this.rbnAssistido.CheckedChanged += new System.EventHandler(this.rbnAssistido_CheckedChanged);
            // 
            // rbnDesejo
            // 
            this.rbnDesejo.AutoSize = true;
            this.rbnDesejo.Location = new System.Drawing.Point(117, 32);
            this.rbnDesejo.Name = "rbnDesejo";
            this.rbnDesejo.Size = new System.Drawing.Size(77, 24);
            this.rbnDesejo.TabIndex = 1;
            this.rbnDesejo.TabStop = true;
            this.rbnDesejo.Text = "Desejo";
            this.rbnDesejo.UseVisualStyleBackColor = true;
            this.rbnDesejo.CheckedChanged += new System.EventHandler(this.rbnAssistido_CheckedChanged);
            // 
            // listViewCadastro
            // 
            this.listViewCadastro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCadastro.HideSelection = false;
            this.listViewCadastro.Location = new System.Drawing.Point(44, 324);
            this.listViewCadastro.Name = "listViewCadastro";
            this.listViewCadastro.Size = new System.Drawing.Size(567, 114);
            this.listViewCadastro.TabIndex = 11;
            this.listViewCadastro.UseCompatibleStateImageBehavior = false;
            this.listViewCadastro.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Autor";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gênero";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lançamento";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nome";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Situação";
            this.columnHeader5.Width = 114;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tipo";
            this.columnHeader6.Width = 161;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(656, 353);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 54);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // rbnAssistindo
            // 
            this.rbnAssistindo.AutoSize = true;
            this.rbnAssistindo.Location = new System.Drawing.Point(48, 63);
            this.rbnAssistindo.Name = "rbnAssistindo";
            this.rbnAssistindo.Size = new System.Drawing.Size(100, 24);
            this.rbnAssistindo.TabIndex = 3;
            this.rbnAssistindo.TabStop = true;
            this.rbnAssistindo.Text = "Assistindo";
            this.rbnAssistindo.UseVisualStyleBackColor = true;
            this.rbnAssistindo.CheckedChanged += new System.EventHandler(this.rbnAssistido_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listViewCadastro);
            this.Controls.Add(this.groupBox_situacao);
            this.Controls.Add(this.label_lancamento);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label_Autor);
            this.Controls.Add(this.txt_genero);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.txt_Autor);
            this.Controls.Add(this.label_genero);
            this.Controls.Add(this.groupBox_Tipo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Tipo.ResumeLayout(false);
            this.groupBox_Tipo.PerformLayout();
            this.groupBox_situacao.ResumeLayout(false);
            this.groupBox_situacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Tipo;
        private System.Windows.Forms.RadioButton rbnSerie;
        private System.Windows.Forms.Label label_genero;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.Label label_Autor;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label_lancamento;
        private System.Windows.Forms.GroupBox groupBox_situacao;
        private System.Windows.Forms.RadioButton rbnDesejo;
        private System.Windows.Forms.ListView listViewCadastro;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.RadioButton rbnAssistindo;
    }
}

