using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronController : MonoBehaviour
{
    List<string> appendedIngredients = new List<string>();
    List<string> expectedIngredients = new List<string> { "Tooth" };

    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;

        // wenn das gameobject der input vom Zauberstab ist, soll das checkObAlleZutatenImKesselSind() skript aufgerufen
        if (other.CompareTag("Projectile"))
        {
            //other.GetComponent<EnemyController>().CallYourFunctionHere();

            if(compareIngredients())
            {
                // Spawn Key
                //Destroy(this.gameObject);
                keyAppear();
            }
            else
            {
                // reset 
                // respawn all ingreds
                // make potion dark and an explosion
                appendedIngredients.Clear();
            }


        }
        // alles andere wird als zutat gezählt und zur liste hinzugefügt
        else if(expectedIngredients.Contains(other.gameObject.tag))
        {
            appendedIngredients.Add(other.gameObject.tag);
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);
        }
    }

    private bool compareIngredients()
    {
        //Destroy(this.gameObject); 
        bool containsAllIngredients = true;

        if (appendedIngredients.Count == expectedIngredients.Count)
        {
            foreach (string ingredTag in appendedIngredients)
            {
                if(!expectedIngredients.Contains(ingredTag))
                {
                    containsAllIngredients = false;
                }

            }
        }
        else
        {
            containsAllIngredients = false;
        }

        return containsAllIngredients;
    }

    private void keyAppear()
    {
        GameObject key = GameObject.Find("Key");
        key.transform.position = new Vector3(transform.position.x, 1.4f, transform.position.z);

    }
}
