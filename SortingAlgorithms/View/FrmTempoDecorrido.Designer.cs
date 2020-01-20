namespace SortingAlgorithms.View
{
    partial class FrmTempoDecorrido
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNComparacoes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNTrocas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo de execução";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(121, 86);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(104, 28);
            this.lblTempo.TabIndex = 0;
            this.lblTempo.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº Comparações:";
            // 
            // lblNComparacoes
            // 
            this.lblNComparacoes.AutoSize = true;
            this.lblNComparacoes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNComparacoes.Location = new System.Drawing.Point(218, 143);
            this.lblNComparacoes.Name = "lblNComparacoes";
            this.lblNComparacoes.Size = new System.Drawing.Size(21, 22);
            this.lblNComparacoes.TabIndex = 1;
            this.lblNComparacoes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nº Trocas: ";
            // 
            // lblNTrocas
            // 
            this.lblNTrocas.AutoSize = true;
            this.lblNTrocas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTrocas.Location = new System.Drawing.Point(218, 170);
            this.lblNTrocas.Name = "lblNTrocas";
            this.lblNTrocas.Size = new System.Drawing.Size(21, 22);
            this.lblNTrocas.TabIndex = 1;
            this.lblNTrocas.Text = "0";
            // 
            // FrmTempoDecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 229);
            this.Controls.Add(this.lblNTrocas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNComparacoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTempoDecorrido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tempo Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNComparacoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNTrocas;
    }
}