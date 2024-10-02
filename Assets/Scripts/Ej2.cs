using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        for (int i = 10; i >= 0; i--)
        {
            Debug.Log(i);
            yield return new WaitForSeconds(1);
        }
    }
}
