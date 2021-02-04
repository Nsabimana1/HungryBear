using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement: MonoBehaviour
{

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        int currentSpeed = GameManager.Instance.foodSpeed;
        rb2d.AddForce(transform.right * currentSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
     if (transform.position.x > 10)
        {
            Destroy(gameObject);
            if (!gameObject.CompareTag("Bird"))
            {
                Debug.Log("You missed a pancake, loser.");
                GameManager.Instance.incScore(-1);
            }
        }   
    }
}
