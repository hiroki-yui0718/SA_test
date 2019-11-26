using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AceneCNT : MonoBehaviour
{
    public GameObject Logout;

    public static bool Logout_SW;

    public void OnClickLogout()
    {
        Logout_SW = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        Logout.SetActive(false);

        Logout_SW = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Logout_SW == true)
        {
            Logout.SetActive(true);
        }
        else if (Logout_SW == false)
        {
            Logout.SetActive(false);
        }
    }
}
