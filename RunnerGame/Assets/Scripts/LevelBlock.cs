using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBlock : MonoBehaviour
{
    public Transform startPosition;
    public Transform endPosition;

    public LevelBlock[] LevelBlockPrefab;

    public EndPositionColiderSignal EndPositionColiderSignal;
    private void OnEnable()
    {
        EndPositionColiderSignal.onPlayerEnterEndPosition += LitleNewBlock;
        EndPositionColiderSignal.onPlayerExitedEndPosition +=Destroy;
    }
    private void LitleNewBlock()
    {
        var newLevelBlockCopy = Instantiate(LevelBlockPrefab[0]);
        newLevelBlockCopy.transform.position = endPosition.position;
    }
    private void Destroy()
    {

    }

}
