﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SBX.MODEL
{
    public class CrearTicket
    {
        
        //Creamos un objeto de la clase StringBuilder, en este objeto agregaremos las lineas del ticket
        StringBuilder linea = new StringBuilder();
        //Creamos una variable para almacenar el numero maximo de caracteres que permitiremos en el ticket.
        // int maxCar = 32, cortar;//Para una impresora ticketera que imprime a 40 columnas. La variable cortar cortara el texto cuando rebase el limte.
       
        
        int maxCar = 42, cortar;
        //Creamos el primer metodo, este dibujara lineas guion.
        public string lineasGuio()
        {
            string lineasGuion = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasGuion += "-";//Agregara un guio hasta llegar la numero maximo de caracteres.
            }
            return linea.AppendLine(lineasGuion).ToString(); //Devolvemos la lineaGuion
        }
        private void datosTamanoPapelEmpresa() 
        {
            DataTable DTEmpresa = new DataTable();
            DataRow row;
            cls_empresa Empres = new cls_empresa();
           
            DTEmpresa = Empres.mtd_consultar_Empresa();
            row = DTEmpresa.Rows[0];
            string TmPapel = row["tamano_papel"].ToString();
            if (TmPapel == "80")
            {
                maxCar = 42;
            }
            else
            {
                maxCar = 32;
            }
        }

        //Metodo para dibujar una linea con asteriscos
        public string lineasAsteriscos()
        {
            string lineasAsterisco = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasAsterisco += "*";//Agregara un asterisco hasta llegar la numero maximo de caracteres.
            }
            return linea.AppendLine(lineasAsterisco).ToString(); //Devolvemos la linea con asteriscos
        }

        //Realizamos el mismo procedimiento para dibujar una lineas con el signo igual
        public string lineasIgual()
        {
            datosTamanoPapelEmpresa();
            string lineasIgual = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasIgual += "=";//Agregara un igual hasta llegar la numero maximo de caracteres.
            }
            return linea.AppendLine(lineasIgual).ToString(); //Devolvemos la lienas con iguales
        }

        //Creamos el encabezado para los articulos
        public void EncabezadoVenta()
        {
            //Escribimos los espacios para mostrar el articulo. En total tienen que ser 40 caracteres
            linea.AppendLine("Item    Descripcion   UM   Total");
        }

        //Creamos un metodo para poner el texto a la izquierda
        public void TextoIzquierda(string texto)
        {
            datosTamanoPapelEmpresa();
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //agregamos el fragmento restante
                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                //Si no es mayor solo agregarlo.
                linea.AppendLine(texto);
            }
        }

        //Creamos un metodo para poner texto a la derecha.
        public void TextoDerecha(string texto)
        {
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restntes
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += " ";//Agrega espacios para alinear a la derecha
                }

                //agregamos el fragmento restante, agregamos antes del texto los espacios
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " ";//Agrega espacios para alinear a la derecha
                }
                //Si no es mayor solo agregarlo.
                linea.AppendLine(espacios + texto);
            }
        }

        //Metodo para centrar el texto
        public void TextoCentro(string texto)
        {
            datosTamanoPapelEmpresa();
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restntes
                string espacios = "";
                //sacamos la cantidad de espacios libres y el resultado lo dividimos entre dos
                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";//Agrega espacios para centrar
                }

                //agregamos el fragmento restante, agregamos antes del texto los espacios
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                //sacamos la cantidad de espacios libres y el resultado lo dividimos entre dos
                int centrar = (maxCar - texto.Length) / 2;
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";//Agrega espacios para centrar
                }

                //agregamos el fragmento restante, agregamos antes del texto los espacios
                linea.AppendLine(espacios + texto);

            }
        }

        //Metodo para poner texto a los extremos
        public void TextoExtremos(string textoIzquierdo, string textoDerecho)
        {
            //variables que utilizaremos
            string textoIzq, textoDer, textoCompleto = "", espacios = "";

            //Si el texto que va a la izquierda es mayor a 18, cortamos el texto.
            if (textoIzquierdo.Length > 18)
            {
                cortar = textoIzquierdo.Length - 18;
                textoIzq = textoIzquierdo.Remove(18, cortar);
            }
            else
            { textoIzq = textoIzquierdo; }

            textoCompleto = textoIzq;//Agregamos el primer texto.

            if (textoDerecho.Length > 20)//Si es mayor a 20 lo cortamos
            {
                cortar = textoDerecho.Length - 20;
                textoDer = textoDerecho.Remove(20, cortar);
            }
            else
            { textoDer = textoDerecho; }

            //Obtenemos el numero de espacios restantes para poner textoDerecho al final
            int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";//agrega los espacios para poner textoDerecho al final
            }
            textoCompleto += espacios + textoDerecho;//Agregamos el segundo texto con los espacios para alinearlo a la derecha.
            linea.AppendLine(textoCompleto);//agregamos la linea al ticket, al objeto en si.
        }

        //Metodo para agregar los totales d ela venta
        public void AgregarTotales(string texto, double total)
        {
            datosTamanoPapelEmpresa();
            //Variables que usaremos
            string resumen, valor, textoCompleto, espacios = "";

            if (texto.Length > 25)//Si es mayor a 25 lo cortamos
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25, cortar);
            }
            else
            { resumen = texto; }

            textoCompleto = resumen;
            valor = total.ToString("N");//.ToString("#,#.00");//Agregamos el total previo formateo.

            //Obtenemos el numero de espacios restantes para alinearlos a la derecha
            int nroEspacios = maxCar - (resumen.Length + valor.Length);
            //agregamos los espacios
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";
            }
            textoCompleto += espacios + valor;
            linea.AppendLine(textoCompleto);
        }

        //Metodo para agreagar articulos al ticket de venta
        public void AgregaArticulo(string Item, string Descripcion, string UM, double Total)
        {
            datosTamanoPapelEmpresa();
            string elemento = "", espacios = "";
            int nroEspacios = 0;
            string DescripcionR = Descripcion;
            if (Descripcion.Length > 5)
            {
                DescripcionR = Descripcion.Substring(0, 7);
            }
            ////for (int i = 0; i < (7 - Item.Length); i++)
            ////{
            ////    espacios += " ";
            ////}
            espacios = "   ";
            elemento = Item + espacios;

            //Colocar la descripcion a la derecha.
            ////nroEspacios = (14 - DescripcionR.ToString().Length);
            ////espacios = "";
            ////for (int i = 0; i < nroEspacios; i++)
            ////{
            ////    espacios += " ";
            ////}
            espacios = "  ";
            elemento += espacios + DescripcionR.ToString();

            //Colocar la unidad de medida a la derecha.
            ////nroEspacios = (3 - UM.ToString().Length);
            ////espacios = "";
            ////for (int i = 0; i < nroEspacios; i++)
            ////{
            ////    espacios += " ";
            ////}
            espacios = " ";
            elemento += espacios + UM.ToString();

            //Colocar el total a la derecha.
            ////nroEspacios = (8 - String.Format("{0:###,##0.}", Convert.ToDouble(Total)).Length);
            ////espacios = "";
            ////for (int i = 0; i < nroEspacios; i++)
            ////{
            ////    espacios += " ";
            ////}
            espacios = " ";
            elemento += espacios + Total.ToString("N"); //String.Format("{0:###,##0.}", Convert.ToDouble(Total));

            linea.AppendLine(elemento);

        }

        public void MuestraCalculoPRecioProducto(string Cantidad, double ValorUnidad)
        {
            datosTamanoPapelEmpresa();
            if (Cantidad.ToString().Length <= 16 && ValorUnidad.ToString().Length <= 16)
            {
                string elemento = "", espacios = "";
                int nroEspacios = 0;
                string Signo = " X ";

                for (int i = 0; i < (15 - Cantidad.Length); i++)
                {
                    espacios += " ";
                }
                elemento = espacios + Cantidad;

                nroEspacios = (3 - Signo.ToString().Length);
                espacios = "";
                for (int i = 0; i < nroEspacios; i++)
                {
                    espacios += " ";
                }
                elemento += espacios + Signo.ToString();

                nroEspacios = (13 - ValorUnidad.ToString("N").Length);//String.Format("{0:###,##0.}", Convert.ToDouble(ValorUnidad)).Length);
                espacios = "";
                for (int i = 0; i < nroEspacios; i++)
                {
                    espacios += " ";
                }
                elemento += ValorUnidad.ToString("N") + espacios;//String.Format("{0:###,##0.}", Convert.ToDouble(ValorUnidad)) + espacios;

                linea.AppendLine(elemento);
            }
            else
            {
                linea.AppendLine("Los valores ingresados para esta fila");
                linea.AppendLine("superan las columnas soportdas por éste.");
                throw new Exception("Los valores ingresados para algunas filas del ticket\nsuperan las columnas soportdas por éste.");
            }
        }

        //Metodos para enviar secuencias de escape a la impresora
        //Para cortar el ticket
        public void CortaTicket()
        {
            linea.AppendLine("\x1B" + "m"); //Caracteres de corte. Estos comando varian segun el tipo de impresora
            //linea.AppendLine("\x1B" + "d" + "\x09"); //Avanza 9 renglones, Tambien varian
        }
        //Para abrir el cajon
        public void AbreCajon()
        {
            //Estos tambien varian, tienen que ever el manual de la impresora para poner los correctos.
            linea.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96"); //Caracteres de apertura cajon 0
            //linea.AppendLine("\x1B" + "p" + "\x01" + "\x0F" + "\x96"); //Caracteres de apertura cajon 1
            //linea.AppendLine("\x1b" + "\x7" + "\xb" + "\x37" + "\x7"); //Caracteres de apertura cajon 0
        }
        //Para mandara a imprimir el texto a la impresora que le indiquemos.
        public void ImprimirTicketCaja(string impresora)
        {
            //Este metodo recibe el nombre de la impresora a la cual se mandara a imprimir y el texto que se imprimira.
            //Usaremos un código que nos proporciona Microsoft. https://support.microsoft.com/es-es/kb/322091

            //Crear arhivo 
            StreamWriter EscriturasKardex = File.AppendText("RegistroCaja.txt");
            EscriturasKardex.WriteLine(linea.ToString());
            EscriturasKardex.Close();

            RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString()); //Imprime texto.
            linea.Clear();//Al cabar de imprimir limpia la linea de todo el texto agregado.
        }

        public void ImprimirTicket(string impresora)
        {
            //Este metodo recibe el nombre de la impresora a la cual se mandara a imprimir y el texto que se imprimira.
            //Usaremos un código que nos proporciona Microsoft. https://support.microsoft.com/es-es/kb/322091

            //Crear arhivo 
            StreamWriter EscriturasKardex = File.AppendText("FacturaVenta.txt");
            EscriturasKardex.WriteLine(linea.ToString());
            EscriturasKardex.Close();

            RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString()); //Imprime texto.
 
            linea.Clear();//Al cabar de imprimir limpia la linea de todo el texto agregado.
        }
    }

    //Clase para mandara a imprimir texto plano a la impresora
    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "Ticket de Venta";//Este es el nombre con el que guarda el archivo en caso de no imprimir a la impresora fisica.
            di.pDataType = "RAW";//de tipo texto plano

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }

    }
}
