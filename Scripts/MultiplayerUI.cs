using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;

public class MultiplayerUI : MonoBehaviour
{
    [SerializeField] Button hostBtn, joinBtn;

    void Awake()
    {
        AssignInputs();
    }

    void AssignInputs()
    {
        hostBtn.onClick.AddListener( delegate { NetworkManager.Singleton.StartHost(); } );
        joinBtn.onClick.AddListener( delegate { NetworkManager.Singleton.StartClient(); } );
    }
}
