using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_StartGame : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("������ �����մϴ�...");
        SceneManager.LoadScene("GameScene");
    }
}
