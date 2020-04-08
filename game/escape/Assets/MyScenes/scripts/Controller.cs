using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
        //if (other.CompareTag("Enemy"))
        if (other.gameObject.name == "PinkMissile")
        {
            //other.GetComponent<EnemyController>().CallYourFunctionHere();

            appendedIngredients.Clear();
        }
        // alles andere wird als zutat gezählt und zur liste hinzugefügt
        else
        {
            appendedIngredients.Add(other.gameObject);
        }
    }
}
