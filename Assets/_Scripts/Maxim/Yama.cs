using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Yama : MonoBehaviour
{
    public TextMeshPro text;
    public static int bankedScore = 0;
    private GameObject product;
    public Transform textSpawner;
    public GameObject IncomingText;
    
    // Start is called before the first frame update
    void Start()
    {
        text.text = bankedScore.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = bankedScore.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Product")
        {
            bankedScore += other.GetComponent<ProductParameters>().numberScore;
            IncomingText.GetComponentInChildren<TMP_Text>().text = other.GetComponent<ProductParameters>().numberScore.ToString();
            Destroy(other.gameObject);
            var _object = Instantiate(IncomingText, textSpawner);
            Destroy(_object.gameObject, 2f);
        }
    }
}
