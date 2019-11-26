using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logout : MonoBehaviour
{
    public bool Logout_SW;

    public void OnClick_yes()
    {
        Logout_SW = true;
    }

    public void OnClick_No()
    {
        AceneCNT.Logout_SW = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        Logout_SW = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Logout_SW == true)
        {
            SceneManager.LoadScene("SA_title");
        }
    }
}
