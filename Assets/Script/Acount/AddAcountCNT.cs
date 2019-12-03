using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MySql.Data.MySqlClient;

public class AddAcountCNT : MonoBehaviour
{
    InputField inputField;
    public GameObject gameObject;

    public static string Name = null;
    public static string ID = null;
    public static string pass = null;
    public static string pass2 = null;

    public bool Name_SW;
    public bool ID_SW;
    public bool pass_SW;
    public bool pass2_SW;

    public bool reary;
    public bool reary_ok;
    public bool reary_no;
    public bool cancel;

    public static int Name_len;
    public static int ID_len;
    public static int pass_len;
    public static int pass2_len;
    DAO d = new DAO();

    // Start is called before the first frame update
    void Start()
    {


        gameObject.SetActive(false);

        Name_SW = false;
        ID_SW = false;
        pass_SW = false;
        pass2_SW = false;

        reary = false;
        reary_ok = false;
        cancel = false;

       
    }

    // Update is called once per frame
    void Update()
    {
        Name = Username.Name;
        ID = UserID.ID;
        pass = UserPass.pass;
        pass2 = UserPass.pass2;

        Name_SW = Username.SW;
        ID_SW = UserID.SW;
        pass_SW = UserPass.SW;
        pass2_SW = UserPass.SW2;

        if (reary == true)
        {
            gameObject.SetActive(true);
        }
        else if (reary == false)
        {
            gameObject.SetActive(false);
        }

        if (reary_ok == true)
        {
            SceneManager.LoadScene("SA_Login");
        }

        if (cancel == true)
        {
            SceneManager.LoadScene("SA_Login");
        }
    }

 

    public void Onclick_OK()
    {
        if (Name_SW == true && ID_SW == true && pass_SW == true && pass2_SW == true)
        {
            d.Start();
            
            string sql = "INSERT INTO LOGIN VALUES(@ID,@Name,@Pass);";
            MySqlCommand cmd = new MySqlCommand(sql, DAO.conn);
            MySqlParameter pID = new MySqlParameter("@ID", ID);
            cmd.Parameters.Add(pID);
            MySqlParameter pName = new MySqlParameter("@Name", Name);
            cmd.Parameters.Add(pName);
            string cryptPass = AvoEx.AesEncryptor.Encrypt(pass);
            MySqlParameter pPass = new MySqlParameter("@Pass", cryptPass);
            cmd.Parameters.Add(pPass);
            cmd.ExecuteNonQuery();
            d.End();
            reary = true;
        }
    }

    public void OnClicl_rearyOK()
    {
        reary_ok = true;
    }

    public void OnClick_rearyNo()
    {
        reary = false;
    }

    public void OnClickCancel()
    {
        cancel = true;
    }


}
