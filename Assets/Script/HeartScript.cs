using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class HeartScript : MonoBehaviour
{
    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent(); 
    public GameObject heart, ufo, clickMeRed, clickMeBlack; 
    // Start is called before the first frame update
    void Start()
    {
        definedButton = this.gameObject;
        heart.SetActive(true);
        ufo.SetActive(false);
        clickMeBlack.SetActive(true);
        clickMeRed.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, 100f * Time.deltaTime);
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;
       if (Input.GetMouseButtonDown(0))         {
             if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)  {          
     Debug.Log("Button Clicked");     
        heart.SetActive(false); 
        ufo.SetActive(true);    
        clickMeBlack.SetActive(false);
        clickMeRed.SetActive(false); 

        Invoke("ResetHeart", 8f);
           }       
 }    
    }
    void ResetHeart(){
        heart.SetActive(true);
        ufo.SetActive(false);
        clickMeBlack.SetActive(true);
        clickMeRed.SetActive(true);
    }
}
