using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{

    public TMP_InputField inputPlayerName;

    private string playerName;

    public void StartNew()
    {
        playerName = inputPlayerName.text;
        PlayerInfo.instance.playerName = playerName;
        SceneManager.LoadScene(1);
    }
}
