using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Settings")]
    public int BlocksCount;

    [Header("Object")]
    [SerializeField] private LevelBlock[] LevelBlockPrefabs;
    [SerializeField] private Character characterPrefabs;
    [SerializeField] private LostUI _looseUIPrefab;

    private List<LevelBlock> _currentBlocks = new();
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

        if (_currentBlocks.Count > 0)
        {
            levelBlockCopy.transform.position = _currentBlocks.Last().endPosition.position;
        }
        levelBlockCopy.EndPositionColiderSignal.onPlayerEnterEndPosition += SpawnBlock;

        _currentBlocks.Add(levelBlockCopy);

    }
    private void SpawnCharacter()
    {
        characterCopy = Instantiate(characterPrefabs);

        characterCopy.OnCollidedWithWall += StopGame;
    }

    private void StopGame()
    {
        characterCopy.Stop();

        LostUI loseUICopy = Instantiate(_looseUIPrefab);
        loseUICopy.onRestartButtonClicked += Restart_RespawnScene;
    }
    private void Restart_RespawnScene()
    {
        SceneManager.LoadScene(0);
    }

    private void Restart_RespawnAll()
    {
        Destroy(characterCopy.gameObject);
        LevelBlock currentBlock = null;
        for (int i = 0; i < _currentBlocks.Count; i++)
        {
            currentBlock = _currentBlocks[i];
            Destroy(currentBlock.gameObject);
        }


    }

}
