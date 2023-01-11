using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {


    // Use this for initialization
    void Start () {
    }

    #region Open Different panels


    public void newGame()
    {
        
        Debug.Log("Please write a scene name in the 'newGameSceneName' field of the Main Menu Script and don't forget to " +
                "add that scene in the Build Settings!");
    }
    #endregion

    #region Back Buttons

    public void Quit()
    {
        Application.Quit();
    }
    #endregion

}
