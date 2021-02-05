using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TextMeshProUGUI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    private int score = 0;
    public int foodSpeed = 300;
    public TextMeshProUGUI textScore;
    public int highScore; 

    private void Awake(){
        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    public void incScore(int ds) {
        this.score += ds;
      
        if((this.score % 10 == 0) && (this.score > 0) && (score > highScore))
        {
            highScore = score;
            incFoodSpeed();
            Debug.Log("food speed: " + foodSpeed);
        }
        this.textScore.text = "Score: " + score;
    }

    public void incFoodSpeed() {
        double speed =this.foodSpeed * 1.2;
        int returnspeed = (int)speed;
        this.foodSpeed = returnspeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.textScore.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
