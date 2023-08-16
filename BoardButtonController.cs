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
    Image btnImage;
    private GameObject btns;

    GameManager gm;

    private bool isPause = false;
    private Color activeColor = new Color(255f / 255f, 0f, 150f / 255f, 100f / 255f);
    private Color inactiveColor = new Color(255f / 255f, 0f, 150f / 255f, 20f / 255f);

    void Start()
    {
        btns = GameObject.Find("BtnGroup").gameObject;
        PC.color = activeColor;
        player.color = inactiveColor;
        pause.SetActive(false);
        gm = GetComponent<GameManager>();
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
        gm.isPause = !gm.isPause;
    }

    public void GetBtn()
    {
        GameObject tempBtn = EventSystem.current.currentSelectedGameObject;
        Image image = tempBtn.transform.GetChild(0).GetComponent<Image>();
        image.sprite = Resources.Load<Sprite>("x") as Sprite;
        image.color = new Color(1, 1, 1, 1f);
        
        Debug.Log(image);
    }
    public void Restart()
    {
        GamePause();
        ResetBtn();
    }

    public void ResetBtn()
    {
        int btnLength = btns.transform.childCount;
        Color newColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0, 2), 100f / 255f);
        for (int i=0;i<btnLength;i++)
        {
            GameObject tempBtns = btns.transform.GetChild(i).gameObject;
            btnImage = tempBtns.GetComponent<Image>();
            
            btnImage.color = newColor;
        }
    }
}
