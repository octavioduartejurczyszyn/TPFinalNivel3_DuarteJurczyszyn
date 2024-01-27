﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //claro aca abajo lo hacemos con constructor porque cada vez que yo llame a
        //AccesoDatos quiero que se conecte a la DB con la que estoy trabajando.
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_WEB_DB; integrated security=true");
            comando = new SqlCommand();
        }
         public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void setearConsultaDetalle(string consulta, int Id)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta + " @Id";

            SqlParameter parametroId = new SqlParameter("@Id", Id);
            comando.Parameters.Add(parametroId);
        }
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
            conexion.Open();
            lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public void cerrarConexion()
        {
            lector?.Close();
            conexion.Close();
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
