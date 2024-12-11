using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BankomatButton : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject yama;
    public int collectedScores = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        yama.GetComponent<Yama>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = collectedScores.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            collectedScores += Yama.score;
            Yama.score = 0;
        }
    }
}
