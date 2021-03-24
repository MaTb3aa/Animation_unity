using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class timer2 : MonoBehaviour
{
    //public string levelToload;
    private float minute = 2f;
    private float seconds = 59;
    private Text TimerSecond;
    // Start is called before the first frame update
    void Start()
    {
        TimerSecond = GetComponent<Text>();

    }

    float cnt = 0;
    // Update is called once per frame
    void FixedUpdate()
    {

        seconds -= Time.deltaTime;
        if (minute <= 0)
        {
            TimerSecond.color = new Color(255, 0, 0);
        }
        if (seconds <= 0)
        {
            if (minute <= 0)
            {
                SceneManager.LoadScene("Level2");
            }
            else
            {
                minute--;
                seconds = 59;
            }
        }
        int tmpSecond = Mathf.RoundToInt(seconds);
        TimerSecond.text = minute.ToString() + ":" + tmpSecond.ToString();


    }
   
}
