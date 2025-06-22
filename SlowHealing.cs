using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class SlowHealing : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.ChangeHealth(+1);
        }
    }
}