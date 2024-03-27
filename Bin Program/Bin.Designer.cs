namespace Bin_Program
{
    partial class Bin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtBin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtNumBins = new System.Windows.Forms.TextBox();
            this.txtStDvN = new System.Windows.Forms.TextBox();
            this.txtNumI = new System.Windows.Forms.TextBox();
            this.txtStDvPV = new System.Windows.Forms.TextBox();
            this.txtMeanPV = new System.Windows.Forms.TextBox();
            this.txtMeanN = new System.Windows.Forms.TextBox();
            this.grpPv = new System.Windows.Forms.GroupBox();
            this.lblStMaxPV = new System.Windows.Forms.Label();
            this.lblMeanMinPV = new System.Windows.Forms.Label();
            this.rdoNormPV = new System.Windows.Forms.RadioButton();
            this.rdoUniPV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMinMeanN = new System.Windows.Forms.Label();
            this.lblStMaxN = new System.Windows.Forms.Label();
            this.rdoNormN = new System.Windows.Forms.RadioButton();
            this.rdoUniN = new System.Windows.Forms.RadioButton();
            this.lblNumBins = new System.Windows.Forms.Label();
            this.lblNumI = new System.Windows.Forms.Label();
            this.lblAvgProfitLabel = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.btnRunSim = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtBin)).BeginInit();
            this.grpPv.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtBin
            // 
            chartArea1.Name = "ChartArea1";
            this.chtBin.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtBin.Legends.Add(legend1);
            this.chtBin.Location = new System.Drawing.Point(65, 40);
            this.chtBin.Name = "chtBin";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.Name = "Profit";
            this.chtBin.Series.Add(series1);
            this.chtBin.Size = new System.Drawing.Size(519, 304);
            this.chtBin.TabIndex = 0;
            this.chtBin.Text = "chart1";
            this.chtBin.Click += new System.EventHandler(this.chart1_Click);
            // 
            // txtNumBins
            // 
            this.txtNumBins.Location = new System.Drawing.Point(124, 353);
            this.txtNumBins.Name = "txtNumBins";
            this.txtNumBins.Size = new System.Drawing.Size(100, 20);
            this.txtNumBins.TabIndex = 1;
            this.txtNumBins.TextChanged += new System.EventHandler(this.txtNumBins_TextChanged);
            // 
            // txtStDvN
            // 
            this.txtStDvN.Location = new System.Drawing.Point(160, 137);
            this.txtStDvN.Name = "txtStDvN";
            this.txtStDvN.Size = new System.Drawing.Size(66, 20);
            this.txtStDvN.TabIndex = 2;
            this.txtStDvN.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNumI
            // 
            this.txtNumI.Location = new System.Drawing.Point(404, 350);
            this.txtNumI.Name = "txtNumI";
            this.txtNumI.Size = new System.Drawing.Size(100, 20);
            this.txtNumI.TabIndex = 3;
            this.txtNumI.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtStDvPV
            // 
            this.txtStDvPV.Location = new System.Drawing.Point(147, 141);
            this.txtStDvPV.Name = "txtStDvPV";
            this.txtStDvPV.Size = new System.Drawing.Size(53, 20);
            this.txtStDvPV.TabIndex = 4;
            this.txtStDvPV.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtMeanPV
            // 
            this.txtMeanPV.Location = new System.Drawing.Point(147, 104);
            this.txtMeanPV.Name = "txtMeanPV";
            this.txtMeanPV.Size = new System.Drawing.Size(53, 20);
            this.txtMeanPV.TabIndex = 5;
            // 
            // txtMeanN
            // 
            this.txtMeanN.Location = new System.Drawing.Point(160, 108);
            this.txtMeanN.Name = "txtMeanN";
            this.txtMeanN.Size = new System.Drawing.Size(66, 20);
            this.txtMeanN.TabIndex = 6;
            // 
            // grpPv
            // 
            this.grpPv.Controls.Add(this.lblStMaxPV);
            this.grpPv.Controls.Add(this.lblMeanMinPV);
            this.grpPv.Controls.Add(this.rdoNormPV);
            this.grpPv.Controls.Add(this.rdoUniPV);
            this.grpPv.Controls.Add(this.txtStDvPV);
            this.grpPv.Controls.Add(this.txtMeanPV);
            this.grpPv.Location = new System.Drawing.Point(39, 381);
            this.grpPv.Name = "grpPv";
            this.grpPv.Size = new System.Drawing.Size(252, 163);
            this.grpPv.TabIndex = 7;
            this.grpPv.TabStop = false;
            this.grpPv.Text = "Pv";
            // 
            // lblStMaxPV
            // 
            this.lblStMaxPV.AutoSize = true;
            this.lblStMaxPV.Location = new System.Drawing.Point(15, 144);
            this.lblStMaxPV.Name = "lblStMaxPV";
            this.lblStMaxPV.Size = new System.Drawing.Size(73, 13);
            this.lblStMaxPV.TabIndex = 12;
            this.lblStMaxPV.Text = "Standard Dev";
            // 
            // lblMeanMinPV
            // 
            this.lblMeanMinPV.AutoSize = true;
            this.lblMeanMinPV.Location = new System.Drawing.Point(15, 115);
            this.lblMeanMinPV.Name = "lblMeanMinPV";
            this.lblMeanMinPV.Size = new System.Drawing.Size(37, 13);
            this.lblMeanMinPV.TabIndex = 16;
            this.lblMeanMinPV.Text = "Mean:";
            // 
            // rdoNormPV
            // 
            this.rdoNormPV.AutoSize = true;
            this.rdoNormPV.Checked = true;
            this.rdoNormPV.Location = new System.Drawing.Point(18, 42);
            this.rdoNormPV.Name = "rdoNormPV";
            this.rdoNormPV.Size = new System.Drawing.Size(58, 17);
            this.rdoNormPV.TabIndex = 10;
            this.rdoNormPV.TabStop = true;
            this.rdoNormPV.Text = "Normal";
            this.rdoNormPV.UseVisualStyleBackColor = true;
            // 
            // rdoUniPV
            // 
            this.rdoUniPV.AutoSize = true;
            this.rdoUniPV.Location = new System.Drawing.Point(18, 19);
            this.rdoUniPV.Name = "rdoUniPV";
            this.rdoUniPV.Size = new System.Drawing.Size(61, 17);
            this.rdoUniPV.TabIndex = 11;
            this.rdoUniPV.Text = "Uniform";
            this.rdoUniPV.UseVisualStyleBackColor = true;
            this.rdoUniPV.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMinMeanN);
            this.groupBox1.Controls.Add(this.lblStMaxN);
            this.groupBox1.Controls.Add(this.rdoNormN);
            this.groupBox1.Controls.Add(this.rdoUniN);
            this.groupBox1.Controls.Add(this.txtStDvN);
            this.groupBox1.Controls.Add(this.txtMeanN);
            this.groupBox1.Location = new System.Drawing.Point(445, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 163);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "N";
            // 
            // lblMinMeanN
            // 
            this.lblMinMeanN.AutoSize = true;
            this.lblMinMeanN.Location = new System.Drawing.Point(78, 111);
            this.lblMinMeanN.Name = "lblMinMeanN";
            this.lblMinMeanN.Size = new System.Drawing.Size(24, 13);
            this.lblMinMeanN.TabIndex = 11;
            this.lblMinMeanN.Text = "Min";
            // 
            // lblStMaxN
            // 
            this.lblStMaxN.AutoSize = true;
            this.lblStMaxN.Location = new System.Drawing.Point(78, 138);
            this.lblStMaxN.Name = "lblStMaxN";
            this.lblStMaxN.Size = new System.Drawing.Size(27, 13);
            this.lblStMaxN.TabIndex = 10;
            this.lblStMaxN.Text = "Max";
            this.lblStMaxN.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdoNormN
            // 
            this.rdoNormN.AutoSize = true;
            this.rdoNormN.Location = new System.Drawing.Point(30, 42);
            this.rdoNormN.Name = "rdoNormN";
            this.rdoNormN.Size = new System.Drawing.Size(58, 17);
            this.rdoNormN.TabIndex = 8;
            this.rdoNormN.Text = "Normal";
            this.rdoNormN.UseVisualStyleBackColor = true;
            this.rdoNormN.CheckedChanged += new System.EventHandler(this.rdoNormN_CheckedChanged);
            // 
            // rdoUniN
            // 
            this.rdoUniN.AutoSize = true;
            this.rdoUniN.Checked = true;
            this.rdoUniN.Location = new System.Drawing.Point(27, 19);
            this.rdoUniN.Name = "rdoUniN";
            this.rdoUniN.Size = new System.Drawing.Size(61, 17);
            this.rdoUniN.TabIndex = 9;
            this.rdoUniN.TabStop = true;
            this.rdoUniN.Text = "Uniform\r\n";
            this.rdoUniN.UseVisualStyleBackColor = true;
            // 
            // lblNumBins
            // 
            this.lblNumBins.AutoSize = true;
            this.lblNumBins.Location = new System.Drawing.Point(36, 353);
            this.lblNumBins.Name = "lblNumBins";
            this.lblNumBins.Size = new System.Drawing.Size(82, 13);
            this.lblNumBins.TabIndex = 13;
            this.lblNumBins.Text = "Number of Bins:";
            this.lblNumBins.Click += new System.EventHandler(this.lblNumBins_Click);
            // 
            // lblNumI
            // 
            this.lblNumI.AutoSize = true;
            this.lblNumI.Location = new System.Drawing.Point(283, 353);
            this.lblNumI.Name = "lblNumI";
            this.lblNumI.Size = new System.Drawing.Size(102, 13);
            this.lblNumI.TabIndex = 14;
            this.lblNumI.Text = "Number of Iterations";
            this.lblNumI.Click += new System.EventHandler(this.lblNumI_Click);
            // 
            // lblAvgProfitLabel
            // 
            this.lblAvgProfitLabel.AutoSize = true;
            this.lblAvgProfitLabel.Location = new System.Drawing.Point(619, 65);
            this.lblAvgProfitLabel.Name = "lblAvgProfitLabel";
            this.lblAvgProfitLabel.Size = new System.Drawing.Size(101, 13);
            this.lblAvgProfitLabel.TabIndex = 15;
            this.lblAvgProfitLabel.Text = "Average Total Profit";
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(622, 103);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(100, 20);
            this.txtAvg.TabIndex = 17;
            // 
            // btnRunSim
            // 
            this.btnRunSim.Location = new System.Drawing.Point(602, 194);
            this.btnRunSim.Name = "btnRunSim";
            this.btnRunSim.Size = new System.Drawing.Size(112, 53);
            this.btnRunSim.TabIndex = 18;
            this.btnRunSim.Text = "Run Simulation";
            this.btnRunSim.UseVisualStyleBackColor = true;
            this.btnRunSim.Click += new System.EventHandler(this.btnRunSim_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(733, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 53);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 570);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRunSim);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.lblNumBins);
            this.Controls.Add(this.lblNumI);
            this.Controls.Add(this.lblAvgProfitLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPv);
            this.Controls.Add(this.txtNumI);
            this.Controls.Add(this.txtNumBins);
            this.Controls.Add(this.chtBin);
            this.Name = "Bin";
            this.Text = "Monte Carlo Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtBin)).EndInit();
            this.grpPv.ResumeLayout(false);
            this.grpPv.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtBin;
        private System.Windows.Forms.TextBox txtNumBins;
        private System.Windows.Forms.TextBox txtStDvN;
        private System.Windows.Forms.TextBox txtNumI;
        private System.Windows.Forms.TextBox txtStDvPV;
        private System.Windows.Forms.TextBox txtMeanPV;
        private System.Windows.Forms.TextBox txtMeanN;
        private System.Windows.Forms.GroupBox grpPv;
        private System.Windows.Forms.RadioButton rdoNormPV;
        private System.Windows.Forms.RadioButton rdoUniPV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNormN;
        private System.Windows.Forms.RadioButton rdoUniN;
        private System.Windows.Forms.Label lblStMaxPV;
        private System.Windows.Forms.Label lblMeanMinPV;
        private System.Windows.Forms.Label lblMinMeanN;
        private System.Windows.Forms.Label lblStMaxN;
        private System.Windows.Forms.Label lblNumBins;
        private System.Windows.Forms.Label lblNumI;
        private System.Windows.Forms.Label lblAvgProfitLabel;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.Button btnRunSim;
        private System.Windows.Forms.Button btnExit;
    }
}

