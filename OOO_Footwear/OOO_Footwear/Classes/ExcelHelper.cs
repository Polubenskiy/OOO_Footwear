using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OOO_Footwear
{
    public class ExcelHelper
    {
        private static string _filePath;

        private static Excel.Application application;
        private static Workbooks workbooks;
        private static Workbook workbook;
        private static Sheets worksheets;
        private static Worksheet worksheet;
        private static Range cells;
        private static Window window;
        public static string FileName { get; internal set; }

        public static Excel.Application Application { get; set; }




        //public static void Hldse(Application application)
        //{
        //    ExcelHelper.application = application;            
        //}


        /// <summary>
        ///  Opens the Excel program
        /// </summary>
        static ExcelHelper()
        {
            application = new Excel.Application();
        }

        /// <summary>
        /// Открывает excel файл, по указанному пути
        /// </summary>
        /// <param name="_filePath"></param>
        //public static ExcelHelper(string _filePath)
        //{
        //    OpenExcel(_filePath);
        //}

        /// <summary>
        /// Открывает excel файл, по указанному пути
        /// </summary>
        /// <param name="_filePath"></param>
        /// <returns></returns>
        public static void OpenExcel(string _filePath)
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    application = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
                    workbook = application.Workbooks.Open(_filePath);
                }
                else
                {
                    //application = new Excel.Application(); // Если нет открытой программы, то создаём новое приложение
                    //workbook = application.Workbooks.Add();
                }
            }
            catch (Exception) { System.Windows.Forms.MessageBox.Show("File not exist!"); }
        }

        /// <summary>
        /// Создание новой книги  
        /// </summary>
        public static void CreateNewFile(string filePath)
        {
            application = new Excel.Application();
            workbook = application.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            workbook.SaveAs(filePath);
        }

        /// <summary>
        /// Создание нового листа
        /// </summary>
        public static void CreateNewSheet()
        {
            Worksheets tempsheet = workbook.Worksheets.Add(After: worksheet);
            worksheet = workbook.Worksheets[1];
        }

        public static string GetNameSheets()
        {
            int countSheet = workbook.Worksheets.Count;
            string sheetName = "";
            foreach (Excel.Worksheet item in workbook.Worksheets)
            {
                sheetName += item.Name + Environment.NewLine;
            }
            return sheetName;

        }

        /// <summary>
        /// Получение первого лист документа (счет начинается с 1)
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public static Worksheet SelectWorksheet(int sheet)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            return worksheet;
        }

        /// <summary>
        /// Получение первого лист документа (счет начинается с 1)
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public static Worksheet SelectWorksheet(string sheet)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            return worksheet;
        }

        /// <summary>
        /// Выбор нужного листа
        /// </summary>
        /// <param name="SheetNumber"></param>
        public static void GetWorksheet(int SheetNumber)
        {
            worksheet = workbook.Worksheets[SheetNumber];
        }

        /// <summary>
        /// Удаление нужного листва
        /// </summary>
        /// <param name="SheetNumber"></param>
        public static void DeleteWorksheet(int SheetNumber)
        {
            workbook.Worksheets[SheetNumber].Delete();
        }

        /// <summary>
        /// Переименовывает лист
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Worksheet RenameWorksheet(int sheet, string str)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);
            worksheet.Name = str;
            return worksheet;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ProtectSheet()
        {
            worksheet.Protect();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        public static void ProtectSheet(string Password)
        {
            worksheet.Protect(Password);
        }
        /// <summary>
        /// 
        /// </summary>
        public static void UnprotectSheet()
        {
            worksheet.Unprotect();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        public static void UnprotectSheet(int Password)
        {
            worksheet.Unprotect(Password);
        }

        /// <summary>
        /// Определяет последнюю заполненную строку
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        public static int LastRowCell(string sheet)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к листу
            cells = worksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell); //получаем доступ к ячейки
            int lastrow = cells.Row;
            return lastrow;
        }
        public static int LastRowCell(int sheet)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к листу
            cells = worksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell); //получаем доступ к ячейки
            int lastrow = cells.Row;
            return lastrow;
        }

        /// <summary>
        /// Читает данные из excel файла, на определенном листе в определенной ячейке
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static string ReadCell(int sheet, int row, int column)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            cells = worksheet.Cells[row, column];  //получаем доступ к нужной ячейке
            if (cells.Cells[row, column] != null && cells.Value != null)
            {
                string data = cells.Value.ToString();
                return data;
            }
            else
            {
                return " ";
            }
        }

        /// <summary>
        /// Читает данные из excel файла, на определенном листе в определенной ячейке
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static string ReadCell(string sheet, int row, int column)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            cells = worksheet.Cells[row, column];  //получаем доступ к нужной ячейке
            if (cells.Cells[row, column] != null && cells.Value != null)
            {
                string data = cells.Value.ToString();
                return data;
            }
            else
            {
                return " ";
            }
        }

        /// <summary>
        /// Читает диапазон данных из Excel файла, на определенном листе в определенной области (Пока не работает!)
        /// </summary>
        /// <param name="starti"></param>
        /// <param name="starty"></param>
        /// <param name="endi"></param>
        /// <param name="endy"></param>
        /// <returns></returns>
        public static string[,] ReadRange(int sheet, int starti, int starty, int endi, int endy)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            Range range = (Range)worksheet.Range[worksheet.Cells[starti, starty], worksheet.Cells[endi, endy]];
            object[,] holder = range.Value;
            string[,] data = new string[endi - starti, endy - starty];
            for (int p = 1; p <= endi - starti; p++)
            {
                for (int q = 1; q <= endy - starty; q++)
                {
                    data[p - 1, q - 1] = holder[p, q].ToString();
                }
            }
            return data;
        }

        /// <summary>
        /// Вводит данные в excel файла, на определенном листе в определенной ячейке
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="data"></param>
        public static void WriteCell(int sheet, int row, int column, object data)
        {
            try
            {
                //worksheet = worksheets.Item[1]; //получаем доступ к первому листу
                worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
                cells = worksheet.Cells[row, column];  //получаем доступ к нужной ячейке
                cells.Value = data; // заполняем ячейку
            }
            catch (Exception) { MessageBox.Show("it didn't work out!"); }
        }

        /// <summary>
        /// Вводит данные в excel файла, на определенном листе в определенной ячейке
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="data"></param>
        public static void WriteCell(string sheet, int row, int column, object data)
        {
            try
            {
                //worksheet = worksheets.Item[1]; //получаем доступ к первому листу
                worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
                cells = worksheet.Cells[row, column];  //получаем доступ к нужной ячейке
                cells.Value = data; // заполняем ячейку
            }
            catch (Exception) { MessageBox.Show("it didn't work out!"); }
        }

        /// <summary>
        /// Записывает диапазон данных в Excel файл, на определенном листе в определенной области
        /// </summary>
        /// <param name="starti"></param>
        /// <param name="starty"></param>
        /// <param name="endi"></param>
        /// <param name="endy"></param>
        /// <param name="data"></param>
        public static void WriteRange(int sheet, int starti, int starty, int endi, int endy, string[,] data)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            Range range = (Range)worksheet.Range[worksheet.Cells[starti, starty], worksheet.Cells[endi, endy]];
            range.Value = data;
        }

        /// <summary>
        /// Сохраняет файл
        /// </summary>
        public static void Save()
        {
            if (!string.IsNullOrEmpty(_filePath))
            {
                workbook.SaveAs(_filePath);
                _filePath = null;
            }
            else
            {
                return;
            }
        }

        [DllImport("user32.dll")]
        private static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);

        static Process GetExcelProcess(Excel.Application excelApp)
        {
            GetWindowThreadProcessId(excelApp.Hwnd, out int id);
            return Process.GetProcessById(id);
        }
        /// <summary>
        /// Закрывает Excel и освобождает память
        /// </summary>
        public static void Dispose()
        {
            try
            {

                application = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
                Process appProcess = GetExcelProcess(application);

                application.Quit();
                appProcess.Kill();
                Marshal.FinalReleaseComObject(application);
                GC.Collect();
            }
            catch (Exception) { MessageBox.Show("File not opened!"); }

        }
    }
}
