using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public void LoadDebugScene(){
        SceneManager.LoadScene("Debug");
    }

    public void QuitDebugging(){
        Application.Quit();
    }
    
}
