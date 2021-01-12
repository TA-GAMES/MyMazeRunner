using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    [SerializeField] float startingTime = 90f;
    Text timerText;
    bool startCountDown = false;
    public GameObject outOfTimePanel;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            startCountDown = true;
        }
        if (startCountDown)
        {
            currentTime -= 1 * Time.deltaTime;
            timerText.text = "Time : " + currentTime.ToString("0");
        }
        if (currentTime <= 0)
        {
            PlayerMoveControl.ready = false;
            outOfTimePanel.SetActive(true);
            OpenGateToNextLevel.open = false;
        }

    }
}
