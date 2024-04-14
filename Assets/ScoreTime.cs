using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTime : MonoBehaviour
{
    public float timeS;
    public Text textBox;
    //public static event UnityAction TimerStart;
//    public static event UnityAction TimerStop;
  //  public static event UnityAction<float> TimerUpdate;

    //public static void OnTimerStart() => TimerStart?.Invoke();
    //public static void OnTimerStart() => TimerStart?.Invoke();
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeS.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeS +=Time.deltaTime;
        textBox.text=Mathf.Round(timeS).ToString();
    }
}
