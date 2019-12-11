using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoscroll : MonoBehaviour
{ public GameObject Player;


    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Player==null)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
        }
        transform.position = Player.transform.position + offset;  
    }
}
