using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collectible : MonoBehaviour
{
    //sceny
    public int scene ;
    //text
    public Text score_wynik_UI;
    public Text wygrana;
    //MUZYKA
    AudioSource audioSource;
    //muzyka
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the AudioSource from the GameObject
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame

    void Update()
    {
        transform.Rotate(0,200 * Time.deltaTime,0);
    }
    public Transform explosionPrefab;
    void OnTriggerEnter(Collider colllider)
    {       
            //score
            colllider.gameObject.GetComponent<player_movement>().score += 1;
            score_wynik_UI.text = "score:" + colllider.gameObject.GetComponent<player_movement>().score;
            audioSource.Play();
            Invoke("effect", 0.8f);
           
            //text po zebraniu
            if (colllider.gameObject.GetComponent<player_movement>().score >= 3)
            {
            wygrana.text = "brawo";
            Invoke("Change_Scene", 2.0f);
        }
    }
    public void effect()
    {
        gameObject.SetActive(false);
    }
    public void Change_Scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
