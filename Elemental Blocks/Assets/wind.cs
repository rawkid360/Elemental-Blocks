using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
public GameObject Player1;
public Vector2 jumpHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Player1==null)
        {
            Player1 = GameObject.FindGameObjectWithTag("Player");
        } 
    }
     private void OnTriggerEnter(Collider other)
     {
     if (other.gameObject.tag == "Player")
     {
     Player1.GetComponent<Rigidbody>().AddForce(jumpHeight, ForceMode.Impulse);
     }
     }
}
