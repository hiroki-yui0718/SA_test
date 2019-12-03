using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MySql.Data.MySqlClient;

public class LoginCNT : MonoBehaviour
{
    public GameObject gameObject;

    public bool login;
    public bool addAcount;
    public bool ret;
    public bool reinput;
    DAO d = new DAO();


    public void OnClickLogin()
    {
        d.Start();
        string sql = "SELECT PASSWORD FROM LOGIN WHERE ID = \'" + InputID.ID + "\';";
        MySqlCommand cmd = new MySqlCommand(sql, DAO.conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        rdr.Read();
        string decPass = rdr[0].ToString();
        InputPass.AddPass = AvoEx.AesEncryptor.DecryptString(decPass);
        d.End();

        if (InputPass.SW_check == true)
        {
            login = true;
        }
    }

    public void OnClickAddAcount()
    {
        addAcount = true;
    }

    public void OnClickRet()
    {
        ret = true;
    }

    public void OnClickOk()
    {
        reinput = true;
        gameObject.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);

        login = false;
        addAcount = false;
        ret = false;
        reinput = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (login == true)
        {
            if (InputID.SW == true && InputPass.SW == true)
            {
                SceneManager.LoadScene("SA_Acene");
            }
            if (InputID.SW == false || InputPass.SW == false)
            {
                gameObject.SetActive(true);
            }
        }

        if (reinput == true)
        {
            gameObject.SetActive(false);
        }

        if (addAcount == true)
        {
            SceneManager.LoadScene("SA_AddAcount");
        }

        if (ret == true)
        {
            SceneManager.LoadScene("SA_title");
        }
    }
}
