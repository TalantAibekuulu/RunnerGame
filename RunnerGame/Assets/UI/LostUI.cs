using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class LostUI : MonoBehaviour
{ public Action onRestartButtonClicked;

    [SerializeField] private Button _restartButton;

    private void OnEnable()
    {
         _restartButton.onClick.AddListener(SendRestartSignal);
    }
    private void OnDisable()
    {
        _restartButton.onClick.RemoveListener(SendRestartSignal);
    }
    private void SendRestartSignal()
    {
    onRestartButtonClicked?.Invoke();
  }
}

