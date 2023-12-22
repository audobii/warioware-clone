using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float maxTime = 5.0f;
    [SerializeField] GameObject timeTextObj;
    TextMeshProUGUI timeText;
    public float currTime;

    void Start()
    {
        currTime = maxTime;
        timeText = timeTextObj.GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        if (currTime < 0) currTime = 0.0f;
        timeText.text = currTime.ToString("F1");
        currTime -= Time.deltaTime;
    }
}
