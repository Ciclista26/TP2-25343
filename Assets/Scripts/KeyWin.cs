using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyWin : MonoBehaviour
{
    private GameObject gController;

    private void Start() {
        //Get Game Controller
        gController = GameObject.Find("Game Controller");
    }

    public void OnTriggerEnter(Collider other) {
        Debug.Log("Hello: 2");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hello: ");
            //Delete Collectable
            Destroy(gameObject);
            //Update stored number of Collectables
            gController.transform.GetComponent<GameController>().numberCollectables -= 1;
        }
    }
}