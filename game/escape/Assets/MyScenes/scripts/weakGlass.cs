using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weakGlass : MonoBehaviour
{
    // Start is called before the first frame update

    //public GameObject potionPop;
    //public Potion script;
    
    Potion potionScript;

    void Start()
    {
        //glassIsBreakable = false;
        potionScript = this.GetComponent<Potion>();
        potionScript.glassIsWeak = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;

        if (other.CompareTag("glassPoison"))
        {
            potionScript.glassIsWeak = true;
            // Brech funktion aktivieren
        }
    }



    /*void OnParticleCollision(GameObject collision)
    {
        if (collision.CompareTag("glassPoison"))
        {
            Destroy(this.gameObject);
            potionScript.glassIsWeak = true;
        }
    }*/
}