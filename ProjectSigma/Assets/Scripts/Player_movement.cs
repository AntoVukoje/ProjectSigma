using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float speed = 5f;

    private GameObject player_body;

    // Start is called before the first frame update
    void Start()
    {
        player_body = GameObject.Find("Player_body");
    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        //RAVNO
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            player_body.transform.eulerAngles = new Vector3(0, 225, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right *speed * Time.deltaTime);
            player_body.transform.eulerAngles = new Vector3(0, 45, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            player_body.transform.eulerAngles = new Vector3(0, 315, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            player_body.transform.eulerAngles = new Vector3(0, 135, 0);
        }

        //DIJAGONALE
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            player_body.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            player_body.transform.eulerAngles = new Vector3(0, 360, 0);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            player_body.transform.eulerAngles = new Vector3(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            player_body.transform.eulerAngles = new Vector3(0, 270, 0);
        }
    }
}
