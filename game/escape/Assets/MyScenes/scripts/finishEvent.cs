using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class finishEvent : MonoBehaviour
{
    Renderer rend;
    Text finishText;
    float time;

    void Start()
    {
       
        gameObject.GetComponent<Text>().enabled = false;

    }


    void Update()
    {
        time += Time.deltaTime;

    }

    public void finish()
    {
        string minutes = Mathf.Floor(time / 60).ToString("00");
        string seconds = (time % 60).ToString("00");
        gameObject.GetComponent<Text>().enabled = true;
       gameObject.GetComponent<Text>().text = "Gratulation\ndeine Zeit:\n"+ string.Format("{0}:{1}", minutes, seconds);
    }

}