using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class Gameplay : MonoBehaviour
{  
    public Character character;
    public TextMeshProUGUI _distanceText;

      private void SetDistanceUI(float distance)
    {
        _distanceText.text = distance.ToString();
    }

    public void Update()
    {
      SetDistanceUI(character.transform.position.z);
    }



}
