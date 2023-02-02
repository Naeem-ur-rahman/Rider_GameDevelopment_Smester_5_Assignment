using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Restart();

        }
        

    }
    public void LevelComplete(){
        Debug.Log("Level Won");

    }
    public void Restart(){
        SceneManger.LoadScene.LoadScene(SceneManger.GetActiveScene().name);

    }
    
}
