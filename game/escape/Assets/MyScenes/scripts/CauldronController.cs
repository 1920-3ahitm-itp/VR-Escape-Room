using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronController : MonoBehaviour
{
    List<GameObject> appendedIngredients = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;

        // wenn das gameobject der input vom Zauberstab ist, soll das checkObAlleZutatenImKesselSind() skript aufgerufen
        if (other.CompareTag("Projectile"))
        {
            //other.GetComponent<EnemyController>().CallYourFunctionHere();

            compareIngredients();
            appendedIngredients.Clear();
        }
        // alles andere wird als zutat gezählt und zur liste hinzugefügt
        else
        {
            appendedIngredients.Add(other);
            //Destroy(this.gameObject);
            Destroy(other);
        }
    }

    private void compareIngredients()
    {
        //Destroy(this.gameObject);    
    }
}
