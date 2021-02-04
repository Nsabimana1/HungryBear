using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TextMeshProUGUI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    private int score = 0;
    public TextMeshProUGUI textScore;

    private void Awake(){
        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    public void incScore() {
        this.score += 1;
        this.textScore.text = "Score: " + score;
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
