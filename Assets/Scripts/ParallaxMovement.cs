using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ParallaxMovement : MonoBehaviour
{
    public float _paralaxSpeed;

    void Update()
    {
        float xPosition = transform.position.x;
        if (xPosition > ParalaxManagement.Instance.GetParalaxPivot().position.x*2)
        {
            transform.position = new Vector3(xPosition - _paralaxSpeed * ParalaxManagement.Instance.GetSpeedMultiplier() * Time.deltaTime, transform.position.y, transform.position.z);

        }
        else
        {
            transform.position = new Vector3(transform.position.x + (29.22f * 2), transform.position.y, transform.position.z);
        }
    }
}
