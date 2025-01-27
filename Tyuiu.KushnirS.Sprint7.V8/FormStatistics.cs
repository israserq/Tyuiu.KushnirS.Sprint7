namespace Tyuiu.KushnirS.Sprint7.V8
{
    public partial class FormStatistics : Form
    {
        private static DataGridView mainFormDataGrid;
        public FormStatistics(DataGridView dataGrid)
        {
            mainFormDataGrid = dataGrid;
            InitializeComponent();
        }
        //Считывание ячеек с таблицы
        private static int[] GetIntCellsFromColumn(int column)
        {
            int[] columnArray = new int[mainFormDataGrid.RowCount];
            for (int i = 0; i < columnArray.Length; i++)
            {
                columnArray[i] = Convert.ToInt32(mainFormDataGrid.Rows[i].Cells[column].Value);
            }
            return columnArray;
        }

        private static string[] GetStringCellsFromColumn(int column)
        {
            string[] columnArray = new string[mainFormDataGrid.RowCount];
            for (int i = 0; i < columnArray.Length; i++)
            {
                columnArray[i] = Convert.ToString(mainFormDataGrid.Rows[i].Cells[column].Value);
            }
            return columnArray;
        }
        //Нахождение самых повторяющихся элементов
        private static string GetMostRepeatedString(int column)
        {
            var query = GetStringCellsFromColumn(column).GroupBy(x => x)
                                                             .Where(item => item.Count() > 1)
                                                             .Select(item => new { Number = item.Count(), Name = item.Key })
                                                             .ToArray();
            if (query.Length == 0) return "-";
            string repetition = "Error";
            foreach (var item in query)
            {
                if (item.Number == query.Max(x => x.Number))
                {
                    repetition = item.Name;
                }
            }
            return repetition;
        }
        private static int RowsCount(Color color)
        {
            int count = 0;
            for (int i = 0; i < mainFormDataGrid.RowCount; i++)
            {
                if (mainFormDataGrid.Rows[i].Cells[0].Style.BackColor == color) count++;
            }
            return count;
        }

        public static double GetAverageStatFromColumn(int column) => Math.Round(GetIntCellsFromColumn(column).Average(), 3);
        public static int GetMaxStatFromColumn(int column) => GetIntCellsFromColumn(column).Max();
        public static int GetMinStatFromColumn(int column) => GetIntCellsFromColumn(column).Min();
        public static int GetCountStatFromColumn(int column) => GetIntCellsFromColumn(column).Count();
        private void FormStatistics_Load(object sender, EventArgs e)
        {
            labelDriverCount_KS.Text += " " + GetIntCellsFromColumn(0).Distinct().Count().ToString();
            labelMaxSpeed_KS.Text += " " + GetMaxStatFromColumn(5).ToString();
            labelMinSpeed_KS.Text += " " + GetMinStatFromColumn(5).ToString();
            labelAvgSpeed_KS.Text += " " + GetAverageStatFromColumn(5).ToString();
            labelMaxLoad_KS.Text += " " + GetMaxStatFromColumn(6).ToString();
            labelMinLoad_KS.Text += " " + GetMinStatFromColumn(6).ToString();
            labelAvgLoad_KS.Text += " " + GetAverageStatFromColumn(6).ToString();
            labelMaxFuel_KS.Text += " " + GetMaxStatFromColumn(7).ToString();
            labelMinFuel_KS.Text += " " + GetMinStatFromColumn(7).ToString();
            labelAvgFuel_KS.Text += " " + GetAverageStatFromColumn(7).ToString();
            labelAutoCount_KS.Text += " " + GetCountStatFromColumn(0).ToString();
            labelPopularMark_KS.Text += " " + GetMostRepeatedString(2);
            labelPopularLocation_KS.Text += " " + GetMostRepeatedString(4);
            labelAutoCondition_KS.Text += " " + GetMostRepeatedString(3);
            labelRichDriver_KS.Text += " " + "№" + GetMostRepeatedString(0);
            labelAquaRowCount_KS.Text += " " + RowsCount(Color.Aqua).ToString();
            labelRedRowsCount_KS.Text += " " + RowsCount(Color.OrangeRed).ToString();
            this.chartMarkToSpeed_KS.ChartAreas[0].AxisX.Title = "Скорость";
            this.chartMarkToSpeed_KS.ChartAreas[0].AxisY.Title = "Расход топлива";
            this.chartMarkToSpeed_KS.Series[0].Points.Clear();
            Array.Sort(GetIntCellsFromColumn(5));
            Array.Sort(GetIntCellsFromColumn(7));
            for (int i = 0; i < mainFormDataGrid.Rows.Count; i++)
            {
                this.chartMarkToSpeed_KS.Series[0].Points.AddXY(GetIntCellsFromColumn(5)[i], GetIntCellsFromColumn(7)[i]);
            }
        }

        private void chartMarkToSpeed_KS_Click(object sender, EventArgs e)
        {

        }
    }
}
