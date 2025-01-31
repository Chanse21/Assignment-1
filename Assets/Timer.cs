using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class Timer : MonoBehaviour
{
    //public TextMeshProGUI timerText;
    public TMP_Text text;
    public float timer = 5;
    public AudioSource audiosource;
    public AudioClip audioclip;
    public UnityEvent OnTimerElapse;
    private bool isElapsed = false;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            OnTimerElapse.Invoke();
        }
    }
}
