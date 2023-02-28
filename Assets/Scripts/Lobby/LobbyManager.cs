using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour
{
    public Button GoGameScene;

    private const int GAMESCENE = 1;

    private void Awake()
    {
        GoGameScene.onClick.AddListener(OnClickedGoGameScene);
    }

    private void OnClickedGoGameScene()
    {
        SceneManager.LoadScene(GAMESCENE);
    }
}
