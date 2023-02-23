using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base1Script : MonoBehaviour
{
    public Material carouselLight1, carouselLight2;
    public GameObject light1, light2, light3, light4, light5, light6;
    // Start is called before the first frame update
    void Start()
    {
        light2On();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * -50);
    }

    void light1On(){
        light1.GetComponent<MeshRenderer>().material = carouselLight1;
        light6.GetComponent<MeshRenderer>().material = carouselLight2;

        Invoke("light2On", 0.2f);
    }

    void light2On(){
        light2.GetComponent<MeshRenderer>().material = carouselLight1;
        light1.GetComponent<MeshRenderer>().material = carouselLight2;

        Invoke("light3On", 0.2f);
    }

    void light3On(){
        light3.GetComponent<MeshRenderer>().material = carouselLight1;
        light2.GetComponent<MeshRenderer>().material = carouselLight2;

        Invoke("light4On", 0.2f);
    }

    void light4On(){
        light4.GetComponent<MeshRenderer>().material = carouselLight1;
        light3.GetComponent<MeshRenderer>().material = carouselLight2;

        Invoke("light5On", 0.2f);
    }

    void light5On(){
        light5.GetComponent<MeshRenderer>().material = carouselLight1;
        light4.GetComponent<MeshRenderer>().material = carouselLight2;

        Invoke("light6On", 0.2f);
    }

    void light6On(){
        light6.GetComponent<MeshRenderer>().material = carouselLight1;
        light5.GetComponent<MeshRenderer>().material = carouselLight2;

        Invoke("light1On", 0.2f);
    }
}