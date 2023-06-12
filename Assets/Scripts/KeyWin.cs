using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyWin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Trigger entered by " + other.gameObject.name);
        if(other.gameObject.tag == "Enemy"){
            Debug.Log("Win");
            SceneManager.LoadScene("ScreneWin");
        }
    }

}