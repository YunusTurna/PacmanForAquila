using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI highScoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        highScoreCounter.text = "HighScore:" + PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Pellets.sayac > PlayerPrefs.GetInt("HighScore" , Pellets.highScore))
        {
            PlayerPrefs.SetInt("HighScore" , Pellets.highScore +1);
            
        }
}
}
