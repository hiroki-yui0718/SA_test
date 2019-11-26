using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPass : MonoBehaviour
{
    InputField inputField;

    public Text check;

    public static string pass = null;
    public string AddPass;

    int len;

    public static bool SW;
    public static bool SW_check;

    // Start is called before the first frame update
    void Start()
    {
        //check = GetComponent<Text>();
        inputField = GetComponent<InputField>();
        AddPass = AddAcountCNT.pass;
        check.text = "";
        SW = false;
        SW_check = false;
        pass = "";
    }

    public void IunputPass()
    {
        pass = inputField.text;
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
            check.color = new Color(0.0f, 1.0f, 1.0f, 1.0f);
            check.text = "認証可能なユーザーIDです";
            SW_check = true;
        }
        else if (len < 4 && pass != null)
        {
            check.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            check.text = "認証不可能なIDです";
            SW_check = false;
        }
    }
}
