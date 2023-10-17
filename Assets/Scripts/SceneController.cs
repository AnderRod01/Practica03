using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadBlueScene()
    {
        SceneManager.LoadScene(2);
    }
    
    public void LoadRedScene()
    {
        SceneManager.LoadScene(3);
    }
    
    public void LoadGreenScene()
    {
        SceneManager.LoadScene(1);
    }
    
    public void LoadMainScene()
    {
        SceneManager.LoadScene(0);
    }
}
