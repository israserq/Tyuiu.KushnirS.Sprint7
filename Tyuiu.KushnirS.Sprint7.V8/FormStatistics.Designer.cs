namespace Tyuiu.KushnirS.Sprint7.V8
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            splitContainer_KS = new SplitContainer();
            groupBoxGrid_KS = new GroupBox();
            labelAquaRowCount_KS = new Label();
            labelRedRowsCount_KS = new Label();
            groupBoxAuto_KS = new GroupBox();
            labelPopularMark_KS = new Label();
            labelPopularLocation_KS = new Label();
            labelAutoCondition_KS = new Label();
            labelAutoCount_KS = new Label();
            groupBoxAutoStats_KS = new GroupBox();
            labelMaxFuel_KS = new Label();
            labelMinLoad_KS = new Label();
            labelAvgLoad_KS = new Label();
            labelMinFuel_KS = new Label();
            labelAvgSpeed_KS = new Label();
            labelMinSpeed_KS = new Label();
            labelAvgFuel_KS = new Label();
            labelMaxLoad_KS = new Label();
            labelMaxSpeed_KS = new Label();
            groupBoxDrivers_KS = new GroupBox();
            labelDriverCount_KS = new Label();
            chartMarkToSpeed_KS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelRichDriver_KS = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer_KS).BeginInit();
            splitContainer_KS.Panel1.SuspendLayout();
            splitContainer_KS.Panel2.SuspendLayout();
            splitContainer_KS.SuspendLayout();
            groupBoxGrid_KS.SuspendLayout();
            groupBoxAuto_KS.SuspendLayout();
            groupBoxAutoStats_KS.SuspendLayout();
            groupBoxDrivers_KS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMarkToSpeed_KS).BeginInit();
            SuspendLayout();
            // 
            // splitContainer_KS
            // 
            splitContainer_KS.Dock = DockStyle.Fill;
            splitContainer_KS.Location = new Point(0, 0);
            splitContainer_KS.Margin = new Padding(3, 2, 3, 2);
            splitContainer_KS.Name = "splitContainer_KS";
            // 
            // splitContainer_KS.Panel1
            // 
            splitContainer_KS.Panel1.BackColor = Color.LightSlateGray;
            splitContainer_KS.Panel1.Controls.Add(groupBoxGrid_KS);
            splitContainer_KS.Panel1.Controls.Add(groupBoxAuto_KS);
            splitContainer_KS.Panel1.Controls.Add(groupBoxAutoStats_KS);
            splitContainer_KS.Panel1.Controls.Add(groupBoxDrivers_KS);
            // 
            // splitContainer_KS.Panel2
            // 
            splitContainer_KS.Panel2.Controls.Add(chartMarkToSpeed_KS);
            splitContainer_KS.Size = new Size(935, 338);
            splitContainer_KS.SplitterDistance = 581;
            splitContainer_KS.TabIndex = 1;
            // 
            // groupBoxGrid_KS
            // 
            groupBoxGrid_KS.Controls.Add(labelAquaRowCount_KS);
            groupBoxGrid_KS.Controls.Add(labelRedRowsCount_KS);
            groupBoxGrid_KS.Font = new Font("Times New Roman", 10F);
            groupBoxGrid_KS.Location = new Point(318, 107);
            groupBoxGrid_KS.Margin = new Padding(3, 2, 3, 2);
            groupBoxGrid_KS.Name = "groupBoxGrid_KS";
            groupBoxGrid_KS.Padding = new Padding(3, 2, 3, 2);
            groupBoxGrid_KS.Size = new Size(261, 213);
            groupBoxGrid_KS.TabIndex = 0;
            groupBoxGrid_KS.TabStop = false;
            groupBoxGrid_KS.Text = "Таблица";
            // 
            // labelAquaRowCount_KS
            // 
            labelAquaRowCount_KS.AutoSize = true;
            labelAquaRowCount_KS.Location = new Point(1, 74);
            labelAquaRowCount_KS.Name = "labelAquaRowCount_KS";
            labelAquaRowCount_KS.Size = new Size(196, 16);
            labelAquaRowCount_KS.TabIndex = 0;
            labelAquaRowCount_KS.Text = "Количество добавленных строк:";
            // 
            // labelRedRowsCount_KS
            // 
            labelRedRowsCount_KS.AutoSize = true;
            labelRedRowsCount_KS.Location = new Point(6, 38);
            labelRedRowsCount_KS.Name = "labelRedRowsCount_KS";
            labelRedRowsCount_KS.Size = new Size(181, 16);
            labelRedRowsCount_KS.TabIndex = 0;
            labelRedRowsCount_KS.Text = "Количество удаленных строк:";
            // 
            // groupBoxAuto_KS
            // 
            groupBoxAuto_KS.Controls.Add(labelPopularMark_KS);
            groupBoxAuto_KS.Controls.Add(labelPopularLocation_KS);
            groupBoxAuto_KS.Controls.Add(labelAutoCondition_KS);
            groupBoxAuto_KS.Controls.Add(labelAutoCount_KS);
            groupBoxAuto_KS.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxAuto_KS.Location = new Point(195, 9);
            groupBoxAuto_KS.Margin = new Padding(3, 2, 3, 2);
            groupBoxAuto_KS.Name = "groupBoxAuto_KS";
            groupBoxAuto_KS.Padding = new Padding(3, 2, 3, 2);
            groupBoxAuto_KS.Size = new Size(384, 94);
            groupBoxAuto_KS.TabIndex = 0;
            groupBoxAuto_KS.TabStop = false;
            groupBoxAuto_KS.Text = "Машины";
            // 
            // labelPopularMark_KS
            // 
            labelPopularMark_KS.AutoSize = true;
            labelPopularMark_KS.Location = new Point(5, 24);
            labelPopularMark_KS.Name = "labelPopularMark_KS";
            labelPopularMark_KS.Size = new Size(167, 17);
            labelPopularMark_KS.TabIndex = 0;
            labelPopularMark_KS.Text = "Самая популярная марка:";
            // 
            // labelPopularLocation_KS
            // 
            labelPopularLocation_KS.AutoSize = true;
            labelPopularLocation_KS.Location = new Point(5, 54);
            labelPopularLocation_KS.Name = "labelPopularLocation_KS";
            labelPopularLocation_KS.Size = new Size(167, 17);
            labelPopularLocation_KS.TabIndex = 0;
            labelPopularLocation_KS.Text = "Самое популярное место:";
            // 
            // labelAutoCondition_KS
            // 
            labelAutoCondition_KS.AutoSize = true;
            labelAutoCondition_KS.Location = new Point(5, 39);
            labelAutoCondition_KS.Name = "labelAutoCondition_KS";
            labelAutoCondition_KS.Size = new Size(214, 17);
            labelAutoCondition_KS.TabIndex = 0;
            labelAutoCondition_KS.Text = "Подавляющее состояние машин:";
            // 
            // labelAutoCount_KS
            // 
            labelAutoCount_KS.AutoSize = true;
            labelAutoCount_KS.Location = new Point(5, 69);
            labelAutoCount_KS.Name = "labelAutoCount_KS";
            labelAutoCount_KS.Size = new Size(169, 17);
            labelAutoCount_KS.TabIndex = 0;
            labelAutoCount_KS.Text = "Количество автомобилей:";
            // 
            // groupBoxAutoStats_KS
            // 
            groupBoxAutoStats_KS.Controls.Add(labelMaxFuel_KS);
            groupBoxAutoStats_KS.Controls.Add(labelMinLoad_KS);
            groupBoxAutoStats_KS.Controls.Add(labelAvgLoad_KS);
            groupBoxAutoStats_KS.Controls.Add(labelMinFuel_KS);
            groupBoxAutoStats_KS.Controls.Add(labelAvgSpeed_KS);
            groupBoxAutoStats_KS.Controls.Add(labelMinSpeed_KS);
            groupBoxAutoStats_KS.Controls.Add(labelAvgFuel_KS);
            groupBoxAutoStats_KS.Controls.Add(labelMaxLoad_KS);
            groupBoxAutoStats_KS.Controls.Add(labelMaxSpeed_KS);
            groupBoxAutoStats_KS.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxAutoStats_KS.Location = new Point(10, 107);
            groupBoxAutoStats_KS.Margin = new Padding(3, 2, 3, 2);
            groupBoxAutoStats_KS.Name = "groupBoxAutoStats_KS";
            groupBoxAutoStats_KS.Padding = new Padding(3, 2, 3, 2);
            groupBoxAutoStats_KS.Size = new Size(303, 213);
            groupBoxAutoStats_KS.TabIndex = 0;
            groupBoxAutoStats_KS.TabStop = false;
            groupBoxAutoStats_KS.Text = "Характеристики машин";
            // 
            // labelMaxFuel_KS
            // 
            labelMaxFuel_KS.AutoSize = true;
            labelMaxFuel_KS.Location = new Point(2, 187);
            labelMaxFuel_KS.Name = "labelMaxFuel_KS";
            labelMaxFuel_KS.Size = new Size(165, 15);
            labelMaxFuel_KS.TabIndex = 0;
            labelMaxFuel_KS.Text = "Максимум расхода топлива:";
            // 
            // labelMinLoad_KS
            // 
            labelMinLoad_KS.AutoSize = true;
            labelMinLoad_KS.Location = new Point(5, 97);
            labelMinLoad_KS.Name = "labelMinLoad_KS";
            labelMinLoad_KS.Size = new Size(150, 15);
            labelMinLoad_KS.TabIndex = 0;
            labelMinLoad_KS.Text = "Минимум грузоподъема:";
            // 
            // labelAvgLoad_KS
            // 
            labelAvgLoad_KS.AutoSize = true;
            labelAvgLoad_KS.Location = new Point(6, 112);
            labelAvgLoad_KS.Name = "labelAvgLoad_KS";
            labelAvgLoad_KS.Size = new Size(134, 15);
            labelAvgLoad_KS.TabIndex = 0;
            labelAvgLoad_KS.Text = "Средний грузоподъем:";
            // 
            // labelMinFuel_KS
            // 
            labelMinFuel_KS.AutoSize = true;
            labelMinFuel_KS.Location = new Point(5, 161);
            labelMinFuel_KS.Name = "labelMinFuel_KS";
            labelMinFuel_KS.Size = new Size(161, 15);
            labelMinFuel_KS.TabIndex = 0;
            labelMinFuel_KS.Text = "Минимум расхода топлива:";
            // 
            // labelAvgSpeed_KS
            // 
            labelAvgSpeed_KS.AutoSize = true;
            labelAvgSpeed_KS.Location = new Point(5, 38);
            labelAvgSpeed_KS.Name = "labelAvgSpeed_KS";
            labelAvgSpeed_KS.Size = new Size(108, 15);
            labelAvgSpeed_KS.TabIndex = 0;
            labelAvgSpeed_KS.Text = "Средняя скорость:";
            // 
            // labelMinSpeed_KS
            // 
            labelMinSpeed_KS.AutoSize = true;
            labelMinSpeed_KS.Location = new Point(5, 17);
            labelMinSpeed_KS.Name = "labelMinSpeed_KS";
            labelMinSpeed_KS.Size = new Size(141, 15);
            labelMinSpeed_KS.TabIndex = 0;
            labelMinSpeed_KS.Text = "Минимальная скорость:";
            // 
            // labelAvgFuel_KS
            // 
            labelAvgFuel_KS.AutoSize = true;
            labelAvgFuel_KS.Location = new Point(5, 75);
            labelAvgFuel_KS.Name = "labelAvgFuel_KS";
            labelAvgFuel_KS.Size = new Size(145, 15);
            labelAvgFuel_KS.TabIndex = 0;
            labelAvgFuel_KS.Text = "Средний расход топлива:";
            // 
            // labelMaxLoad_KS
            // 
            labelMaxLoad_KS.AutoSize = true;
            labelMaxLoad_KS.Location = new Point(6, 136);
            labelMaxLoad_KS.Name = "labelMaxLoad_KS";
            labelMaxLoad_KS.Size = new Size(154, 15);
            labelMaxLoad_KS.TabIndex = 0;
            labelMaxLoad_KS.Text = "Максимум грузоподъема:";
            // 
            // labelMaxSpeed_KS
            // 
            labelMaxSpeed_KS.AutoSize = true;
            labelMaxSpeed_KS.Location = new Point(6, 60);
            labelMaxSpeed_KS.Name = "labelMaxSpeed_KS";
            labelMaxSpeed_KS.Size = new Size(145, 15);
            labelMaxSpeed_KS.TabIndex = 0;
            labelMaxSpeed_KS.Text = "Максимальная скорость:";
            // 
            // groupBoxDrivers_KS
            // 
            groupBoxDrivers_KS.Controls.Add(labelDriverCount_KS);
            groupBoxDrivers_KS.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDrivers_KS.Location = new Point(10, 9);
            groupBoxDrivers_KS.Margin = new Padding(3, 2, 3, 2);
            groupBoxDrivers_KS.Name = "groupBoxDrivers_KS";
            groupBoxDrivers_KS.Padding = new Padding(3, 2, 3, 2);
            groupBoxDrivers_KS.Size = new Size(179, 94);
            groupBoxDrivers_KS.TabIndex = 0;
            groupBoxDrivers_KS.TabStop = false;
            groupBoxDrivers_KS.Text = "Водители";
            // 
            // labelDriverCount_KS
            // 
            labelDriverCount_KS.AutoSize = true;
            labelDriverCount_KS.Location = new Point(5, 26);
            labelDriverCount_KS.Name = "labelDriverCount_KS";
            labelDriverCount_KS.Size = new Size(92, 19);
            labelDriverCount_KS.TabIndex = 0;
            labelDriverCount_KS.Text = "Количество:";
            // 
            // chartMarkToSpeed_KS
            // 
            chartMarkToSpeed_KS.BackColor = Color.LightSlateGray;
            chartMarkToSpeed_KS.BorderlineColor = SystemColors.GradientInactiveCaption;
            chartArea1.Name = "ChartArea1";
            chartMarkToSpeed_KS.ChartAreas.Add(chartArea1);
            chartMarkToSpeed_KS.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartMarkToSpeed_KS.Legends.Add(legend1);
            chartMarkToSpeed_KS.Location = new Point(0, 0);
            chartMarkToSpeed_KS.Margin = new Padding(3, 2, 3, 2);
            chartMarkToSpeed_KS.Name = "chartMarkToSpeed_KS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chartMarkToSpeed_KS.Series.Add(series1);
            chartMarkToSpeed_KS.Size = new Size(350, 338);
            chartMarkToSpeed_KS.TabIndex = 0;
            title1.Name = "Соотношение марок и колчиества";
            chartMarkToSpeed_KS.Titles.Add(title1);
            // 
            // labelRichDriver_KS
            // 
            labelRichDriver_KS.Location = new Point(0, 0);
            labelRichDriver_KS.Name = "labelRichDriver_KS";
            labelRichDriver_KS.Size = new Size(100, 23);
            labelRichDriver_KS.TabIndex = 0;
            labelRichDriver_KS.Text = "Водители";
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(935, 338);
            Controls.Add(splitContainer_KS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            Load += FormStatistics_Load;
            splitContainer_KS.Panel1.ResumeLayout(false);
            splitContainer_KS.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_KS).EndInit();
            splitContainer_KS.ResumeLayout(false);
            groupBoxGrid_KS.ResumeLayout(false);
            groupBoxGrid_KS.PerformLayout();
            groupBoxAuto_KS.ResumeLayout(false);
            groupBoxAuto_KS.PerformLayout();
            groupBoxAutoStats_KS.ResumeLayout(false);
            groupBoxAutoStats_KS.PerformLayout();
            groupBoxDrivers_KS.ResumeLayout(false);
            groupBoxDrivers_KS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartMarkToSpeed_KS).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer_KS;
        private Label labelRichDriver_KS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarkToSpeed_KS;
        private GroupBox groupBoxGrid_KS;
        private Label labelAquaRowCount_KS;
        private Label labelRedRowsCount_KS;
        private GroupBox groupBoxAuto_KS;
        private Label labelPopularMark_KS;
        private Label labelPopularLocation_KS;
        private Label labelAutoCondition_KS;
        private Label labelAutoCount_KS;
        private GroupBox groupBoxAutoStats_KS;
        private Label labelMaxFuel_KS;
        private Label labelMinLoad_KS;
        private Label labelAvgLoad_KS;
        private Label labelMinFuel_KS;
        private Label labelAvgSpeed_KS;
        private Label labelMinSpeed_KS;
        private Label labelAvgFuel_KS;
        private Label labelMaxLoad_KS;
        private Label labelMaxSpeed_KS;
        private GroupBox groupBoxDrivers_KS;
        private Label labelDriverCount_KS;
    }
}