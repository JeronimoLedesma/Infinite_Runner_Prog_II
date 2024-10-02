using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    int tiempodeEspera = 2;
    public float distancia;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoverObjecto());
    }

    IEnumerator MoverObjecto()
    {
        while (true)
        {
            Vector3 arriba = transform.position + Vector3.up * distancia;
            Vector3 abajo = transform.position;
            while (transform.position != arriba)
            {
                transform.position = Vector3.MoveTowards(transform.position, arriba, speed * Time.deltaTime);
                yield return null;
            }
            yield return new WaitForSeconds(tiempodeEspera);
            while (transform.position != abajo)
            {
                transform.position = Vector3.MoveTowards(transform.position, abajo, speed * Time.deltaTime);
                yield return null;
            }
            yield return new WaitForSeconds(tiempodeEspera);
        }

    }
}
