using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginCNT : MonoBehaviour
{
    public GameObject gameObject;

    public bool login;
    public bool addAcount;
    public bool ret;
    public bool reinput;



    public void OnClickLogin()
    {
 

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
            if (InputPass.SW == true)
            {
                SceneManager.LoadScene("SA_Acene");
            }
            if (InputPass.SW == false)
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
