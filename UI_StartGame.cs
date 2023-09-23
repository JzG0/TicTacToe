using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_StartGame : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("게임을 시작합니다...");
        SceneManager.LoadScene("GameScene");
    }
}
