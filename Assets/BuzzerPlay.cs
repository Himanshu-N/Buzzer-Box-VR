using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzerPlay : MonoBehaviour
{
    [SerializeField] private AudioSource buzzerAudio;
    private int currentCollider = 0;
    private bool isPlaying = false;
    // to resolve the issue : if the ball is colliding with 2 objects and exits one then the sound would pause.

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameBall"))
        {
            currentCollider++;
            CheckAudioState();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameBall"))
        {
            currentCollider--;
            CheckAudioState();
        }
    }

    private void CheckAudioState()
    {
        if (currentCollider > 0 && !isPlaying)
        {
            buzzerAudio.Play();
            isPlaying = true;
        }
        else if (currentCollider == 0 && isPlaying)
        {
            buzzerAudio.Pause();
            isPlaying = false;
        }
    }
}
