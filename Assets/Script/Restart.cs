using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }
        
    }

    public void restartButton ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene(). buildIndex);
        Time.timeScale = 1;
    }
    
    public void menuButton ()
    {
        SceneManager.LoadScene(0);
    }

    public void hardButton ()
    {
        SceneManager.LoadScene(4);
    }

    public void mediumButton ()
    {
        SceneManager.LoadScene(3);
    }

    public void easyButton ()
    {
        SceneManager.LoadScene(2);
    }

    public void difficultyButton ()
    {
        SceneManager.LoadScene(1);
    }
}
 