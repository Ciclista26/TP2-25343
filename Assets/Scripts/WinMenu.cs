
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void GoToScene(string screneName){
        SceneManager.LoadScene(screneName);
    }

}
