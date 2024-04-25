using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered:"+other.gameObject.name);
    }
    private void OnTriggerExited(Collider other)
    {
        Debug.Log("Exited:" + other.gameObject.name);
    }
}
