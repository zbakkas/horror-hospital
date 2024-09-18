using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mawt : MonoBehaviour
{
    public Canvas gameover;

    // Start is called before the first frame update
    void Start()
    {
        gameover.enabled = false;
    }

    public void matt()
    {
        gameover.enabled = true;
        //tw9if game
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
