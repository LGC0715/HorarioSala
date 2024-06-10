
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
            this.dtGridDisciplina = new System.Windows.Forms.DataGridView();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnomedisciplina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtiddisciplinas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntcadastrardisciplina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridDisciplina
            // 
            this.dtGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDisciplina.Location = new System.Drawing.Point(41, 89);
            this.dtGridDisciplina.Name = "dtGridDisciplina";
            this.dtGridDisciplina.Size = new System.Drawing.Size(695, 324);
            this.dtGridDisciplina.TabIndex = 22;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(410, 46);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 20);
            this.txtarea.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Area";
            // 
            // txtnomedisciplina
            // 
            this.txtnomedisciplina.Location = new System.Drawing.Point(223, 46);
            this.txtnomedisciplina.Name = "txtnomedisciplina";
            this.txtnomedisciplina.Size = new System.Drawing.Size(100, 20);
            this.txtnomedisciplina.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nome da Disciplina";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtiddisciplinas
            // 
            this.txtiddisciplinas.Location = new System.Drawing.Point(51, 46);
            this.txtiddisciplinas.Name = "txtiddisciplinas";
            this.txtiddisciplinas.Size = new System.Drawing.Size(100, 20);
            this.txtiddisciplinas.TabIndex = 16;
            this.txtiddisciplinas.TextChanged += new System.EventHandler(this.txtidprofessor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 30);
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
            // bntcadastrardisciplina
            // 
            this.bntcadastrardisciplina.Location = new System.Drawing.Point(629, 33);
            this.bntcadastrardisciplina.Name = "bntcadastrardisciplina";
            this.bntcadastrardisciplina.Size = new System.Drawing.Size(107, 33);
            this.bntcadastrardisciplina.TabIndex = 12;
            this.bntcadastrardisciplina.Text = "cadastrar disciplina";
            this.bntcadastrardisciplina.UseVisualStyleBackColor = true;
            this.bntcadastrardisciplina.Click += new System.EventHandler(this.bntcadastrardisciplina_Click);
            // 
            // frmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridDisciplina);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnomedisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtiddisciplinas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntcadastrardisciplina);
            this.Name = "frmDisciplinas";
            this.Text = "frmDisciplinas";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridDisciplina;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnomedisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtiddisciplinas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntcadastrardisciplina;
    }
}