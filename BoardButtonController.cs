using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class BoardButtonController : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private Image player;
    [SerializeField] private Image PC;
    [SerializeField] private GameObject pause;

    private bool isPause = false;
    private Color activeColor = new Color(255f / 255f, 0f, 150f / 255f, 100f / 255f);
    private Color inactiveColor = new Color(255f / 255f, 0f, 150f / 255f, 20f / 255f);

    void Start()
    {
        PC.color = activeColor;
        player.color = inactiveColor;
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) GamePause();
    }
    public void btn0()
    {
        player.color = activeColor;
        PC.color = inactiveColor;
        Debug.Log("´­·¶´Ù");
    }
    public void GamePause()
    {
        isPause = !isPause;
        pause.SetActive(isPause);
    }

    public void GetBtn()
    {
        GameObject tempBtn = EventSystem.current.currentSelectedGameObject;

        Debug.Log(tempBtn);
    }
}
