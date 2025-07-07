using UnityEngine;

public class GameController : MonoBehaviour
{
    private int[] chapterPosition = new int[4]; // 플레이어를 이동시킬 챕터 위치를 저장해놓을 배열.
    private bool isStart = false; // 챕터가 시작하였는가 구분하기 위한 변수.

    private void Update()
    {
        GameStart(chapterPosition, 1);
    }
    public void GameStart(int[] chapterPosition, int chapter) // 챕터 배너에서 시작을 하기 위해 아무 키나 누르는 것을 감지하기 위한 함수.
    {
        if (!isStart)
        {
            if (Input.anyKey)
            {
                PlayerTransformChapter(chapterPosition, chapter);
                return;
            }
        }
        else
            return;
    }

    /// <summary>
    /// 챕터가 시작했을 때 유저를 챕터 위치로 이동시킬 함수
    /// </summary>
    /// <param name="chapter"></param>
    public void PlayerTransformChapter(int[] chapterTransposition, int chapter)
    {
        Debug.Log("클릭이나 키 입력이 감지됨.");
        return;
    }
}
