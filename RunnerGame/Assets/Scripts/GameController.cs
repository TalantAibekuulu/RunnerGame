using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Settings")]
    public int BlocksCount;

    [Header("Object")]
    public LevelBlock[] LevelBlockPrefabs;
    public Character characterPrefabs;

    private List<LevelBlock> currentBlock = new();
   private Character characterCopy = new();
    private void Start()
    {
        for (int index = 0; index < BlocksCount; index++)
        {
            SpawnBlock();
        }
      

        SpawnBlock();
        SpawnCharacter();
    }
    private void SpawnBlock()
    {
        LevelBlock levelBlockPrefab = LevelBlockPrefabs[0];
        LevelBlock levelBlockCopy = Instantiate(levelBlockPrefab);

        if (currentBlock.Count > 0)
        {
            levelBlockCopy.transform.position = currentBlock.Last().endPosition.position;
        }
        levelBlockCopy.EndPositionColiderSignal.onPlayerEnterEndPosition += SpawnBlock;

        currentBlock.Add(levelBlockCopy);

    }
    private void SpawnCharacter()
    {
         characterCopy = Instantiate(characterPrefabs);
       
        characterCopy.OnCollidedWithWall += StopGame;
    }
      
    private void StopGame()
    {
        characterCopy.Stop();
    }
}
