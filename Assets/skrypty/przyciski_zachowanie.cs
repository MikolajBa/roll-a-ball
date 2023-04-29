using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class przyciski_zachowanie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void Sceny()
    {
        SceneManager.LoadScene(1);

    }
    public void ShowOptions()
    {
        SceneManager.LoadScene("opcje", LoadSceneMode.Single);

    }


    public void ExitGame()
    {

        Application.Quit();
    }


    public void BackMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);

    }

}
