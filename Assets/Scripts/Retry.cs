using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void retry()
    {
        SceneManager.LoadScene("Main");
    }

    public void title()
    {
        SceneManager.LoadScene("Title");
    }
}
