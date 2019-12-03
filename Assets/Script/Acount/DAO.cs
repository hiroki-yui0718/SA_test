using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using System;

public class DAO : MonoBehaviour
{
    string SERVER = "database.ccxbloox0nzo.us-east-2.rds.amazonaws.com";
    string DATABASE = "YAMINABE";
    string USERID = "root";
    string PORT = "3306";
    string PASSWORD = "rootroot";
    public static MySqlConnection conn;

    // Start is called before the first frame update
    public void Start()
    {
        string connCmd =
     "server=" + SERVER + ";" +
     "database=" + DATABASE + ";" +
     "userid=" + USERID + ";" +
     "port=" + PORT + ";" +
     "password=" + PASSWORD;
        conn = new MySqlConnection(connCmd);

        try
        {
            Debug.Log("MySQLと接続中...");
            conn.Open();

        }
        catch (Exception ex)
        {
            Debug.Log(ex.ToString());
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void End()
    {
        DAO.conn.Close();
        Debug.Log("接続を終了しました");
    }
}
