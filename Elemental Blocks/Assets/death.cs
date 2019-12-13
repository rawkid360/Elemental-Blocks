using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
public float lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
    if(lives >= 2)
            {
             lives = 2;
            }
    }
         
   private void OnTriggerEnter(Collider other)
   {
      if(other.gameObject.tag == "spike")
      {
            lives -= 1;
            if(lives <= 0)
            {
              Destroy(gameObject);
            }
      }
        if(other.gameObject.tag == "earth")
        {
            lives += 1;
        }
   }
   private void OnTriggerStay(Collider other)
   {
   if(other.gameObject.tag == "earth")
        {
            lives += 1;
        }
   }
}
