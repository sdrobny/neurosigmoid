namespace neurosigmoid
{
    partial class neurosigmoid
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.networkGraph = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rmsChart = new System.Windows.Forms.PictureBox();
            this.runButton = new System.Windows.Forms.Button();
            this.trainButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.networkGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // networkGraph
            // 
            this.networkGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.networkGraph.Location = new System.Drawing.Point(11, 25);
            this.networkGraph.Name = "networkGraph";
            this.networkGraph.Size = new System.Drawing.Size(380, 238);
            this.networkGraph.TabIndex = 0;
            this.networkGraph.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Struktura sieci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wykres RMS:";
            // 
            // rmsChart
            // 
            this.rmsChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rmsChart.Location = new System.Drawing.Point(11, 558);
            this.rmsChart.Name = "rmsChart";
            this.rmsChart.Size = new System.Drawing.Size(761, 48);
            this.rmsChart.TabIndex = 3;
            this.rmsChart.TabStop = false;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(18, 324);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(352, 23);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "Uruchom sieć";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(18, 408);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(355, 23);
            this.trainButton.TabIndex = 5;
            this.trainButton.Text = "Trenuj sieć";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 298);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ilosc neuronow - 1 warstwa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ilosc neuronow - 2 warstwa:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 379);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "10000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ilosc cykli:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Częstotliwość uczenia";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 356);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(213, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "0,9";
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.treeView1.Location = new System.Drawing.Point(398, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.Size = new System.Drawing.Size(374, 527);
            this.treeView1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Reset sieci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // neurosigmoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.rmsChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.networkGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "neurosigmoid";
            this.Text = "neurosigmoid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.networkGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox networkGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox rmsChart;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
    }
}

