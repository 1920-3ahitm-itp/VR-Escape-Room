using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CauldronController : MonoBehaviour
{
    List<string> appendedIngredients = new List<string>();
    List<string> expectedIngredients = new List<string> { "Tooth", "Eye", "Flower", "Sharingan", "Spanferkel", "Watercrystal", "Firecrystal" };

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
                brewAppear();
            }
            else
            {
                // reset 
                // respawn all ingreds
                // make potion dark and an explosion
                //appendedIngredients.Clear();
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

        if (appendedIngredients.Count != expectedIngredients.Count)
        {
            containsAllIngredients = false;
        }
        else
        {
            foreach (string ingredTag in expectedIngredients)
            {
                if (appendedIngredients.Contains(ingredTag) == false)
                {
                    Destroy(this.gameObject);
                    containsAllIngredients = false;
                }

            }

        }
        
        return containsAllIngredients;
        

        //return appendedIngredients.SequenceEqual(expectedIngredients);
    }

    private void brewAppear()
    {
        GameObject key = GameObject.Find("weakGlassBrew");
        key.transform.position = new Vector3(transform.position.x, 1.4f, transform.position.z);

    }
}
