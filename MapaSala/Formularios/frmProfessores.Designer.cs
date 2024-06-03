
namespace MapaSala.Formularios
{
    partial class frmProfessores
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
            this.dtGridCursos = new System.Windows.Forms.DataGridView();
            this.chkativo = new System.Windows.Forms.CheckBox();
            this.txtapelido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnomeprofessor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidprofessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntcadastrarcurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridCursos
            // 
            this.dtGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursos.Location = new System.Drawing.Point(43, 91);
            this.dtGridCursos.Name = "dtGridCursos";
            this.dtGridCursos.Size = new System.Drawing.Size(695, 324);
            this.dtGridCursos.TabIndex = 22;
            this.dtGridCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCursos_CellContentClick);
            // 
            // chkativo
            // 
            this.chkativo.AutoSize = true;
            this.chkativo.Location = new System.Drawing.Point(495, 44);
            this.chkativo.Name = "chkativo";
            this.chkativo.Size = new System.Drawing.Size(58, 17);
            this.chkativo.TabIndex = 21;
            this.chkativo.Text = "ATIVO";
            this.chkativo.UseVisualStyleBackColor = true;
            this.chkativo.CheckedChanged += new System.EventHandler(this.chkativo_CheckedChanged);
            // 
            // txtapelido
            // 
            this.txtapelido.Location = new System.Drawing.Point(315, 42);
            this.txtapelido.Name = "txtapelido";
            this.txtapelido.Size = new System.Drawing.Size(100, 20);
            this.txtapelido.TabIndex = 20;
            this.txtapelido.TextChanged += new System.EventHandler(this.txtturno_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Apelido";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtnomeprofessor
            // 
            this.txtnomeprofessor.Location = new System.Drawing.Point(183, 41);
            this.txtnomeprofessor.Name = "txtnomeprofessor";
            this.txtnomeprofessor.Size = new System.Drawing.Size(100, 20);
            this.txtnomeprofessor.TabIndex = 18;
            this.txtnomeprofessor.TextChanged += new System.EventHandler(this.txtnomecurso_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nome do Curso";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtidprofessor
            // 
            this.txtidprofessor.Location = new System.Drawing.Point(43, 41);
            this.txtidprofessor.Name = "txtidprofessor";
            this.txtidprofessor.Size = new System.Drawing.Size(100, 20);
            this.txtidprofessor.TabIndex = 16;
            this.txtidprofessor.TextChanged += new System.EventHandler(this.txtidcurso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bntcadastrarcurso
            // 
            this.bntcadastrarcurso.Location = new System.Drawing.Point(631, 35);
            this.bntcadastrarcurso.Name = "bntcadastrarcurso";
            this.bntcadastrarcurso.Size = new System.Drawing.Size(107, 33);
            this.bntcadastrarcurso.TabIndex = 12;
            this.bntcadastrarcurso.Text = "cadastrar curso";
            this.bntcadastrarcurso.UseVisualStyleBackColor = true;
            this.bntcadastrarcurso.Click += new System.EventHandler(this.bntcadastrarcurso_Click);
            // 
            // frmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridCursos);
            this.Controls.Add(this.chkativo);
            this.Controls.Add(this.txtapelido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnomeprofessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidprofessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntcadastrarcurso);
            this.Name = "frmProfessores";
            this.Text = "frmProfessores";
            this.Load += new System.EventHandler(this.frmProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridCursos;
        private System.Windows.Forms.CheckBox chkativo;
        private System.Windows.Forms.TextBox txtapelido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnomeprofessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidprofessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntcadastrarcurso;
    }
}