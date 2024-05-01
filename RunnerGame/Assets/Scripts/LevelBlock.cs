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
        EndPositionColiderSignal.onPlayerExitedEndPosition += DeleteSelf;
    }
    private void OnDisable()
    {
        EndPositionColiderSignal.onPlayerEnterEndPosition -= LitleNewBlock;
        EndPositionColiderSignal.onPlayerExitedEndPosition -= DeleteSelf;
    }

    private void LitleNewBlock()
    {
        var newLevelBlockCopy = Instantiate(LevelBlockPrefab[0]);
        newLevelBlockCopy.transform.position = endPosition.position;
    }
    private void DeleteSelf()
    {
        Destroy(gameObject);
    }

}
