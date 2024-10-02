using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4 : MonoBehaviour
{
    public GameObject objective;
    public Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CambiaTamanio());
    }
    
    IEnumerator CambiaTamanio()
    {
        while (true)
        {
           objective.transform.localScale += scaleChange;
           yield return new WaitForSeconds(1);
           objective.transform.localScale -= scaleChange;
           yield return new WaitForSeconds(1);
        }
    }
}
