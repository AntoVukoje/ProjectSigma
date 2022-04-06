using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    private GameObject cam;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        player = GameObject.Find("Player_body");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cam.transform.position = player.transform.position + new Vector3(-10, 10, -10);
    }
}
