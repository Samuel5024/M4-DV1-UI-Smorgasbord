using UnityEngine;

public class HideAfterDelay : MonoBehaviour
{
    public float delayInSeconds = 5f;
    public float fadeRate = 0.25f;

    private CanvasGroup canvasGroup;

    // when to start hididng the canvas
    private float startTimer;

    // calculates change in canvas' alpha value over time 
    private float fadeoutTimer;

    void OnEnable()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1f;

        // initialize the startTimer
        startTimer = Time.time + delayInSeconds;
        fadeoutTimer = fadeRate;
    }
    void Update()
    {
        // time to fade out?
        if(Time.time >= startTimer)
        {
            fadeoutTimer -= Time.deltaTime;

            // fade out complete?
            if(fadeoutTimer <= 0)
            {
                gameObject.SetActive(false);
            }
            else
            {
                // reduce the alpha value
                canvasGroup.alpha = fadeoutTimer / fadeRate;
            }
        }
    }
}
