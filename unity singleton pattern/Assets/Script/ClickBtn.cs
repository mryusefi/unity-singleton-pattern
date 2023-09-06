using UnityEngine.UI;
using UnityEngine;
using System;

public class ClickBtn : MonoBehaviour
{
    [SerializeField] private Button start;


    void Start()
    {
        start.onClick.AddListener(StartClicking);
    }

    private void StartClicking()
    {
        //you can use like this
        AudioPlayers.instance.PlayClickSound();
    }
}
