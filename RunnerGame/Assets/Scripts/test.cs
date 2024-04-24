using UnityEngine;

public class test : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered:" + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited:" + other.gameObject.name);
    }
}
