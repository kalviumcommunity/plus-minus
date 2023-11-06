// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using MySql.Data.MySqlClient;

// public class DatabaseManager : MonoBehaviour
// {
//     private MySqlConnection connection;
//     private string serverAddress = "http://localhost:3306";
//     private string databaseName = "plusminus";
//     private string username = "root";
//     private string password = "test123";

//     private void Start()
//     {
//         string connectionString = $"Server={serverAddress};Database={databaseName};User={username};Password={password};";

//         try
//         {
//             connection = new MySqlConnection(connectionString);
//             connection.c

//             string Query = "sample_sql_query";

//             MySqlCommand cmd = new MySqlCommand(Query, connection);
//             cmd.ExecuteNonQuery();

//             Debug.Log("Executed successfully.");
//         }
//         catch (Exception e)
//         {
//             Debug.LogError("Error: " + e.Message);
//         }
//         finally
//         {
//             if (connection != null && connection.State == ConnectionState.Open)
//             {
//                 connection.Close();
//             }
//         }
//     }

//     private void OnDestroy()
//     {
//         if (connection != null && connection.State == ConnectionState.Open)
//         {
//             connection.Close();
//         }
//     }
// }
