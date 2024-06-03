
namespace MapaSala.Formularios
{
    partial class frmDisciplinas
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
            this.dtGridProfessor = new System.Windows.Forms.DataGridView();
            this.chkativo = new System.Windows.Forms.CheckBox();
            this.txtapelido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnomeprofessor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidprofessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntcadastrarprofessor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridProfessor
            // 
            this.dtGridProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProfessor.Location = new System.Drawing.Point(41, 89);
            this.dtGridProfessor.Name = "dtGridProfessor";
            this.dtGridProfessor.Size = new System.Drawing.Size(695, 324);
            this.dtGridProfessor.TabIndex = 22;
            // 
            // chkativo
            // 
            this.chkativo.AutoSize = true;
            this.chkativo.Location = new System.Drawing.Point(493, 42);
            this.chkativo.Name = "chkativo";
            this.chkativo.Size = new System.Drawing.Size(58, 17);
            this.chkativo.TabIndex = 21;
            this.chkativo.Text = "ATIVO";
            this.chkativo.UseVisualStyleBackColor = true;
            // 
            // txtapelido
            // 
            this.txtapelido.Location = new System.Drawing.Point(313, 40);
            this.txtapelido.Name = "txtapelido";
            this.txtapelido.Size = new System.Drawing.Size(100, 20);
            this.txtapelido.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Turno";
            // 
            // txtnomeprofessor
            // 
            this.txtnomeprofessor.Location = new System.Drawing.Point(181, 39);
            this.txtnomeprofessor.Name = "txtnomeprofessor";
            this.txtnomeprofessor.Size = new System.Drawing.Size(100, 20);
            this.txtnomeprofessor.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nome do Curso";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtidprofessor
            // 
            this.txtidprofessor.Location = new System.Drawing.Point(41, 39);
            this.txtidprofessor.Name = "txtidprofessor";
            this.txtidprofessor.Size = new System.Drawing.Size(100, 20);
            this.txtidprofessor.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // bntcadastrarprofessor
            // 
            this.bntcadastrarprofessor.Location = new System.Drawing.Point(629, 33);
            this.bntcadastrarprofessor.Name = "bntcadastrarprofessor";
            this.bntcadastrarprofessor.Size = new System.Drawing.Size(107, 33);
            this.bntcadastrarprofessor.TabIndex = 12;
            this.bntcadastrarprofessor.Text = "cadastrar curso";
            this.bntcadastrarprofessor.UseVisualStyleBackColor = true;
            // 
            // frmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridProfessor);
            this.Controls.Add(this.chkativo);
            this.Controls.Add(this.txtapelido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnomeprofessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidprofessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntcadastrarprofessor);
            this.Name = "frmDisciplinas";
            this.Text = "frmDisciplinas";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridProfessor;
        private System.Windows.Forms.CheckBox chkativo;
        private System.Windows.Forms.TextBox txtapelido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnomeprofessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidprofessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntcadastrarprofessor;
    }
}