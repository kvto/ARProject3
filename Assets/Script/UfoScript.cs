using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoScript : MonoBehaviour
{
    public GameObject textLoveRed, textLoveBlack;
    // Start is called before the first frame update
    void Start()
    {
        textLoveRed.SetActive(false);
        textLoveBlack.SetActive(false);
            }

public void ShowText(){
     textLoveRed.SetActive(true);
        textLoveBlack.SetActive(true);
        
        Invoke("HideText", 3f);
} 
    // Update is called once per frame
    void HideText()
    {
        textLoveRed.SetActive(false);
        textLoveBlack.SetActive(false);
    }
}
