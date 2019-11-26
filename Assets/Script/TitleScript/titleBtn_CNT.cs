using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class titleBtn_CNT : MonoBehaviour
{
    public GameObject Option;
    public GameObject GameExit;
    public GameObject ButtonSet;

    public static bool Tra_Login;
    public static bool SW_ops;
    public static bool SW_Ext;
    public static bool SW_title = false;

    // Start is called before the first frame update
    void Start()
    {
        Tra_Login = false;
        SW_ops = false;
        SW_Ext = false;
        SW_title = plesesAnybutton.SW_btn;
    }

    // Update is called once per frame
    void Update()
    {
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
        else if (SW_ops == false)
        {
            Option.SetActive(false);

            if (SW_Ext != false)
            {
                ButtonSet.SetActive(true);
            }
        }

        if (SW_Ext == true)
        {
            GameExit.SetActive(true);
        }
        else
        {
            GameExit.SetActive(false);
        }
    }
}
