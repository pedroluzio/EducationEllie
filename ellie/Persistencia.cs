﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Ellie
{
    public class Persistencia
    {

        public static Int32 idPlayer;
        public static Int32 IdPlayer    // the Name property
        {
            get
            {
                return idPlayer;
            }
            set
            {
                idPlayer = value;
            }
        }
        //Guarda aqui o nome para inserção no SQLite.
        private string createTableQuery = @"CREATE TABLE IF NOT EXISTS GameResults (
                          ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          PlayerName NVARCHAR(2048)  NOT NULL,
                          Score VARCHAR(2048)  NULL,
                          GameDateTime VARCHAR(2048)  NULL
                          )";

        private SQLiteConnection conexao;

        public Persistencia()
        {
            if (!File.Exists("EllieDatabase.db"))
            {
                SQLiteConnection.CreateFile("EllieDatabase.db");        // Create the file which will be hosting our database
            }
            conexao = new System.Data.SQLite.SQLiteConnection("data source=EllieDatabase.db");

            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conexao))
            {
                conexao.Open();

                com.CommandText = createTableQuery;
                com.ExecuteNonQuery();
            }

            conexao.Close();


        }

        public Int32 SaveNewPlayer(String PlayerName)
        {
            idPlayer = 0;

            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conexao))
            {
                conexao.Open();

                com.CommandText = "INSERT INTO GameResults (PlayerName, Score) Values ('" + PlayerName + "','0')";
                com.ExecuteNonQuery();

                //Recupera o novo registro 
                com.CommandText = "Select * FROM GameResults WHERE PlayerName ='" + PlayerName + "'";      // Select all rows from our database table

                using (System.Data.SQLite.SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idPlayer = Convert.ToInt32(reader["ID"]);

                        Console.WriteLine(reader["PlayerName"] + " : " + reader["Score"]);     // Display the value of the key and value column for every row
                    }
                }
                conexao.Close();        // Close the connection to the database
            }

            return idPlayer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Gerar">True se for para gerar novo resultado, False para apenas apresentar</param>
        /// <param name="Acerto">True para incrementar o resultado, False para decrementar o resultado</param>
        public string geraResultado(Boolean Gerar = true, Boolean Acerto = true)
        {

            string Label = "";
            Boolean Minimo = false;
            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(conexao))
            {
                conexao.Open();


                if (Gerar)
                {
                    com.CommandText = "Select Score FROM GameResults WHERE ID =" + idPlayer.ToString();
                    using (System.Data.SQLite.SQLiteDataReader reader = com.ExecuteReader())
                        while (reader.Read())
                            Minimo = Convert.ToInt32(reader["Score"]) == 0 ? true : false;
                    if ((!Minimo && !Acerto) || (Acerto))
                    {

                        com.CommandText = "UPDATE GameResults SET Score=Score" + (Acerto ? "+" : "-") + "1 WHERE ID=" + idPlayer.ToString();
                        com.ExecuteNonQuery();
                    } 
                }

                com.CommandText = "Select PlayerName, Score FROM GameResults WHERE ID =" + idPlayer.ToString();
                using (System.Data.SQLite.SQLiteDataReader reader = com.ExecuteReader())
                    while (reader.Read())
                        Label = reader["PlayerName"].ToString() + " - " + reader["Score"].ToString();

                conexao.Close();        // Close the connection to the database
            }
            return Label;

        }
    }
}
