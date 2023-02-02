
using System.Collections;  
using System.Collections.Generic; 
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = (player.position.x + 11).ToString("0");
    }
}
