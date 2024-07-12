using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private float inTimer;
    private string score;
    
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("GameBall"))
        {
            inTimer += Time.deltaTime;
            score = inTimer.ToString("F2"); // Shows upto 2 decimal places;
            scoreText.text = score;

            if (inTimer > 10f)
            {
                Debug.Log("10 seconds achieved!");
                EditorApplication.isPaused = true; //for pausing the editor
                //EditorApplication.isPlaying = false; //for exiting the editor
            }
        }
    }
}
