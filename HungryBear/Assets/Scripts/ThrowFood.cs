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

        for (; ;)
        {

            GameObject go1;
            GameObject go2 = Instantiate(bird);

            float rand = Random.Range(0f, 2f);
            if (rand > 1f)
            {
                go1 = Instantiate(bird);
            }
            else if(rand < 1f)
            {
                go1 = Instantiate(pancake);
            }
            else
            {
                go1 = Instantiate(pancake);
                go2 = Instantiate(pancake);
            }

            go1.transform.position = new Vector2(go1.transform.position.x, Random.Range(-4.9f, 5f));
            go2.transform.position = new Vector2(go2.transform.position.x, Random.Range(-4.9f, 5f));



            yield return new WaitForSeconds(Random.Range(1f, 2f));
        }
    }
}
