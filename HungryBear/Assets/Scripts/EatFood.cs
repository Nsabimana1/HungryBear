using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFood : MonoBehaviour
{
    public GameObject particles;
    public GameObject particles2;
    private ParticleSystem fps;
    private ParticleSystem pps;

    // Start is called before the first frame update
    void Start()
    {
        fps = particles.GetComponent<ParticleSystem>();
        pps = particles2.GetComponent<ParticleSystem>();
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
            GameManager.Instance.incScore(-1);

            fps.Play();
        }
        else
        {
            Debug.Log("ate a pancake. Yum!");
            GameManager.Instance.incScore(1);

            pps.Play();
        }

        Destroy(collision.gameObject);

    }
}
