using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputID : MonoBehaviour
{
    InputField inputField;

    public  Text check;

    public static string ID = null;
    public string AddID;

    int len;

    public static bool SW;
    public static bool SW_check;

    // Start is called before the first frame update
    void Start()
    {
        //check = GetComponent<Text>();
        inputField = GetComponent<InputField>();
        AddID = AddAcountCNT.ID;
        check.text = "";
        SW = false;
        SW_check = false;
        ID = "";
    }

    public void IunputID()
    {
        ID = inputField.text;
    }

    // Update is called once per frame
    void Update()
    {
        
        len = ID.Length;

        if (AddID == ID)
        {
            SW = true;
        }
        else if (AddID != ID)
        {
            SW = false;
        }

        if (len >= 4 && ID != null)
        {
            check.color = new Color(0.0f, 1.0f, 1.0f, 1.0f);
            check.text = "認証可能なユーザーIDです";
            SW_check = true;
        } else if (len <4 && ID != null)
        {
            check.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            check.text = "認証不可能なIDです";
            SW_check = false;
        }
    }
}
