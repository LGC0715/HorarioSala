
namespace MapaSala.Formularios
{
    partial class frmCursos
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
            this.bntcadastrarcurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidcurso = new System.Windows.Forms.TextBox();
            this.txtnomecurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtturno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtGridCursos = new System.Windows.Forms.DataGridView();
            this.chkativo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // bntcadastrarcurso
            // 
            this.bntcadastrarcurso.Location = new System.Drawing.Point(640, 34);
            this.bntcadastrarcurso.Name = "bntcadastrarcurso";
            this.bntcadastrarcurso.Size = new System.Drawing.Size(107, 33);
            this.bntcadastrarcurso.TabIndex = 0;
            this.bntcadastrarcurso.Text = "cadastrar curso";
            this.bntcadastrarcurso.UseVisualStyleBackColor = true;
            this.bntcadastrarcurso.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtidcurso
            // 
            this.txtidcurso.Location = new System.Drawing.Point(52, 40);
            this.txtidcurso.Name = "txtidcurso";
            this.txtidcurso.Size = new System.Drawing.Size(100, 20);
            this.txtidcurso.TabIndex = 4;
            this.txtidcurso.TextChanged += new System.EventHandler(this.txtidcurso_TextChanged);
            // 
            // txtnomecurso
            // 
            this.txtnomecurso.Location = new System.Drawing.Point(192, 40);
            this.txtnomecurso.Name = "txtnomecurso";
            this.txtnomecurso.Size = new System.Drawing.Size(100, 20);
            this.txtnomecurso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome do Curso";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtturno
            // 
            this.txtturno.Location = new System.Drawing.Point(324, 41);
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(100, 20);
            this.txtturno.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Turno";
            // 
            // dtGridCursos
            // 
            this.dtGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursos.Location = new System.Drawing.Point(52, 90);
            this.dtGridCursos.Name = "dtGridCursos";
            this.dtGridCursos.Size = new System.Drawing.Size(695, 324);
            this.dtGridCursos.TabIndex = 11;
            // 
            // chkativo
            // 
            this.chkativo.AutoSize = true;
            this.chkativo.Location = new System.Drawing.Point(504, 43);
            this.chkativo.Name = "chkativo";
            this.chkativo.Size = new System.Drawing.Size(58, 17);
            this.chkativo.TabIndex = 10;
            this.chkativo.Text = "ATIVO";
            this.chkativo.UseVisualStyleBackColor = true;
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridCursos);
            this.Controls.Add(this.chkativo);
            this.Controls.Add(this.txtturno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnomecurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidcurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntcadastrarcurso);
            this.Name = "frmCursos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntcadastrarcurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidcurso;
        private System.Windows.Forms.TextBox txtnomecurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtturno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtGridCursos;
        private System.Windows.Forms.CheckBox chkativo;
    }
}