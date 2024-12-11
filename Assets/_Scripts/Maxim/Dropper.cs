using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public GameObject product;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CreateProduct", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateProduct()
    {
        Instantiate(product, transform.position, Quaternion.identity);
        Invoke("CreateProduct", 2f);
    }
}
