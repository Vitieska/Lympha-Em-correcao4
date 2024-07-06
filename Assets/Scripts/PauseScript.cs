using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject PausePanel;
    public bool IsPaused = false;
    void Update()
    {
        
    }
    public void Pause()
    {
        if (IsPaused == false)
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0;
            IsPaused = true;
        }
    }
    public void Continue()
    {
        if (IsPaused == true)
        {
            PausePanel.SetActive(false);
            Time.timeScale = 1;
            IsPaused= false;
        }
    }
}
