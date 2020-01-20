namespace SortingAlgorithms
{
    partial class Frmhome
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
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnCountingSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.richTxTBResultado = new System.Windows.Forms.RichTextBox();
            this.cBoxArquivo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(320, -78);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(43, 13);
            this.lblTempo.TabIndex = 11;
            this.lblTempo.Text = "Tempo:";
            // 
            // btnCountingSort
            // 
            this.btnCountingSort.Location = new System.Drawing.Point(440, 202);
            this.btnCountingSort.Margin = new System.Windows.Forms.Padding(5);
            this.btnCountingSort.Name = "btnCountingSort";
            this.btnCountingSort.Size = new System.Drawing.Size(127, 73);
            this.btnCountingSort.TabIndex = 6;
            this.btnCountingSort.Text = "Counting Sort";
            this.btnCountingSort.UseVisualStyleBackColor = true;
            this.btnCountingSort.Click += new System.EventHandler(this.btnCountingSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(440, 368);
            this.btnSelectionSort.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(127, 73);
            this.btnSelectionSort.TabIndex = 7;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(440, 285);
            this.btnQuickSort.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(127, 73);
            this.btnQuickSort.TabIndex = 8;
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(440, 119);
            this.btnInsertionSort.Margin = new System.Windows.Forms.Padding(5);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(127, 73);
            this.btnInsertionSort.TabIndex = 9;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(440, 36);
            this.btnBubbleSort.Margin = new System.Windows.Forms.Padding(5);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(127, 73);
            this.btnBubbleSort.TabIndex = 10;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(-22, -98);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(278, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Algoritmos de Ordenação";
            // 
            // richTxTBResultado
            // 
            this.richTxTBResultado.Location = new System.Drawing.Point(4, 3);
            this.richTxTBResultado.Margin = new System.Windows.Forms.Padding(5);
            this.richTxTBResultado.Name = "richTxTBResultado";
            this.richTxTBResultado.ReadOnly = true;
            this.richTxTBResultado.Size = new System.Drawing.Size(426, 437);
            this.richTxTBResultado.TabIndex = 4;
            this.richTxTBResultado.Text = "";
            // 
            // cBoxArquivo
            // 
            this.cBoxArquivo.AutoCompleteCustomSource.AddRange(new string[] {
            "Desordenado100k",
            "Reverso100k",
            "Ordenado100k",
            "Desordenado1kk",
            "Reverso1kk",
            "Ordenado1kk",
            "Desordenado5kk",
            "Reverso5kk",
            "Ordenado5kk",
            "Desordenado10kk",
            "Reverso10kk",
            "Ordenado10kk"});
            this.cBoxArquivo.FormattingEnabled = true;
            this.cBoxArquivo.Items.AddRange(new object[] {
            "Desordenado100k",
            "Reverso100k",
            "Ordenado100k",
            "Desordenado1kk",
            "Reverso1kk",
            "Ordenado1kk",
            "Desordenado5kk",
            "Reverso5kk",
            "Ordenado5kk",
            "Desordenado10kk",
            "Reverso10kk",
            "Ordenado10kk"});
            this.cBoxArquivo.Location = new System.Drawing.Point(440, 7);
            this.cBoxArquivo.Name = "cBoxArquivo";
            this.cBoxArquivo.Size = new System.Drawing.Size(127, 21);
            this.cBoxArquivo.TabIndex = 12;
            // 
            // Frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 443);
            this.Controls.Add(this.cBoxArquivo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnCountingSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.richTxTBResultado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Frmhome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmos de Ordenação - Estrutura de Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button btnCountingSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox richTxTBResultado;
        private System.Windows.Forms.ComboBox cBoxArquivo;
    }
}

