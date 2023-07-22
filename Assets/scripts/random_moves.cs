using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_moves : MonoBehaviour
{
    private int frames = 0;
    private int sign = -1;

    // Update is called once per frame
    void Update()
    {
        if (frames % 50 == 0 || frames == 1)
        {
            transform.position += new Vector3(Random.Range(0f, 1f) * sign, 0, 0);
            sign *= -1;
        }

       frames++;
    }
}
