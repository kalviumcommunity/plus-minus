using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;

public class DatabaseManager : MonoBehaviour
{
    private MySqlConnection connection;
    private string serverAddress = "your_server_address";
    private string databaseName = "your_database_name";
    private string username = "your_username";
    private string password = "your_password";

    private void Start()
    {
        string connectionString = $"Server={serverAddress};Database={databaseName};User={username};Password={password};";

        try
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            // Create a new table named 'YourTableName'
            string createTableQuery = "sample_sql_query";

            MySqlCommand cmd = new MySqlCommand(createTableQuery, connection);
            cmd.ExecuteNonQuery();

            Debug.Log("Table created successfully.");
        }
        catch (Exception e)
        {
            Debug.LogError("Error: " + e.Message);
        }
        finally
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }

    private void OnDestroy()
    {
        if (connection != null && connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }
}
