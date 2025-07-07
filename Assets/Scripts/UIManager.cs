using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // 싱글톤 선언
    private static UIManager _instance = new UIManager();
    public static UIManager instance => _instance;

    [Header("UI에 메세지 출력할 오브젝트")]
    [SerializeField] private TMP_Text MessageText;

    [Header("챕터 배너")]
    [SerializeField] private Image bannerImage;
    public Sprite[] changeBannerArr = new Sprite[4];

    
    /// <summary>
    /// 화면에 송출할 UI 메세지 함수.
    /// </summary>
    /// <param name="message"></param>
    /// <param name="showTime"></param>
    public void ShowMessage(string message, float showTime)
    {
        MessageText.text = message;
        showTime -= Time.deltaTime;
        if (showTime <= 0)
        {
            MessageText = null;
        }
        return;
    }

    public void BannerChange(Sprite[] chageBannerArr, int chapter)
    {
        bannerImage.sprite = chageBannerArr[chapter];
    }
}
