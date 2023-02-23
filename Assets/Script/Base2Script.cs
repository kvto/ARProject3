using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base2Script : MonoBehaviour
{
    public GameObject horse1, horse2, horse3, horse4, horse5, horse6;
    float speed1 = 3f;
    float speed2 = 2.5f;
    float height = 0.35f;
    // Start is called before the first frame update
    void Start()
    {
        StartFirst6();
        Invoke("StartSecond6", 0.3f);
    }

    void StartFirst6(){
        Horse1Up();
        Horse3Up();
        Horse5Up();
    }

    void StartSecond6(){
        Horse2Up();
        Horse4Up();
        Horse6Up();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 50);
    }

    void Horse1Up(){
        float newY = Mathf.Sin(Time.time * speed1);
        horse1.transform.Translate(new Vector3(0, newY, 0) * Time.deltaTime * height);
    }
    void Horse2Up(){
        float newY = Mathf.Sin(Time.time * speed2);
        horse2.transform.Translate(new Vector3(0, newY, 0) * Time.deltaTime * height);
    }
    void Horse3Up(){
        float newY = Mathf.Sin(Time.time * speed1);
        horse3.transform.Translate(new Vector3(0, newY, 0) * Time.deltaTime * height);
    }
     void Horse4Up(){
        float newY = Mathf.Sin(Time.time * speed2);
        horse4.transform.Translate(new Vector3(0, newY, 0) * Time.deltaTime * height);
    }
    void Horse5Up(){
        float newY = Mathf.Sin(Time.time * speed1);
        horse5.transform.Translate(new Vector3(0, newY, 0) * Time.deltaTime * height);
    }
    void Horse6Up(){
        float newY = Mathf.Sin(Time.time * speed2);
        horse6.transform.Translate(new Vector3(0, newY, 0) * Time.deltaTime * height);
    }
}
