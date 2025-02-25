using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;

public class Script_09_02
{
    [MenuItem("Excel/Write Excel")]
    static void LoadExcel()
    {
        //����Excel�ļ�
        string path = Application.dataPath + "/Resources/Chapter09/" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".xlsx";
        var file = new FileInfo(path);
        using (ExcelPackage excel = new ExcelPackage(file))
        {
            //������д������
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("sheet1");
            worksheet.Cells[1, 1].Value = "Company name1";
            worksheet.Cells[1, 2].Value = "Address1";

            worksheet = excel.Workbook.Worksheets.Add("sheet2");
            worksheet.Cells[1, 1].Value = "Company name2";
            worksheet.Cells[1, 2].Value = "Address2";

            //����
            excel.Save();
        }
        AssetDatabase.Refresh();
    }
}
