using System;
using UnityEngine;

public class EndPositionColiderSignal : MonoBehaviour
{
    public Action onPlayerEnterEndPosition;
    public Action onPlayerExitedEndPosition;


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Character>() !=  null)
        {
            onPlayerEnterEndPosition?.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Character>() != null)
        {
            onPlayerEnterEndPosition.Invoke();
        }

    }

    private void OnEnable()
    {

    }

}
