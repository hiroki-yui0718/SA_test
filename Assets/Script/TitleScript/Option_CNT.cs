using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option_CNT : MonoBehaviour
{
    public Text BGMlabe;
    public Text SElabe;

    public bool BGM;
    public bool SE;

    public static int Volbgm;
    public static int Volse;

    public void OnClickBGM()
    {
        BGM = true;
        SE = false;
    }

    public void OnClickSE()
    {
        BGM = false;
        SE = true;
    }

    public void OnClickRet()
    {
        BGM = false;
        SE = false;
        titleBtn_CNT.SW_ops = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        Volbgm = 5;
        Volse = 5;

        BGMlabe.text = ""+Volbgm;
        SElabe.text = "" + Volse;

        BGM = false;
        SE = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (BGM == true && SE == false)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Volbgm++;
                if (Volbgm >= 10)
                {
                    Volbgm = 10;
                }
                BGMlabe.text = "" + Volbgm.ToString("0");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Volbgm--;
                if (Volbgm <= 1)
                {
                    Volbgm = 1;
                }
                BGMlabe.text = "" + Volbgm.ToString("0");
            }
        }

        if (BGM == false && SE == true)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Volse++;
                if (Volse >= 10)
                {
                    Volse = 10;
                }
                SElabe.text = "" + Volse.ToString("0");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Volse--;
                if (Volse <= 1)
                {
                    Volse = 1;
                }
                SElabe.text = "" + Volse.ToString("0");
            }
        }
    }
}
