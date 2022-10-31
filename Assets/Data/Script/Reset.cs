using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public void Refresh()
    {
        SceneManager.LoadScene("MultiModelsScene");
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void Cube()
    {
        SceneManager.LoadScene("Cube&Card");
    }
    public void Chart()
    {
        SceneManager.LoadScene("Chart");
    }
    public void QuitApp()
    {
        Application.Quit();
    }

}
