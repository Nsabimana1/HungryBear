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

        

        // yield return new WaitForSeconds(2f);
        for (; ;)
        {
            //float screenX = -10;
            //float screenY = Random.Range(0, 10);
            //Vector2 pos = new Vector2(screenX, screenY);
            

            float rand = Random.Range(0f, 2f);
            if (rand > 1f)
            {
                Instantiate(bird);
            }
            else if(rand < 1f)
            {
                Instantiate(pancake);
            }
            else
            {
                Instantiate(bird);
                Instantiate(pancake);
            }

            // if (rand == 0)
            // {
            //     Instantiate(bird);
            // }
            // else
            // {
            //     Instantiate(pancake);
            // }
            // yield return new WaitForSeconds(Random.Range(2f, 4f));

            yield return new WaitForSeconds(Random.Range(1f, 2f));
        }
    }
}
