using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_ExitGame : MonoBehaviour
{
    public void MainToTitle()
    {
        Debug.Log("Ÿ��Ʋ�� �̵��մϴ�...");
        SceneManager.LoadScene("TitleScene");
    }
}