
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownController : MonoBehaviour
{

    public int countdownTime;
    public float bangTime = 0;

    public TMP_Text countdownDisplay;
    public TMP_Text bangText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            
            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.gameObject.SetActive(false);


        if (countdownTime == 0)
        {
            
            yield return new WaitForSeconds(Random.Range(0.1f, 5f));
            bangTime = Time.time;
            bangText.gameObject.SetActive(true);
            bangText.text = "Bang";
            yield return new WaitForSeconds(1f);
            bangText.gameObject.SetActive(false);

        }
        

        //GameController.instance.BeginGame();

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
    }
}
