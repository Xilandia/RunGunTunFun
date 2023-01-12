using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddDots : MonoBehaviour
{
    public int numDots;
    public Text text;
    public char c;

    private float dotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        numDots = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (dotSpeed > 0)
        {
            dotSpeed -= Time.deltaTime;
        } else {
            dotSpeed = 1f;
            AddDot();
        }

        if (numDots >= 10) {
            Debug.Log("test");
            SceneManager.LoadScene("MainMenu");
        }

        
    }

    void AddDot() {
        text.text += c;
        numDots ++;
    }
}
