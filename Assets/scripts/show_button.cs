using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_button : MonoBehaviour
{
    public GameObject button;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.name == "crate")
        {
            button.SetActive(true);
        }
    }
}
