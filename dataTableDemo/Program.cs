using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace dataTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region create table and add data
            DataTable dataTable = new DataTable("myTable");
            DataColumn column;
            DataRow dataRow;
            DataSet dataSet;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;

            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ParentItem";
            column.AutoIncrement = false;
            column.Caption = "ParentItem";
            column.ReadOnly = false;
            column.Unique = false;
            dataTable.Columns.Add(column);

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = dataTable.Columns["id"];
            dataTable.PrimaryKey = PrimaryKeyColumns;

            dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            for (int i = 0; i <= 2; i++)
            {
                dataRow = dataTable.NewRow();
                dataRow["id"] = i;
                dataRow["ParentItem"] = "ParentItem " + i;
                dataTable.Rows.Add(dataRow);
            }
            #endregion

            #region read from table

            foreach (DataColumn col in dataTable.Columns)
            {
                Console.Write(col.ColumnName.ToString()+ " ");
            }

            Console.Write("\n");

            foreach (DataRow r in dataTable.Rows)
            {
                Console.WriteLine(r[0] + "-" + r[1]);
            }

            #endregion

            string path = @"test.txt";

            FileStream fs = File.Open(path, FileMode.OpenOrCreate);
            Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
            fs.Write(info,0,info.Length);
            fs.Close();

            StreamWriter sw = File.AppendText(path);
            sw.WriteLine("yoyoyo");
            sw.Close();

            Console.ReadKey();
        }
    }
}
