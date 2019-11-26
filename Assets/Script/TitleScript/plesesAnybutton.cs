using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plesesAnybutton : MonoBehaviour
{
    public GameObject ButtonPane;
    public GameObject Text;
    public static bool SW_btn;

    // Start is called before the first frame update
    void Start()
    {
        ButtonPane.SetActive(false);
        Text.SetActive(true);
        SW_btn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SW_btn = true;
        }

        if (SW_btn == true)
        {
            ButtonPane.SetActive(true);
            Text.SetActive(false);
        }
        else if (SW_btn == true)
        {
            ButtonPane.SetActive(true);
            Text.SetActive(false);
        }
    }
}
