using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float maxLifeTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3 (speed * Time.deltaTime, 0, 0);
        lifeTime += Time.deltaTime;
        if (lifeTime > maxLifeTime)
        {
            Destroy (this.gameObject);
        }
    }
}
