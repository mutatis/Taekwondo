using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tempo : MonoBehaviour
{
    public static Tempo tempo;

    public Text text, round;

    float theStartTime = 120.0f;

    [HideInInspector]
    public float theTimer = 0.0f;

    int count = 1;

    bool showRemaining = false;

    bool troca;

    void Awake()
    {
        tempo = this;
    }

    void Start()
    {
        theStartTime = float.Parse(PlayerPrefs.GetString("Tempo"));
        theTimer = theStartTime;
    }

    void Update()
    {
        if(!showRemaining && Input.GetKeyDown(KeyCode.Space))
        {
            showRemaining = true;
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            showRemaining = false;
        }

        if (!showRemaining && theTimer >= 0)
        {
            theTimer -= Time.deltaTime;
        }

        if (theTimer <= 0)
        {
            theTimer = 0;
            troca = true;
        }

        if(troca)
        {
            if(count == 1)
            {
                theTimer = float.Parse(PlayerPrefs.GetString("TempoIntervalo"));
                count = 0;
                round.text = "Round " + count;
                troca = false;
            }
            else if(count == 0)
            {
                theTimer = float.Parse(PlayerPrefs.GetString("Tempo"));
                count = 2;
                round.text = "Round " + count;
                troca = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.G))
        {
            Debug.Log("Resetting");
            theTimer = theStartTime;
            showRemaining = false;
        }

        text.text = string.Format("{0:00}:{1:00}", (int)(theTimer / 60.0f), (int)(theTimer % 60.0f));
    }
}