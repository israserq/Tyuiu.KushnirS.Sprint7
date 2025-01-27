using System.ComponentModel;
using Tyuiu.KushnirS.Sprint7.V8.Lib;

namespace Tyuiu.KushnirS.Sprint7.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogProject_KS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogInfo_KS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        //Общая функция поиска
        public void Search(DataGridView dataGrid, string searchValue, int searchableValue)
        {
            dataGrid.ClearSelection();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[searchableValue].Value.ToString().ToUpper() == searchValue)
                {
                    dataGrid.FirstDisplayedScrollingRowIndex = row.Index;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Selected = true;
                    }
                }
            }
        }
        //Общее сокрытие рядов
        public void InvisibleRowsByColors(DataGridView dataGrid, Color color, bool rowVisibility)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Style.BackColor == color)
                {
                    row.Visible = rowVisibility;
                }
            }
        }
        DataService ds = new DataService();
        public string? openFilePath;
        public bool fileOpened = false;
        AutoCompleteStringCollection driverNumComplete = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoNumComplete = new AutoCompleteStringCollection();

        //Содержит прошлые значения ячеек(до редактирования)
        public int cellInt = 0;
        public string? cellString = String.Empty;
        private void infoToolStripMenuItem_KS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void exitToolStripMenuItem_KS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statsToolStripMenuItem_KS_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics(dataGridViewChanged_KS);
            formStatistics.ShowDialog();
        }

        private void guideToolStripMenuItem_KS_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        //Загрузка файла в таблицы, активация кнопок
        private void buttonLoad_KS_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialogProject_KS.ShowDialog();
                openFilePath = openFileDialogProject_KS.FileName;
                List<string[]> gridInfo = ds.LoadDataFromFile(openFilePath);
                this.dataGridViewAuto_KS.Rows.Clear();
                this.dataGridViewAuto_KS.RowCount = gridInfo.Count;
                this.dataGridViewChanged_KS.Rows.Clear();
                this.dataGridViewChanged_KS.RowCount = gridInfo.Count;
                this.dataGridViewAuto_KS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridViewChanged_KS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for (int i = 0; i < gridInfo.Count; i++)
                {
                    for (int j = 0; j < gridInfo[0].Length; j++)
                    {
                        if (j == 0 || j > 4)
                        {
                            this.dataGridViewAuto_KS.Rows[i].Cells[j].Value = Convert.ToInt32(gridInfo[i][j]);
                            this.dataGridViewChanged_KS.Rows[i].Cells[j].Value = Convert.ToInt32(gridInfo[i][j]);
                            //Для забивания типов данных столбцов(Понадобится больше)
                            this.dataGridViewAuto_KS.Columns[j].ValueType = typeof(int);
                            this.dataGridViewChanged_KS.Columns[j].ValueType = typeof(int);

                        }
                        else
                        {
                            this.dataGridViewAuto_KS.Rows[i].Cells[j].Value = gridInfo[i][j].ToString().ToUpper();
                            this.dataGridViewChanged_KS.Rows[i].Cells[j].Value = gridInfo[i][j].ToString().ToUpper();
                            this.dataGridViewAuto_KS.Columns[j].ValueType = typeof(string);
                            this.dataGridViewChanged_KS.Columns[j].ValueType = typeof(string);
                        }
                    }
                }

                for (int i = 0; i < dataGridViewAuto_KS.RowCount; i++)
                {
                    driverNumComplete.Add(this.dataGridViewAuto_KS.Rows[i].Cells[0].Value.ToString());
                    autoNumComplete.Add(this.dataGridViewAuto_KS.Rows[i].Cells[1].Value.ToString());
                }
                this.textBoxSearchDriverNum_KS.AutoCompleteCustomSource = driverNumComplete;
                this.textBoxSearchDriverNum_KS.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.textBoxSearchDriverNum_KS.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.textBoxAutoNumSearch_KS.AutoCompleteCustomSource = autoNumComplete;
                this.textBoxAutoNumSearch_KS.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.textBoxAutoNumSearch_KS.AutoCompleteSource = AutoCompleteSource.CustomSource;
                fileOpened = true;
                this.buttonSave_KS.Enabled = true;
                this.statsToolStripMenuItem_KS.Enabled = true;
                this.tabControlSearch_KS.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        //Поиск в зависимости от выбранной таблицы
        private void buttonSearchDriverNum_KS_Click(object sender, EventArgs e)
        {
            //if (this.dataGridViewChanged_KS.Rows[0].Cells[1].ValueType == typeof(string))
            //{
            //    MessageBox.Show("Это ???");
            //}
            this.textBoxAutoNumSearch_KS.AutoCompleteMode = AutoCompleteMode.Suggest;
            string searchValue = this.textBoxSearchDriverNum_KS.Text;
            try
            {
                switch (this.tabControlData_KS
                    .SelectedIndex)
                {
                    case 0:
                        Search(this.dataGridViewAuto_KS, searchValue, 0);
                        break;
                    case 1:
                        Search(this.dataGridViewChanged_KS, searchValue, 0);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Данный ряд скрыт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchAutoNum_KS_Click(object sender, EventArgs e)
        {
            string searchValue = this.textBoxAutoNumSearch_KS.Text;
            try
            {
                switch (this.tabControlData_KS
                    .SelectedIndex)
                {
                    case 0:
                        Search(this.dataGridViewAuto_KS, searchValue, 1);
                        break;
                    case 1:
                        Search(this.dataGridViewChanged_KS, searchValue, 1);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Данный ряд скрыт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_KS_Click(object sender, EventArgs e)
        {
            //Сохранение файла(без помеченных строк)
            this.saveFileDialogInfo_KS.FileName = "OutPutAuto.csv";
            this.saveFileDialogInfo_KS.InitialDirectory = @"C:\DataSprint7";
            this.saveFileDialogInfo_KS.Filter = "CSV Files (*.csv)|*.csv";
            this.saveFileDialogInfo_KS.Title = "Save CSV File";

            // Отображение диалогового окна и проверка, выбрал ли пользователь файл
            if (this.saveFileDialogInfo_KS.ShowDialog() == DialogResult.OK)
            {
                // Получение пути к выбранному файлу
                string path = this.saveFileDialogInfo_KS.FileName;

                // Удаление файла, если он существует
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                // Получение данных из DataGridView
                int rowCount = this.dataGridViewChanged_KS.RowCount;
                int columnCount = this.dataGridViewChanged_KS.ColumnCount;
                string str = "";

                // Создание строки CSV
                for (int i = 0; i < rowCount - 1; i++) // -1, чтобы исключить пустую строку в конце
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        str += this.dataGridViewChanged_KS.Rows[i].Cells[j].Value.ToString();
                        if (j < columnCount - 1)
                        {
                            str += ",";
                        }
                    }
                    str += "\n";
                }

                // Сохранение данных в файл
                File.WriteAllText(path, str);

                MessageBox.Show("Файл сохранен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Задание максимальной длины элементов в столбцах
            ((DataGridViewTextBoxColumn)dataGridViewChanged_KS.Columns[1]).MaxInputLength = 6;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_KS.Columns[2]).MaxInputLength = 20;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_KS.Columns[3]).MaxInputLength = 30;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_KS.Columns[4]).MaxInputLength = 30;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_KS.Columns[5]).MaxInputLength = 5;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_KS.Columns[6]).MaxInputLength = 5;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_KS.Columns[7]).MaxInputLength = 5;



            this.BeginInvoke(new Action(() =>
            {
                buttonLoad_KS.Focus();
            }));
        }
        //Проверяет значение с тем, что было раньше и не отмечает ячейку если они сходятся
        //Также проверяет, чтобы ячейки не были пустыми
        private void dataGridViewChanged_KS_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool isInt = cellInt != 0;
            bool isString = !isInt;
            try
            {
                if (!String.IsNullOrEmpty(this.dataGridViewChanged_KS.CurrentCell.Value.ToString()) && !Convert.IsDBNull(this.dataGridViewChanged_KS.CurrentCell.Value) && this.dataGridViewChanged_KS.CurrentCell.Style.BackColor != Color.Aqua)
                {
                    if ((isInt && Convert.ToInt32(this.dataGridViewChanged_KS.CurrentCell.Value) != cellInt) || (isString && this.dataGridViewChanged_KS.CurrentCell.Value.ToString() != cellString))
                    {
                        this.dataGridViewChanged_KS.CurrentCell.Style.BackColor = Color.Green;
                        if (e.ColumnIndex == 0)
                        {
                            driverNumComplete.Remove(cellInt.ToString());
                            driverNumComplete.Add(this.dataGridViewChanged_KS.CurrentCell.Value.ToString());
                        }
                        if (e.ColumnIndex == 1)
                        {
                            autoNumComplete.Remove(cellString);
                            autoNumComplete.Add(this.dataGridViewChanged_KS.CurrentCell.Value.ToString());
                        }
                    }
                }

            }
            catch (NullReferenceException)
            {
                this.dataGridViewChanged_KS.CurrentCell.Value = cellString;
                cellString = string.Empty;
            }
            finally
            {
                if (Convert.IsDBNull(this.dataGridViewChanged_KS.CurrentCell.Value))
                {
                    if (cellInt != 0)
                    {
                        this.dataGridViewChanged_KS.CurrentCell.Value = cellInt;
                        cellInt = 0;
                    }
                }
            }

        }



        private void NumInput(object? sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void StringInput(object? sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '-' || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        //Ограничение на ввод некоторых символов в зависимости от типа ячейки
        private void dataGridViewChanged_KS_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            bool isCellString = (this.dataGridViewChanged_KS.CurrentCell.ValueType == typeof(string));
            bool isAutoNum = (this.dataGridViewChanged_KS.CurrentCell.ColumnIndex == 1);
            if (e.Control is DataGridViewTextBoxEditingControl textBoxEditingControl)
            {
                textBoxEditingControl.KeyPress -= NumInput;
                textBoxEditingControl.KeyPress -= StringInput;
                if (isCellString && !isAutoNum)
                {
                    textBoxEditingControl.KeyPress += StringInput;
                }
                else if (!isCellString && !isAutoNum)
                {
                    textBoxEditingControl.KeyPress += NumInput;
                }

            }
        }
        //Выключение кнопок при переходе на первую таблмцу
        private void tabControlData_KS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlData_KS.SelectedIndex == 1 && fileOpened)
            {
                this.buttonAdd_KS.Enabled = true;
                this.buttonRemove_KS.Enabled = true;

            }
            else
            {
                this.buttonAdd_KS.Enabled = false;
                this.buttonRemove_KS.Enabled = false;
                this.buttonMarkDelete_KS.Enabled = false;
                this.buttonMarkDelete_KS.Visible = false;
                this.buttonUnMarkDelete_KS.Enabled = false;
                this.buttonUnMarkDelete_KS.Visible = false;
                this.buttonTrueDelete_KS.Enabled = false;
                this.buttonTrueDelete_KS.Visible = false;
                this.dataGridViewChanged_KS.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }
        #region ToolTipChange
        private void buttonTrueDelete_KS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KS.ToolTipTitle = "Удалить";
            toolTipInfo_KS.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonAdd_KS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KS.ToolTipTitle = "Добавить";
            toolTipInfo_KS.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonSave_KS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KS.ToolTipTitle = "Сохранить";
            toolTipInfo_KS.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonLoad_KS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KS.ToolTipTitle = "Загрузить";
            toolTipInfo_KS.ToolTipIcon = ToolTipIcon.Info;

        }
        private void buttonRemove_KS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KS.ToolTipTitle = "Удалить";
            toolTipInfo_KS.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonSearchDriverNum_KS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KS.ToolTipTitle = "Поиск";
            toolTipInfo_KS.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonSearchAutoNum_KS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KS.ToolTipTitle = "Поиск";
            toolTipInfo_KS.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonMarkDelete_KS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KS.ToolTipTitle = "Удалить";
            toolTipInfo_KS.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonUnMarkDelete_KS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KS.ToolTipTitle = "Убрать из удаленных";
            toolTipInfo_KS.ToolTipIcon = ToolTipIcon.Info;
        }
        #endregion


        private void buttonRemove_KS_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewChanged_KS.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
            {
                this.dataGridViewChanged_KS.SelectionMode = DataGridViewSelectionMode.CellSelect;
                this.buttonMarkDelete_KS.Enabled = false;
                this.buttonMarkDelete_KS.Visible = false;
                this.buttonUnMarkDelete_KS.Enabled = false;
                this.buttonUnMarkDelete_KS.Visible = false;
                this.buttonTrueDelete_KS.Enabled = false;
                this.buttonTrueDelete_KS.Visible = false;
            }
            else
            {
                this.dataGridViewChanged_KS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                this.buttonMarkDelete_KS.Enabled = true;
                this.buttonMarkDelete_KS.Visible = true;
                this.buttonUnMarkDelete_KS.Enabled = true;
                this.buttonUnMarkDelete_KS.Visible = true;
                this.buttonTrueDelete_KS.Enabled = true;
                this.buttonTrueDelete_KS.Visible = true;
            }


        }
        //Покраска выделенных ячеек на удаление
        private void buttonMarkDelete_KS_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewChanged_KS.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.OrangeRed;
                }
            }
        }
        //Убирание покраски удаления
        private void buttonUnMarkDelete_KS_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewChanged_KS.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Style.BackColor == Color.OrangeRed)
                    {
                        cell.Style.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                    }
                }
            }
        }
        //Сохраняет предыдущие значения
        private void dataGridViewChanged_KS_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellInt = this.dataGridViewChanged_KS.CurrentCell.ValueType == typeof(int) ? Convert.ToInt32(this.dataGridViewChanged_KS.CurrentCell.Value) : 0;
            cellString = this.dataGridViewChanged_KS.CurrentCell.ValueType == typeof(string) ? this.dataGridViewChanged_KS.CurrentCell.Value.ToString() : String.Empty;
        }
        //Покраска новых строк
        private void buttonAdd_KS_Click(object sender, EventArgs e)
        {
            this.dataGridViewChanged_KS.Rows.Add(0, "######", "НЕИЗВЕСТНО", "НЕИЗВЕСТНО", "НЕИЗВЕСТНО", 0, 0, 0);
            foreach (DataGridViewCell cell in this.dataGridViewChanged_KS.Rows[^1].Cells)
            {
                cell.Style.BackColor = Color.Aqua;
            }
        }
        //Фильтры
        private void redRowsToolStripMenuItem_KS_Click(object sender, EventArgs e)
        {

            if (!this.redRowsToolStripMenuItem_KS.Checked)
            {
                this.redRowsToolStripMenuItem_KS.Checked = true;
                InvisibleRowsByColors(this.dataGridViewChanged_KS, Color.OrangeRed, true);
            }
            else
            {
                this.redRowsToolStripMenuItem_KS.Checked = false;
                InvisibleRowsByColors(this.dataGridViewChanged_KS, Color.OrangeRed, false);
            }
        }

        private void aquaRowsToolStripMenuItem_KS_Click(object sender, EventArgs e)
        {
            if (!this.aquaRowsToolStripMenuItem_KS.Checked)
            {
                this.aquaRowsToolStripMenuItem_KS.Checked = true;
                InvisibleRowsByColors(this.dataGridViewChanged_KS, Color.Aqua, true);
            }
            else
            {
                this.aquaRowsToolStripMenuItem_KS.Checked = false;
                InvisibleRowsByColors(this.dataGridViewChanged_KS, Color.Aqua, false);
            }
        }

        private void filterToolStripMenuItem_KS_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewChanged_KS.Rows)
            {
                if (row.Cells[0].Style.BackColor == Color.OrangeRed)
                {
                    this.redRowsToolStripMenuItem_KS.Enabled = true;
                }
                if (row.Cells[0].Style.BackColor == Color.Aqua)
                {
                    this.aquaRowsToolStripMenuItem_KS.Enabled = true;
                }
            }
        }
        //Окончательное удаление строк(и)
        private void buttonTrueDelete_KS_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить данный ряд?", "Да", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewChanged_KS.SelectedRows)
                {
                    this.dataGridViewChanged_KS.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void dataGridViewAuto_KS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxData_KS_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainerTask_KS_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialogProject_KS_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dataGridViewChanged_KS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}