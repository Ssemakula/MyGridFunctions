using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GridRoutines
{
    public class GridGetItem
    {
        public static object GetCellValue(DataGridView _dataGridView, string _columnName, int _rowIndex)
        {
            object cellValue = _dataGridView.Rows[_rowIndex].Cells[_columnName].Value;
            return cellValue;
        }
        public static int GetIntRef(DataGridView _dataGridView, int _columnIndex) //Get integer value using column index
        {
            int rowIndex = 0; //int columnIndex = 0;
            int countMess = _dataGridView.RowCount; //Check whether there are any records in grid
            if (countMess < 1)  //if none return 0 (alsways check if GetInRef() returns 0)
            {
                return 0;
            }
            DataGridViewRow row = _dataGridView.Rows[rowIndex];
            DataGridViewCell cell = row.Cells[_columnIndex];
            object cellValue = cell.Value;
            if (_dataGridView.SelectedRows.Count > 0) //have to select a full row...
            {
                DataGridViewRow selectedRow = _dataGridView.SelectedRows[0];
                object rowValue = selectedRow.Cells[_columnIndex].Value;
                cellValue = (int)rowValue;
            }
            else if (_dataGridView.SelectedCells.Count > 0) //Selected a cell
            {
                cell = _dataGridView.SelectedCells[0];
                row = _dataGridView.Rows[cell.RowIndex];
                cellValue = row.Cells[_columnIndex].Value;
            }
            else
            {
                cellValue = 0;
            }
            if (cellValue != null)
            {
                return (int)cellValue;
            }
            else
                return 0;

        }

        public static int GetIntRef(DataGridView _dataGridView, string _columnIndex) //Get integer value using column name
        {
            int rowIndex = 0; //int columnIndex = 0;
            int countMess = _dataGridView.RowCount; //Check whether there are any records in grid
            if (countMess < 1)  //if none return 0 (alsways check if GetInRef() returns 0)
            {
                return 0;
            }
            DataGridViewRow row = _dataGridView.Rows[rowIndex];
            DataGridViewCell cell = row.Cells[_columnIndex];
            object cellValue = cell.Value;
            if (_dataGridView.SelectedRows.Count > 0) //have to select a full row...
            {
                int selectedRow = _dataGridView.SelectedRows[0].Index; //Get the index of the first selected row
                object rowValue = GetCellValue(_dataGridView, _columnIndex, selectedRow);
                cellValue = (int)rowValue;
            }
            else if (_dataGridView.SelectedCells.Count > 0) //Selected a cell
            {
                int selectedRow = _dataGridView.SelectedCells[0].RowIndex; //Get the row index of the first selected cell
                object rowValue = GetCellValue(_dataGridView, _columnIndex, selectedRow);
                cellValue = (int)rowValue;
            }
            else
            {
                cellValue = 0;
            }
            if (cellValue != null)
            {
                return (int)cellValue;
            }
            else
                return 0;

        }

        public static string GetStringRef(DataGridView _dataGridView, int _columnIndex) //Get string value using column index
        {
            int rowIndex = 0; //int columnIndex = 4; //rowIndex = get row, columnIndex = target colum (change as necessary)
            int countMess = _dataGridView.RowCount; //Check whether there are any records in grid
            if (countMess < 1)  //if none return empty (alsways check if GetJobNo() return empty before proceed
            {
                return "";
            }
            DataGridViewRow row = _dataGridView.Rows[rowIndex];
            DataGridViewCell cell; // = row.Cells[columnIndex]; //Get current cell
            object cellValue; // = cell.Value;

            if (_dataGridView.SelectedRows.Count > 0) //If row is selected
            {
                DataGridViewRow selectedRow = _dataGridView.SelectedRows[0]; //Select first of selected rows
                object rowValue = selectedRow.Cells[_columnIndex].Value;
                cellValue = rowValue.ToString();
            }
            else if (_dataGridView.SelectedCells.Count > 0) //If cell i selected
            {
                cell = _dataGridView.SelectedCells[0]; //select first of selected cells
                row = _dataGridView.Rows[cell.RowIndex];
                cellValue = row.Cells[_columnIndex].Value; //Get required item
            }
            else //Nothing selected
            {
                cellValue = "";
            }
            if (cellValue != null)
            {
                return cellValue.ToString();
            }
            else
                return "";

        }

        public static string GetStringRef(DataGridView _dataGridView, string _columnIndex) //Get string value using column name
        {
            int rowIndex = 0; //int columnIndex = 4; //rowIndex = get row, columnIndex = target colum (change as necessary)
            int countMess = _dataGridView.RowCount; //Check whether there are any records in grid
            if (countMess < 1)  //if none return empty (alsways check if GetJobNo() return empty before proceed
            {
                return "";
            }
            DataGridViewRow row = _dataGridView.Rows[rowIndex];
            // DataGridViewCell cell; // = row.Cells[columnIndex]; //Get current cell
            object cellValue; // = cell.Value;

            if (_dataGridView.SelectedRows.Count > 0) //If row is selected
            {
                int selectedRow = _dataGridView.SelectedRows[0].Index; //Get the index of the first selected row
                object rowValue = GetCellValue(_dataGridView, _columnIndex, selectedRow);
                cellValue = rowValue;
            }
            else if (_dataGridView.SelectedCells.Count > 0) //Selected a cell
            {
                int selectedRow = _dataGridView.SelectedCells[0].RowIndex; //Get the row index of the first selected cell
                object rowValue = GetCellValue(_dataGridView, _columnIndex, selectedRow);
                cellValue = rowValue;
            }
            else //Nothing selected
            {
                cellValue = "";
            }
            if (cellValue != null)
            {
                return cellValue.ToString();
            }
            else
                return "";

        }

        public static double GetDoubleRef(DataGridView _dataGridView, int _columnIndex) //Get double value using column index
        {
            int rowIndex = 0; //int columnIndex = 0;
            int countMess = _dataGridView.RowCount; //Check whether there are any records in grid
            if (countMess < 1)  //if none return 0 (alsways check if GetInRef() returns 0)
            {
                return 0D;
            }
            DataGridViewRow row = _dataGridView.Rows[rowIndex];
            DataGridViewCell cell = row.Cells[_columnIndex];
            object cellValue = cell.Value;
            if (_dataGridView.SelectedRows.Count > 0) //have to select a full row...
            {
                DataGridViewRow selectedRow = _dataGridView.SelectedRows[0];
                object rowValue = selectedRow.Cells[_columnIndex].Value;
                cellValue = (double)rowValue;
            }
            else if (_dataGridView.SelectedCells.Count > 0)
            {
                cell = _dataGridView.SelectedCells[0];
                row = _dataGridView.Rows[cell.RowIndex];
                cellValue = row.Cells[_columnIndex].Value;
            }
            else
            {
                cellValue = 0D;
            }
            if (cellValue != null)
            {
                return (double)cellValue;
            }
            else
                return 0D;
        }

        public static double GetDoubleRef(DataGridView _dataGridView, string _columnIndex) //Get double value using colum name
        {
            int rowIndex = 0; //int columnIndex = 0;
            int countMess = _dataGridView.RowCount; //Check whether there are any records in grid
            if (countMess < 1)  //if none return 0 (alsways check if GetInRef() returns 0)
            {
                return 0D;
            }
            DataGridViewRow row = _dataGridView.Rows[rowIndex];
            DataGridViewCell cell = row.Cells[_columnIndex];
            object cellValue = cell.Value;
            if (_dataGridView.SelectedRows.Count > 0) //have to select a full row...
            {
                int selectedRow = _dataGridView.SelectedRows[0].Index; //Get the index of the first selected row
                object rowValue = GetCellValue(_dataGridView, _columnIndex, selectedRow);
                cellValue = (double)rowValue;
            }
            else if (_dataGridView.SelectedCells.Count > 0) //Selected a cell
            {
                int selectedRow = _dataGridView.SelectedCells[0].RowIndex; //Get the row index of the first selected cell
                object rowValue = GetCellValue(_dataGridView, _columnIndex, selectedRow);
                cellValue = (double)rowValue;
            }
            else
            {
                cellValue = 0D;
            }
            if (cellValue != null)
            {
                return (double)cellValue;
            }
            else
                return 0D;
        }
    }
}
