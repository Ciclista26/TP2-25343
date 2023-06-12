using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToScene(string screneName){
        SceneManager.LoadScene(screneName);
    }

    public void QuitApp(){
        Application.Quit();
    }

}
