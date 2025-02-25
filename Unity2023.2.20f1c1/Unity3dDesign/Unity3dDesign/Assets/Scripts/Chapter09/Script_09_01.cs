using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Script_09_01
{
    [MenuItem("Excel/Load Excel")]
    static void LoadExcel()
    {
        string path = Application.dataPath + "/Resources/Chapter09/Chapter09_01.xlsx";

        // 检查文件是否存在
        if (!File.Exists(path))
        {
            Debug.LogError("Excel file not found at: " + path);
            return; // 退出方法
        }

        //读取Excel文件
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            using (ExcelPackage excel = new ExcelPackage(fs))
            {
                if (excel.Workbook == null || excel.Workbook.Worksheets.Count == 0)
                {
                    Debug.LogError("No worksheets found in the Excel file.");
                    return; // 退出方法
                }

                ExcelWorksheets workSheets = excel.Workbook.Worksheets;
                //遍历所有worksheets
                for (int i = 1; i <= workSheets.Count; i++)
                {
                    ExcelWorksheet workSheet = workSheets[i];
                    int colCount = workSheet.Dimension.End.Column;
                    //获取当前sheet名
                    Debug.LogFormat("Sheet {0}", workSheet.Name);
                    for (int row = 1, count = workSheet.Dimension.End.Row; row <= count; row++)
                    {
                        for (int col = 1; col <= colCount; col++)
                        {
                            //读取每个格子中的数据
                            var text = workSheet.Cells[row, col].Text ?? "";
                            Debug.LogFormat("下标:{0},{1} 内容:{2}", row, col, text);
                        }
                    }
                }
            }
        }
    }
}
