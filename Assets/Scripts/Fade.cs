using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public int index;

    public Image white;
    public Animator anim;

    public AudioSource FadeSource;
    public AudioClip transition;

    [Range(0.0f, 1.0f)]
    public float FadeVolume;

    private void OnTriggerEnter(Collider collision)
    {
       if (collision.tag == "Player")
        {
            collision.GetComponent<Rigidbody>().useGravity = false;
            FadeSource.PlayOneShot(transition, FadeVolume);
            StartCoroutine(Fading());
        }
    }

IEnumerator Fading()

    {
        Debug.Log("hello");
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => { return white.color.a == 1f; });
        SceneManager.LoadScene(index);
    }
}