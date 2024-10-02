using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3 : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnearEnemigosR());
    }

    IEnumerator SpawnearEnemigosR()
    {
        while (true)
        {
            int randomPosX = Random.Range(0, 5);
            int randomPosY = Random.Range(0, 11);
            Vector2 randomPos = new Vector2(randomPosX, randomPosY);
            Instantiate (enemy,randomPos, enemy.transform.rotation);
            yield return new WaitForSeconds(3);
        }
    }
}
