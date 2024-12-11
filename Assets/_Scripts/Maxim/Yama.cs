using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Yama : MonoBehaviour
{
    public TextMeshPro text;
    public static int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Product")
        {
            score++;
            Destroy(other.gameObject);
        }
    }
}
