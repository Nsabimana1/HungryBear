using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bird"))
        {
            Debug.Log("ate a bird. Yuck.");
            GameManager.Instance.DecScore(1);
        }
        else
        {
            Debug.Log("ate a pancake. Yum!");
            GameManager.Instance.IncScore(1);
        }

        Destroy(collision.gameObject);

    }
}
