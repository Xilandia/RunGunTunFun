using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] private Vector3 returnPosition;

    public GameObject player;

    //Save player's current position before loading new scene
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);
            //Move player to the stored position
            player.transform.position = returnPosition;
        }
    }

}

