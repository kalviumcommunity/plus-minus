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
//     private string password = "$Hutkone321";

//     private void Start()
//     {
//         string connectionString = $"Server={serverAddress};Database={databaseName};User={username};Password={password};";

//         try
//         {
//             connection = new MySqlConnection(connectionString);
//             connection.Open();

//             // Create a new table named 'YourTableName'
//             string createTableQuery = "sample_sql_query";

//             MySqlCommand cmd = new MySqlCommand(createTableQuery, connection);
//             cmd.ExecuteNonQuery();

//             Debug.Log("Table created successfully.");
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
