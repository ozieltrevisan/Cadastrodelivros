﻿
namespace Cadastro_de_livros
{
    partial class Form1
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
            this.drlivros = new System.Windows.Forms.DataGridView();
            this.dbadicionar = new System.Windows.Forms.Button();
            this.dbnovocadastro = new System.Windows.Forms.Button();
            this.dbexcluir = new System.Windows.Forms.Button();
            this.dbAlterar = new System.Windows.Forms.Button();
            this.dbbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtlivro = new System.Windows.Forms.TextBox();
            this.txtacervo = new System.Windows.Forms.TextBox();
            this.txtlocal = new System.Windows.Forms.TextBox();
            this.txtpaginas = new System.Windows.Forms.TextBox();
            this.txtvolume = new System.Windows.Forms.TextBox();
            this.txtedicao = new System.Windows.Forms.TextBox();
            this.txteditora = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drlivros)).BeginInit();
            this.SuspendLayout();
            // 
            // drlivros
            // 
            this.drlivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drlivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.drlivros.Location = new System.Drawing.Point(1, 312);
            this.drlivros.Name = "drlivros";
            this.drlivros.Size = new System.Drawing.Size(973, 172);
            this.drlivros.TabIndex = 0;
            // 
            // dbadicionar
            // 
            this.dbadicionar.Location = new System.Drawing.Point(12, 272);
            this.dbadicionar.Name = "dbadicionar";
            this.dbadicionar.Size = new System.Drawing.Size(100, 23);
            this.dbadicionar.TabIndex = 1;
            this.dbadicionar.Text = "Cadastrar";
            this.dbadicionar.UseVisualStyleBackColor = true;
            this.dbadicionar.Click += new System.EventHandler(this.dbadicionar_Click);
            // 
            // dbnovocadastro
            // 
            this.dbnovocadastro.Location = new System.Drawing.Point(137, 272);
            this.dbnovocadastro.Name = "dbnovocadastro";
            this.dbnovocadastro.Size = new System.Drawing.Size(96, 23);
            this.dbnovocadastro.TabIndex = 2;
            this.dbnovocadastro.Text = "Novo cadastro";
            this.dbnovocadastro.UseVisualStyleBackColor = true;
            this.dbnovocadastro.Click += new System.EventHandler(this.dbnovocadastro_Click);
            // 
            // dbexcluir
            // 
            this.dbexcluir.Location = new System.Drawing.Point(282, 272);
            this.dbexcluir.Name = "dbexcluir";
            this.dbexcluir.Size = new System.Drawing.Size(88, 23);
            this.dbexcluir.TabIndex = 3;
            this.dbexcluir.Text = "Excluir";
            this.dbexcluir.UseVisualStyleBackColor = true;
            this.dbexcluir.Click += new System.EventHandler(this.dbexcluir_Click);
            // 
            // dbAlterar
            // 
            this.dbAlterar.Location = new System.Drawing.Point(423, 272);
            this.dbAlterar.Name = "dbAlterar";
            this.dbAlterar.Size = new System.Drawing.Size(92, 23);
            this.dbAlterar.TabIndex = 4;
            this.dbAlterar.Text = "Alterar";
            this.dbAlterar.UseVisualStyleBackColor = true;
            this.dbAlterar.Click += new System.EventHandler(this.dbAlterar_Click);
            // 
            // dbbuscar
            // 
            this.dbbuscar.Location = new System.Drawing.Point(578, 272);
            this.dbbuscar.Name = "dbbuscar";
            this.dbbuscar.Size = new System.Drawing.Size(95, 23);
            this.dbbuscar.TabIndex = 5;
            this.dbbuscar.Text = "Buscar";
            this.dbbuscar.UseVisualStyleBackColor = true;
            this.dbbuscar.Click += new System.EventHandler(this.dbbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Autor do lovro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(883, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Titulo do livro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Editora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Edição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Volume";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(888, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "N° de Paginas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Local";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Acervo";
            // 
            // txtlivro
            // 
            this.txtlivro.Location = new System.Drawing.Point(12, 25);
            this.txtlivro.Name = "txtlivro";
            this.txtlivro.Size = new System.Drawing.Size(375, 20);
            this.txtlivro.TabIndex = 16;
            // 
            // txtacervo
            // 
            this.txtacervo.Location = new System.Drawing.Point(12, 226);
            this.txtacervo.Name = "txtacervo";
            this.txtacervo.Size = new System.Drawing.Size(575, 20);
            this.txtacervo.TabIndex = 17;
            // 
            // txtlocal
            // 
            this.txtlocal.Location = new System.Drawing.Point(15, 175);
            this.txtlocal.Name = "txtlocal";
            this.txtlocal.Size = new System.Drawing.Size(575, 20);
            this.txtlocal.TabIndex = 18;
            // 
            // txtpaginas
            // 
            this.txtpaginas.Location = new System.Drawing.Point(865, 123);
            this.txtpaginas.Name = "txtpaginas";
            this.txtpaginas.Size = new System.Drawing.Size(100, 20);
            this.txtpaginas.TabIndex = 19;
            // 
            // txtvolume
            // 
            this.txtvolume.Location = new System.Drawing.Point(629, 123);
            this.txtvolume.Name = "txtvolume";
            this.txtvolume.Size = new System.Drawing.Size(140, 20);
            this.txtvolume.TabIndex = 20;
            // 
            // txtedicao
            // 
            this.txtedicao.Location = new System.Drawing.Point(310, 123);
            this.txtedicao.Name = "txtedicao";
            this.txtedicao.Size = new System.Drawing.Size(269, 20);
            this.txtedicao.TabIndex = 21;
            this.txtedicao.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txteditora
            // 
            this.txteditora.Location = new System.Drawing.Point(15, 123);
            this.txteditora.Name = "txteditora";
            this.txteditora.Size = new System.Drawing.Size(252, 20);
            this.txteditora.TabIndex = 22;
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(12, 74);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(613, 20);
            this.txttitulo.TabIndex = 23;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(872, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(64, 20);
            this.txtid.TabIndex = 24;
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(468, 25);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(355, 20);
            this.txtautor.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome do livro";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Autor do livro";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Titulo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Editora";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Edição";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Volume";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Paginas";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Local";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Acervo";
            this.Column10.Name = "Column10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 483);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.txteditora);
            this.Controls.Add(this.txtedicao);
            this.Controls.Add(this.txtvolume);
            this.Controls.Add(this.txtpaginas);
            this.Controls.Add(this.txtlocal);
            this.Controls.Add(this.txtacervo);
            this.Controls.Add(this.txtlivro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbbuscar);
            this.Controls.Add(this.dbAlterar);
            this.Controls.Add(this.dbexcluir);
            this.Controls.Add(this.dbnovocadastro);
            this.Controls.Add(this.dbadicionar);
            this.Controls.Add(this.drlivros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drlivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView drlivros;
        private System.Windows.Forms.Button dbadicionar;
        private System.Windows.Forms.Button dbnovocadastro;
        private System.Windows.Forms.Button dbexcluir;
        private System.Windows.Forms.Button dbAlterar;
        private System.Windows.Forms.Button dbbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtlivro;
        private System.Windows.Forms.TextBox txtacervo;
        private System.Windows.Forms.TextBox txtlocal;
        private System.Windows.Forms.TextBox txtpaginas;
        private System.Windows.Forms.TextBox txtvolume;
        private System.Windows.Forms.TextBox txtedicao;
        private System.Windows.Forms.TextBox txteditora;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

