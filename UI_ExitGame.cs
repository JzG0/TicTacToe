using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_ExitGame : MonoBehaviour
{
    public void MainToTitle()
    {
        Debug.Log("타이틀로 이동합니다...");
        SceneManager.LoadScene("TitleScene");
    }
}