using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traile : MonoBehaviour
{
    [SerializeField] ParticleSystem ParticleSystem;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ParticleSystem.Play();
            Debug.Log("collision");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ParticleSystem.Stop();
            Debug.Log("no collision");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
