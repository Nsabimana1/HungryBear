using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearEatFood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision2D) 
    {
        Debug.Log("Colliding with food");
        Destroy(collision2D.gameObject);
        GameManager.Instance.incScore();
    }
}
