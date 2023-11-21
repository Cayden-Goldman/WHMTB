using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene("Main");
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
