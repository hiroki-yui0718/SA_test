using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserPass : MonoBehaviour
{
    InputField inputField;

    public Text check;
    public Text check2;

    public static string pass;
    public static string pass2;

    public string check_yes = "利用可能";
    public string check_no = "利用不可";

    public static int len;
    public static int len2;

    public static bool SW;
    public static bool SW2;

    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
        check.text = check_no;
        check2.text = check_no;

        pass = "";
        pass2 = " ";

        SW = false;
        SW2 = false;
    }

    public void InputPass()
    {
        pass = inputField.text;
        //InitInputField();
    }

    public void InputPass2()
    {
        pass2 = inputField.text;
        //InitInputField();
    }

    void InitInputField()
    {
       // inputField.ActivateInputField();
    }

    // Update is called once per frame
    void Update()
    {
        len = pass.Length;
        if (len >= 4)
        {
            check.text = check_yes;
            SW = true;
        }
        else if (len < 4)
        {
            check.text = check_no;
            SW = false;
        }

        if (pass == pass2)
        {
            check2.text = check_yes;
            SW2 = true; 
        }
        else if (pass != pass2)
        {
            check2.text = check_no;
            SW2 = false;
        }
    }
}
