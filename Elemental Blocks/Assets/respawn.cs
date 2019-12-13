using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {


    public GameObject Playerprefab;
    public GameObject Player;
    public float Timer;

    // Use this for initialization
    void Start()
    {

        
        Spawn();
    }

    void Spawn()
    {
        Timer = 2;
        Player = (GameObject)Instantiate(Playerprefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                Spawn();

            }
        }
    }
}
