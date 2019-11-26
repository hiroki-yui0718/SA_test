using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Username : MonoBehaviour
{
    InputField inputField;

    public Text check;

    public static string Name;

    public string check_yes = "利用可能";
    public string check_no = "利用不可";

    public static int len;

    public static bool SW;

    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
        check.text = check_no;
        Name = "";

        SW = false;
    }

    public void InputName()
    {
        Name = inputField.text;
        //InitInputField();
    }

    void InitInputField()
    {
       // inputField.ActivateInputField();
    }

    // Update is called once per frame
    void Update()
    {
        len = Name.Length;
        if (len >= 4)
        {
            check.text = check_yes;
            SW = true;
        }else if(len < 4)
        {
            check.text = check_no;
            SW = false;
        }
    }
}
