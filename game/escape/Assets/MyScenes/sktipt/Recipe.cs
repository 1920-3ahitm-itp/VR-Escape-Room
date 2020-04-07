using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour
{
    List<GameObject> ingredients = new List<GameObject>();
    public GameObject ing1;
    public GameObject ing2;
    public GameObject ing3;

    // Start is called before the first frame update
    void Start()
    {
        ing1 = GameObject.Find("/ingredients/Ing1");
        ing2 = GameObject.Find("/ingredients/Ing2");
        ing3 = GameObject.Find("/ingredients/Ing3");
        ingredients.Add(ing1);
        ingredients.Add(ing2);
        ingredients.Add(ing3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
