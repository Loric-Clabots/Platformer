using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour

{
    // Start is called before the first frame update
    GameObject Player;
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, Player.transform.position.x, 0.05f),
            Mathf.Lerp(transform.position.y, Player.transform.position.y, 0.05f),
            -1
            );
        
    }
}
