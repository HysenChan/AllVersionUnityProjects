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

        // ����ļ��Ƿ����
        if (!File.Exists(path))
        {
            Debug.LogError("Excel file not found at: " + path);
            return; // �˳�����
        }

        //��ȡExcel�ļ�
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            using (ExcelPackage excel = new ExcelPackage(fs))
            {
                if (excel.Workbook == null || excel.Workbook.Worksheets.Count == 0)
                {
                    Debug.LogError("No worksheets found in the Excel file.");
                    return; // �˳�����
                }

                ExcelWorksheets workSheets = excel.Workbook.Worksheets;
                //��������worksheets
                for (int i = 1; i <= workSheets.Count; i++)
                {
                    ExcelWorksheet workSheet = workSheets[i];
                    int colCount = workSheet.Dimension.End.Column;
                    //��ȡ��ǰsheet��
                    Debug.LogFormat("Sheet {0}", workSheet.Name);
                    for (int row = 1, count = workSheet.Dimension.End.Row; row <= count; row++)
                    {
                        for (int col = 1; col <= colCount; col++)
                        {
                            //��ȡÿ�������е�����
                            var text = workSheet.Cells[row, col].Text ?? "";
                            Debug.LogFormat("�±�:{0},{1} ����:{2}", row, col, text);
                        }
                    }
                }
            }
        }
    }
}
