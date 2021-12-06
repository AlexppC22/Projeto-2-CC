using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SearchingPlayerAnimaiton : MonoBehaviour
{
    public TextMeshProUGUI searchingPlayerText;



    void Start()
    {
        searchingPlayerText.text = "Searching Other Player";
        StartCoroutine(TextAnimation());

    }
    IEnumerator TextAnimation()
    {
        while (true)
        {
            
            searchingPlayerText.text = "Searching Other Player";
            yield return new WaitForSeconds(0.75f);
            searchingPlayerText.text = "Searching Other Player.";
            yield return new WaitForSeconds(0.75f);
            searchingPlayerText.text = "Searching Other Player..";
            yield return new WaitForSeconds(0.75f);
            searchingPlayerText.text = "Searching Other Player...";
            yield return new WaitForSeconds(0.75f);
        }
    

   
        
    
    }
 }
