﻿using Practico.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico.Formularios.Abm.Usuarios;

namespace Practico.Negocios
{
    class Usuarios
    {
        private BaseDatos baseDatos = new BaseDatos(); // creacion de la base de datos

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        };


        public Respuesta ValidarUsuario(string usuario, string password) // valida si el usuario existe
        {
            string sql = "SELECT * FROM Usuarios WHERE nombreUsuario = '" + usuario + "' AND contrasenia= '" +
                         password + "'";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);

            if (tabla.Rows.Count == 1)
            {
                return Respuesta.validacionCorrecta;
            }
            else
            {
                return Respuesta.validacionIncorrecta;
            }
        }

        public int RecuperarIdUsuario(string usuario, string password)
        {
            string sql = "SELECT * FROM Usuarios WHERE nombreUsuario = '" + usuario + "' AND contrasenia= '" +
                         password + "'";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);

            if (tabla.Rows.Count == 1)
            {
                return int.Parse(tabla.Rows[0]["idUsuario"].ToString()); // retorna idUsuario
            }
            else
            {
                return 0;
            }
        }

        public DataTable TodosLosUsuarios()
        {
            string sql = "SELECT * FROM Usuarios ";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }


        public DataTable BuscarUsuario(string nombre)
        {
            string sql = "SELECT * FROM Usuarios WHERE nombreUsuario LIKE '%" + nombre.Trim() + "%'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        // NO LO DIO EN CLASES
        public Respuesta ValidarUsuario(string usuario) // valida si el nombre de usuario existe
        {
            string sql = "SELECT * FROM Usuarios WHERE nombreUsuario = '" + usuario + "'";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);

            if (tabla.Rows.Count == 1)
            {
                return Respuesta.validacionCorrecta;
            }
            else
            {
                return Respuesta.validacionIncorrecta;
            }
        }


        public Respuesta IngresarUsuario(string nombre, string contraseña)
        {
            string sql = "INSERT INTO Usuarios VALUES "+"('"+nombre+"','"+contraseña+"')";


            if (ValidarUsuario(nombre) == Respuesta.validacionIncorrecta)
            {
                baseDatos.Insertar(sql);
                return Respuesta.validacionCorrecta;
            }

            return Respuesta.validacionIncorrecta;
        }

        public void EliminarUsuario(int id)
        {
            string sql = "DELETE FROM Usuarios WHERE idUsuario =" + id;
            baseDatos.Eliminar(sql);

        }

        public DataTable RecuperarUsuario(int id)
        {
            string sql = "SELECT * FROM Usuarios WHERE idUsuario = " + id;
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta ModificarUsuario(int id, string nombre, string contraseña)
        {
            string sql = "UPDATE Usuarios" + " SET nombreUsuario = '" + nombre +
                         "'," + "contrasenia ='" + contraseña + "' " +
                         "WHERE idUsuario = " + id;
            if (baseDatos.Consulta(sql).HasErrors)
            {
                return Respuesta.validacionIncorrecta;
            }
            else
            {
                return Respuesta.validacionCorrecta;
            }
        }
    }
}
