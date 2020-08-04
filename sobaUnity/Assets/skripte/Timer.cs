using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Light svjetlo;

    public Canvas Interakcije;
    public Canvas Objekat;
    public Canvas Meni;

    public Text timerText;
    public Text vrijemeKraja;
    private float startTime;
    private bool finished = false;
    // Start is called before the first frame update
    void Start()
    {
        Meni.enabled = false;
        Interakcije.enabled = false;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finished) return;

        StartCoroutine(Test(Objekat, 3.0f));

        float t = Time.time - startTime;
        float min = ((int)t / 60);
        float sec = t % 60;
        if (min >= 5) svjetlo.intensity = 2;
        string minutes = min.ToString();
        string seconds = (t % 60).ToString("f1");
        string vrijeme = minutes + ":" + seconds;
        timerText.text = vrijeme;

        if (min == 0 && sec > 3)
        {
            Interakcije.enabled = true;
        }
        if (min == 0 && sec> 12) {

            Interakcije.enabled = false;

        }
        

        if (Input.GetKeyDown(KeyCode.M)) {
            Meni.enabled = true;
            vrijemeKraja.text = "Vrijeme: " + vrijeme;
            Finish();
        }


    }

    public void Finish() {
        finished = true;
        timerText.color = Color.red;
    }

    IEnumerator Test(Canvas p, float vrijemeCekanja)
    {
        yield return new WaitForSeconds(vrijemeCekanja);
        p.enabled = false;
        
    }
}
