using System;
using System.Data.SqlClient;
using System.Data;
using SBX.Properties;

namespace SBX.MODEL
{
    public class Paginar
    {
        public static string mtd_obtenerConexion()
        {
            return Settings.Default.DB_SBXConnectionString;
        }
       
        private String  ps_cadena= mtd_obtenerConexion(); 
        private int _inicio = 0;
        private int _tope = 0;

        private int _numeroPagina = 1;
        private int _cantidadRegistros = 0;
        private int _ultimaPagina = 0;

        private String _datamember;
        private SqlDataAdapter _adapter;
        private DataSet _datos;

        //s_query:          El query de conexion
        //s_datamember:     se asigna al datagridview despues del datasource
        //i_canidadxpagina: cantidad de registros por pagina
        public Paginar(String s_query, String s_datamember, int i_cantidadxpagina)
        {
            this._inicio = 0;
            this._tope = i_cantidadxpagina;
            this._datamember = s_datamember;

            DataTable auxiliar; 

            SqlConnection connection = new SqlConnection(ps_cadena);
            this._adapter = new SqlDataAdapter(s_query, connection);
            this._datos = new DataSet();
            auxiliar = new DataTable();

            connection.Open();
            this._adapter.Fill(_datos, _inicio, _tope, _datamember);
            _adapter.Fill(auxiliar);
            connection.Close();
            this._cantidadRegistros = auxiliar.Rows.Count;

            asignarTope();

        }

        private void asignarTope()
        {
            _ultimaPagina = _cantidadRegistros / _tope;


            int aux = _cantidadRegistros % _tope ;  
            if (_ultimaPagina == 0)
            {
                this._ultimaPagina = 1;
            }
            else if (_ultimaPagina >= 1 && (aux > 0))
            {
                this._ultimaPagina = _ultimaPagina + 1;
            }

            this._numeroPagina = 1;
        }

        public DataSet cargar()
        {
            return _datos;
        }

        public DataSet primeraPagina()
        {
            this._numeroPagina=1;
            this._inicio = 0;
            this._datos.Clear();
            this._adapter.Fill(this._datos, this._inicio, this._tope, this._datamember);

            return _datos;
        }
       
        public DataSet ultimaPagina() 
        {
            this._numeroPagina = _ultimaPagina;
            this._inicio = (_ultimaPagina-1 ) * _tope;
            this._datos.Clear();
            this._adapter.Fill(this._datos, this._inicio, this._tope, this._datamember);

            return _datos;
        }

        public DataSet atras()
        {
            if (this._numeroPagina == 1)
            {
                return _datos;
            }

            this._numeroPagina--;
            this._inicio = _inicio - _tope;
            this._datos.Clear();
            this._adapter.Fill(this._datos, this._inicio, this._tope, this._datamember);

            return _datos;
        }

        public DataSet adelante()
        {
            if (this._ultimaPagina == this._numeroPagina)
            {
                return _datos;
            }

            this._numeroPagina++;
            this._inicio = _inicio + _tope;
            this._datos.Clear();
            this._adapter.Fill(this._datos, this._inicio, _tope, this._datamember);

            return _datos;
        }

        public DataSet actualizaTope(int i_tope)
        {
            this._tope = i_tope;
            this._inicio = 0;
            asignarTope();

            _datos.Clear();
            this._adapter.Fill(this._datos, this._inicio, _tope, this._datamember);
            return _datos;
        }

        public int countRow()
        {
            return _cantidadRegistros;
        }

        public int countPag()
        {
            return _ultimaPagina;
        }

        public int numPag()
        {
            return _numeroPagina;
        }

        public int limitRow()
        {
            return _tope;
        }


    }
}
