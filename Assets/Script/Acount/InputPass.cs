using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MySql.Data.MySqlClient;


public class InputPass : MonoBehaviour
{
    InputField inputField;

    public Text check;

    public static string pass = null;
    public string AddPass;

    int len;

    public static bool SW;
    public static bool SW_check;

    DAO d = new DAO();

    // Start is called before the first frame update
    void Start()
    {
        //check = GetComponent<Text>();
        inputField = GetComponent<InputField>(); 
/*        AddPass = LoginCNT.AddPass;*/
        check.text = "";
        SW = false;
        SW_check = false;
        pass = "";
    }

    public void IunputPass()
    {
        pass = inputField.text;
        d.Start();
        string sql = "SELECT PASSWORD FROM LOGIN WHERE ID = @ID;";
        MySqlCommand cmd = new MySqlCommand(sql, DAO.conn);
        MySqlParameter pID = new MySqlParameter("@ID", InputID.ID);
        cmd.Parameters.Add(pID);
        MySqlDataReader rdr = cmd.ExecuteReader();
        rdr.Read();
        string decPass = rdr[0].ToString();
        AddPass = AvoEx.AesEncryptor.DecryptString(decPass);
        d.End();

    }

    // Update is called once per frame
    void Update()
    {
        
        len = pass.Length;

        if (AddPass == pass)
        {
            SW = true;
        }
        else if (AddPass != pass)
        {
            SW = false;
        }

        if (len >= 4 && pass != null)
        {
/*            check.color = new Color(0.0f, 1.0f, 1.0f, 1.0f);
            check.text = "認証可能なユーザーIDです";*/
            SW_check = true;
        }
        else if (len < 4 && pass != null)
        {
/*            check.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            check.text = "認証不可能なIDです";*/
            SW_check = false;
        }
    }
}
