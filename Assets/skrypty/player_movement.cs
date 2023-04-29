using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_movement : MonoBehaviour
{
    public Text scoreText;
    public Text wygrana;
    Rigidbody m_Rigidbody;
    public float m_Speed = 5;
    public float m_Thrust = 200;
    public int score;
    new Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera> ();
        m_Rigidbody = GetComponent<Rigidbody>();
        
    }
    /*
    public void Collectible()
    {
        scoreText.text = "Score:" + score;
    }
        */
    // Update is called once per frame

    void FixedUpdate()
    {

        {
           // if (Input.GetKey(KeyCode.Space))
            //{
               // Debug.Log("space");
              //  m_Rigidbody.AddForce(Vector3.up * m_Thrust);
            //}
            if (Input.GetKey(KeyCode.S))
            {
                //Debug.Log("s");
                m_Rigidbody.AddForce(Vector3.back * m_Thrust );
            }
            if (Input.GetKey(KeyCode.D))
            {
                //Debug.Log("d");
                m_Rigidbody.AddForce(Vector3.right * m_Thrust);

            }
            if (Input.GetKey(KeyCode.A))
            {
                m_Rigidbody.AddForce(Vector3.left * m_Thrust);
            }
            if (Input.GetKey(KeyCode.W))
            {
                m_Rigidbody.AddForce(Vector3.forward * m_Thrust);
            }
        }
    }
}
