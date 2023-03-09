using PUNTOVENTA.Conexion;
using PUNTOVENTA.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;

using Excel = ClosedXML.Excel;


namespace PUNTOVENTA.CLASES
{
    public class c_excel
    {


        public static string ReporteCompras(string ruta,string fechainicio,string fechafinal,List<List<string>> listadelistas)
        {


            //Ruta del fichero Excel
            int contadorregistros = 7;

            var wb = new Excel.XLWorkbook();

            //create 'worksheet' object
            var ws = wb.Worksheets.Add("R_Compras"+fechainicio+"_"+fechafinal);

            //read cells
            var a = ws.Cell("A1").Value;
            var b = ws.Cell("B1").Value;

           

            //write cells
            ws.Cell("A1").Value = "FILTROS";
            ws.Cell("G4").Value = "REPORTE COMPRAS ENTRADA";
            ws.Cell("A2").Value = "FECHA INICIO:";
            ws.Cell("B2").Value = fechainicio;
            ws.Cell("A3").Value = "FECHA FINAL:";
            ws.Cell("B3").Value = fechafinal;
            ws.Range("A5:G5").Value = "----------------------------------------";


            ws.Cell("A6").Value = "No.Entrada";
            ws.Cell("B6").Value = "No.Producto";

            ws.Cell("C6").Value = "Nombre Producto";

            ws.Cell("D6").Value = "Categoria";

            ws.Cell("E6").Value = "Cantidad";

            ws.Cell("F6").Value = "Fecha Entrada";

            ws.Cell("G6").Value = "Usuario";


            int contadorcolumnas = 1;
            foreach ( var item in listadelistas)
            {
               
                foreach (var list in item)
                {
                    MessageBox.Show(list.ToString());
                    ws.Cell(contadorcolumnas, contadorregistros).Value=list;

                    contadorcolumnas = contadorcolumnas + 1;
                   
                }
                contadorregistros = contadorregistros + 1;
            }
            


            wb.SaveAs(ruta);

            return "";

        }
       
    }
}
