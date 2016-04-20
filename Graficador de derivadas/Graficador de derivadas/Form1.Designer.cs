namespace Graficador_de_derivadas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.Funcion = new System.Windows.Forms.TextBox();
            this.interizq = new System.Windows.Forms.TextBox();
            this.interder = new System.Windows.Forms.TextBox();
            this.minx = new System.Windows.Forms.TextBox();
            this.maxx = new System.Windows.Forms.TextBox();
            this.miny = new System.Windows.Forms.TextBox();
            this.maxy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(920, 321);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(796, 612);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la expresión de la función";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "f(x)=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese el intervalo donde graficar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese el intervalo izquierdo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese el intervalo derecho:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rango de ejes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rango mínimo del Eje x:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Rango máximo del Eje x:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Rango mínimo del Eje y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Rango máximo del Eje y:";
            // 
            // Funcion
            // 
            this.Funcion.Location = new System.Drawing.Point(68, 56);
            this.Funcion.Name = "Funcion";
            this.Funcion.Size = new System.Drawing.Size(242, 26);
            this.Funcion.TabIndex = 11;
            // 
            // interizq
            // 
            this.interizq.Location = new System.Drawing.Point(236, 141);
            this.interizq.Name = "interizq";
            this.interizq.Size = new System.Drawing.Size(100, 26);
            this.interizq.TabIndex = 12;
            // 
            // interder
            // 
            this.interder.Location = new System.Drawing.Point(236, 181);
            this.interder.Name = "interder";
            this.interder.Size = new System.Drawing.Size(100, 26);
            this.interder.TabIndex = 13;
            // 
            // minx
            // 
            this.minx.Location = new System.Drawing.Point(210, 289);
            this.minx.Name = "minx";
            this.minx.Size = new System.Drawing.Size(100, 26);
            this.minx.TabIndex = 14;
            // 
            // maxx
            // 
            this.maxx.Location = new System.Drawing.Point(210, 321);
            this.maxx.Name = "maxx";
            this.maxx.Size = new System.Drawing.Size(100, 26);
            this.maxx.TabIndex = 15;
            // 
            // miny
            // 
            this.miny.Location = new System.Drawing.Point(210, 353);
            this.miny.Name = "miny";
            this.miny.Size = new System.Drawing.Size(100, 26);
            this.miny.TabIndex = 16;
            // 
            // maxy
            // 
            this.maxy.Location = new System.Drawing.Point(210, 385);
            this.maxy.Name = "maxy";
            this.maxy.Size = new System.Drawing.Size(100, 26);
            this.maxy.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 945);
            this.Controls.Add(this.maxy);
            this.Controls.Add(this.miny);
            this.Controls.Add(this.maxx);
            this.Controls.Add(this.minx);
            this.Controls.Add(this.interder);
            this.Controls.Add(this.interizq);
            this.Controls.Add(this.Funcion);
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
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Funcion;
        private System.Windows.Forms.TextBox interizq;
        private System.Windows.Forms.TextBox interder;
        private System.Windows.Forms.TextBox minx;
        private System.Windows.Forms.TextBox maxx;
        private System.Windows.Forms.TextBox miny;
        private System.Windows.Forms.TextBox maxy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

