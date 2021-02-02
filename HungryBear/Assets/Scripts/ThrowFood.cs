using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFood : MonoBehaviour
{
    public GameObject bird;
    public GameObject pancake;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DropFood");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DropFood()
    {
        yield return new WaitForSeconds(2f);
        for (; ;)
        {
            int rand = Random.Range(0, 2);
            if (rand == 0)
            {
                Instantiate(bird);
            }
            else
            {
                Instantiate(pancake);
            }
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }
}
