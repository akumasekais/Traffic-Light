using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void SwitchScene(int _sceneIndex)
    {
        SceneManager.LoadScene(_sceneIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game asserted");
    }
}
