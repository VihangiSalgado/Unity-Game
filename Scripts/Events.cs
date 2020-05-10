using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{

    public void ReplayGame()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void QuitGame()
    {
        Application.Quit();
    }




}
