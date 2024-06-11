
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
            this.dtGridProfessores = new System.Windows.Forms.DataGridView();
            this.txtapelidoprof = new System.Windows.Forms.TextBox();
            this.apelidoprofessor = new System.Windows.Forms.Label();
            this.txtnomeprofessor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntcadastrarprof = new System.Windows.Forms.Button();
            this.numericidprof = new System.Windows.Forms.NumericUpDown();
            this.btnlimparprof = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProfessores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericidprof)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridProfessores
            // 
            this.dtGridProfessores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProfessores.Location = new System.Drawing.Point(43, 91);
            this.dtGridProfessores.Name = "dtGridProfessores";
            this.dtGridProfessores.Size = new System.Drawing.Size(695, 324);
            this.dtGridProfessores.TabIndex = 22;
            this.dtGridProfessores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCursos_CellContentClick);
            // 
            // txtapelidoprof
            // 
            this.txtapelidoprof.Location = new System.Drawing.Point(436, 44);
            this.txtapelidoprof.Name = "txtapelidoprof";
            this.txtapelidoprof.Size = new System.Drawing.Size(100, 20);
            this.txtapelidoprof.TabIndex = 20;
            this.txtapelidoprof.TextChanged += new System.EventHandler(this.txtturno_TextChanged);
            // 
            // apelidoprofessor
            // 
            this.apelidoprofessor.AutoSize = true;
            this.apelidoprofessor.Location = new System.Drawing.Point(433, 27);
            this.apelidoprofessor.Name = "apelidoprofessor";
            this.apelidoprofessor.Size = new System.Drawing.Size(103, 13);
            this.apelidoprofessor.TabIndex = 19;
            this.apelidoprofessor.Text = "Apelido do professor";
            this.apelidoprofessor.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtnomeprofessor
            // 
            this.txtnomeprofessor.Location = new System.Drawing.Point(239, 44);
            this.txtnomeprofessor.Name = "txtnomeprofessor";
            this.txtnomeprofessor.Size = new System.Drawing.Size(100, 20);
            this.txtnomeprofessor.TabIndex = 18;
            this.txtnomeprofessor.TextChanged += new System.EventHandler(this.txtnomecurso_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nome do Professor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // bntcadastrarprof
            // 
            this.bntcadastrarprof.Location = new System.Drawing.Point(631, 18);
            this.bntcadastrarprof.Name = "bntcadastrarprof";
            this.bntcadastrarprof.Size = new System.Drawing.Size(107, 33);
            this.bntcadastrarprof.TabIndex = 12;
            this.bntcadastrarprof.Text = "Cadastrar professor";
            this.bntcadastrarprof.UseVisualStyleBackColor = true;
            this.bntcadastrarprof.Click += new System.EventHandler(this.bntcadastrarcurso_Click);
            // 
            // numericidprof
            // 
            this.numericidprof.Location = new System.Drawing.Point(43, 44);
            this.numericidprof.Name = "numericidprof";
            this.numericidprof.Size = new System.Drawing.Size(120, 20);
            this.numericidprof.TabIndex = 23;
            this.numericidprof.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnlimparprof
            // 
            this.btnlimparprof.Location = new System.Drawing.Point(645, 57);
            this.btnlimparprof.Name = "btnlimparprof";
            this.btnlimparprof.Size = new System.Drawing.Size(75, 23);
            this.btnlimparprof.TabIndex = 24;
            this.btnlimparprof.Text = "Limpar";
            this.btnlimparprof.UseVisualStyleBackColor = true;
            this.btnlimparprof.Click += new System.EventHandler(this.btnlimparprof_Click);
            // 
            // frmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimparprof);
            this.Controls.Add(this.numericidprof);
            this.Controls.Add(this.dtGridProfessores);
            this.Controls.Add(this.txtapelidoprof);
            this.Controls.Add(this.apelidoprofessor);
            this.Controls.Add(this.txtnomeprofessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntcadastrarprof);
            this.Name = "frmProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfessores";
            this.Load += new System.EventHandler(this.frmProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProfessores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericidprof)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridProfessores;
        private System.Windows.Forms.TextBox txtapelidoprof;
        private System.Windows.Forms.Label apelidoprofessor;
        private System.Windows.Forms.TextBox txtnomeprofessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntcadastrarprof;
        private System.Windows.Forms.NumericUpDown numericidprof;
        private System.Windows.Forms.Button btnlimparprof;
    }
}