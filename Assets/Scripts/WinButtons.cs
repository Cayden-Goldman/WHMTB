using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinButtons : MonoBehaviour
{
    public void Title()
    {
        SceneManager.LoadScene("Title");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
