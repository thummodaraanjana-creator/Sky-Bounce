using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class HomeController : MonoBehaviour
{
    void Start()
    {
        
    }//start

    void Update()
    {
        
    }//update

    public void GoToGameView()
    {
        SceneManager.LoadScene(SceneData.GameViewIndex);
    }
}
