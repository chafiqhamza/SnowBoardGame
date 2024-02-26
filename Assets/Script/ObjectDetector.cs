using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectDetector : MonoBehaviour
{
    [SerializeField] float delayTime = 1f;
    [SerializeField] ParticleSystem effectPart;
    [SerializeField] AudioClip SfxAudio;
    bool Soundoff = false;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Ground")&& !Soundoff)
        {
            Soundoff = true;
            FindObjectOfType<SnowMovement>().MovementStopped();
            effectPart.Play();
            
            GetComponent<AudioSource>().Play();

            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
