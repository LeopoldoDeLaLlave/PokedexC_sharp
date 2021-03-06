﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
/*
 * Autor: Javier de la Llave
 * 
 * Esta clase se encarga de realizar la conexión con la base de datos
 */
namespace PokedexC_sharp
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            try
            {
                //Nos conectamos a la base de datos
                conexion = new MySqlConnection("Server = 192.168.182.137; Database = listapokemons; Uid = root; Pwd=; Port=3306");
            }
            catch (MySqlException e)
            {
                throw e;
            }
            
        }

        //Obtiene la fila del pokemon en la base de datos según su ID
        public DataTable getPokemonPorId(int id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM pokemon WHERE id ='" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        //Obtiene el ID de un pokemon por su nomre
        public String getPokemonPorNombre(String nombre)
        {
            
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT id FROM pokemon WHERE LOWER(nombre) ='" + nombre + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons.Rows[0]["id"].ToString();

            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


        public DataTable getTodos()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT id AS ID, nombre AS Nombre, CONCAT(altura, ' m') AS Altura, CONCAT(peso,' kg') AS Peso, " +
                    "especie AS Especie, habitat AS Habitat, CONCAT(tipo1, ' ',tipo2) AS Tipo, habilidad AS Habilidad, descripcion AS Descripcion, imagen AS Miniatura FROM pokemon", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        }
   
   
 
}
