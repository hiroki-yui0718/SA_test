using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ext : MonoBehaviour
{

    public bool SW_Ext;

    public void OnClick_yes()
    {
        Application.Quit();
    }

    public void OnClick_no()
    {
        titleBtn_CNT.SW_Ext = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
