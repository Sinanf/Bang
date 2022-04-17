using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGameController : MonoBehaviour
{

    public bool paused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void PlayerLostLife()
    {
        // deal with player life lost (update U.I. etc.)
    }

    public virtual void StartGame()
    {
        // do start game functions
    }

    public virtual void RestartGameButtonPressed()
    {
        // deal with restart button (default behavior re-loads the
        // currently loaded scene)
        //Application.LoadLevel(Application.loadedLevelName);
    }

    public bool Paused
    {
        get
        {
            // get paused
            return paused;
        }
        set
        {
            // set paused
            paused = value;
            if (paused)
            {
                // pause time
                Time.timeScale = 0f;
            }
            else
            {
                // unpause Unity
                Time.timeScale = 1f;
            }
        }

    }
}
