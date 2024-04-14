using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public Text textBox;
    public bool update;
    //public  SunshineMovement sunshine;
    public GameObject gameOverUI;
    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(update){
            //print("Game over");
            GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D other){
      if(other.gameObject.CompareTag("Player")){
        
            update=true;
        
      }
      
    }

    public void GameOver(){
        gameOverUI.SetActive(true);
        //textBox.text.ToString();
    }

    private void OnCollisionExit2D(Collision2D other){
      if(other.gameObject.CompareTag("Player")){
         update=false;
      }
      
    }

    public void GameRetry(){
        SceneManager.LoadScene("SampleScene");
        gameOverUI.SetActive(false);
    }
}
