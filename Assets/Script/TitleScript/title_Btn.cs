using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class title_Btn : MonoBehaviour
{
/*    public GameObject Option;
    public GameObject GameExit;
    public GameObject ButtonSet;*/
    public bool Tra_Login;
    public bool SW_ops;
    public bool SW_Ext;

    public void OnClick_GS()
    {
        //titleBtn_CNT tbc = GetComponent<titleBtn_CNT>();
        //Tra_Login = true;
        titleBtn_CNT.Tra_Login = true;
    }

    public void OnClick_OP()
    {
        //titleBtn_CNT tbc = GetComponent<titleBtn_CNT>();
        //Option.SetActive(true);
        //SW_ops = true;
        titleBtn_CNT.SW_ops = true;
    }

    public void OnClick_EX()
    {
        //titleBtn_CNT tbc = GetComponent<titleBtn_CNT>();
        //GameExit.SetActive(true);
        //SW_Ext = true;
        titleBtn_CNT.SW_Ext = true;
    }

    public void OnClick_yes()
    {
        Application.Quit();
    }

    public void OnClick_no()
    {
        SW_Ext = false;
    }

    // Start is called before the first frame update
    void Start()
    {/*
        Option.SetActive(false);
        GameExit.SetActive(false);
        ButtonSet.SetActive(true);
        Tra_Login = false;
        SW_ops = false;
        SW_Ext = false;*/
    }

    // Update is called once per frame
    void Update()
    {/*
        if (Tra_Login == true)
        {
            SceneManager.LoadScene("SA_Login");
            Tra_Login = false;
        }

        if (SW_ops == true)
        {
            Option.SetActive(true);
            ButtonSet.SetActive(false);
        }

        if(SW_Ext == true)
        {
            GameExit.SetActive(true);
        }*/
    }
}
