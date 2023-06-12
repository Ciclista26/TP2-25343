using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public int numberCollectables;
    public GameObject endMessage;
    public GameObject endMessage2;
    
    // Start is called before the first frame update
    void Start()
    {
        numberCollectables = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Display Game Over message
        if (numberCollectables == 0)
        {
            endMessage.SetActive(true);
            endMessage2.SetActive(false);
        }
    }
}
