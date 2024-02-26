using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    [SerializeField] float delayTime = 0.5f;
    [SerializeField] ParticleSystem effectparticle;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            effectparticle.Play();
            GetComponent<AudioSource>().Play();
            Invoke("Reload", delayTime);
            
        }
    }

    void Reload()
    {
        SceneManager.LoadScene(0);
    }
}
