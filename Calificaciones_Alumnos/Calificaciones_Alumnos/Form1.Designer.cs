namespace Calificaciones_Alumnos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_abrir = new System.Windows.Forms.Button();
            this.chart_Alumnos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_Grados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblmayor = new System.Windows.Forms.Label();
            this.lblmenor = new System.Windows.Forms.Label();
            this.lblnombremayor = new System.Windows.Forms.Label();
            this.lblnombremenor = new System.Windows.Forms.Label();
            this.lblpromediogral = new System.Windows.Forms.Label();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Grados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_abrir
            // 
            this.btn_abrir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir.Location = new System.Drawing.Point(609, 86);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(112, 37);
            this.btn_abrir.TabIndex = 0;
            this.btn_abrir.Text = "Examinar";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // chart_Alumnos
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Alumnos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Alumnos.Legends.Add(legend1);
            this.chart_Alumnos.Location = new System.Drawing.Point(12, 141);
            this.chart_Alumnos.Name = "chart_Alumnos";
            this.chart_Alumnos.Size = new System.Drawing.Size(522, 421);
            this.chart_Alumnos.TabIndex = 1;
            this.chart_Alumnos.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un archivo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart_Grados
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Grados.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Grados.Legends.Add(legend2);
            this.chart_Grados.Location = new System.Drawing.Point(586, 141);
            this.chart_Grados.Name = "chart_Grados";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series1.Legend = "Legend1";
            series1.Name = "Promedio";
            series1.YValuesPerPoint = 4;
            this.chart_Grados.Series.Add(series1);
            this.chart_Grados.Size = new System.Drawing.Size(509, 421);
            this.chart_Grados.TabIndex = 3;
            this.chart_Grados.Text = "chart1";
            // 
            // lblmayor
            // 
            this.lblmayor.AutoSize = true;
            this.lblmayor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmayor.Location = new System.Drawing.Point(12, 22);
            this.lblmayor.Name = "lblmayor";
            this.lblmayor.Size = new System.Drawing.Size(165, 19);
            this.lblmayor.TabIndex = 4;
            this.lblmayor.Text = "Mayor calificación: ";
            // 
            // lblmenor
            // 
            this.lblmenor.AutoSize = true;
            this.lblmenor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenor.Location = new System.Drawing.Point(12, 59);
            this.lblmenor.Name = "lblmenor";
            this.lblmenor.Size = new System.Drawing.Size(166, 19);
            this.lblmenor.TabIndex = 5;
            this.lblmenor.Text = "Menor calificación: ";
            // 
            // lblnombremayor
            // 
            this.lblnombremayor.AutoSize = true;
            this.lblnombremayor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombremayor.Location = new System.Drawing.Point(183, 22);
            this.lblnombremayor.Name = "lblnombremayor";
            this.lblnombremayor.Size = new System.Drawing.Size(0, 19);
            this.lblnombremayor.TabIndex = 6;
            // 
            // lblnombremenor
            // 
            this.lblnombremenor.AutoSize = true;
            this.lblnombremenor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombremenor.Location = new System.Drawing.Point(183, 59);
            this.lblnombremenor.Name = "lblnombremenor";
            this.lblnombremenor.Size = new System.Drawing.Size(0, 19);
            this.lblnombremenor.TabIndex = 7;
            // 
            // lblpromediogral
            // 
            this.lblpromediogral.AutoSize = true;
            this.lblpromediogral.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromediogral.Location = new System.Drawing.Point(12, 95);
            this.lblpromediogral.Name = "lblpromediogral";
            this.lblpromediogral.Size = new System.Drawing.Size(160, 19);
            this.lblpromediogral.TabIndex = 8;
            this.lblpromediogral.Text = "Promedio general:";
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.Location = new System.Drawing.Point(183, 95);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(0, 19);
            this.lblpromedio.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(826, 212);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.lblpromediogral);
            this.Controls.Add(this.lblnombremenor);
            this.Controls.Add(this.lblnombremayor);
            this.Controls.Add(this.lblmenor);
            this.Controls.Add(this.lblmayor);
            this.Controls.Add(this.chart_Grados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_Alumnos);
            this.Controls.Add(this.btn_abrir);
            this.Name = "Form1";
            this.Text = "Grafica Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Grados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Alumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Grados;
        private System.Windows.Forms.Label lblmayor;
        private System.Windows.Forms.Label lblmenor;
        private System.Windows.Forms.Label lblnombremayor;
        private System.Windows.Forms.Label lblnombremenor;
        private System.Windows.Forms.Label lblpromediogral;
        private System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

