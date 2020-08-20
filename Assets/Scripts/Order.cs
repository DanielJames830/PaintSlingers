using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Order : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Called");
        GetComponent<Image>().color = ColorEngine.GenerateNewColor();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Image>().color = ColorEngine.GenerateNewColor();
        }
    }
}
