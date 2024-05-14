using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickName : MonoBehaviour
{
        public InputField playerNameInput;
        public string playerName = null;

    public void StartGame()
        {
            if (!string.IsNullOrEmpty(playerName) && playerName.Length >= 2 && playerName.Length <= 10)
            {
                    // 플레이어의 닉네임을 저장
                    PlayerPrefs.SetString("PlayerName", playerName);

                    // 게임 시작
                    SceneManager.LoadScene("SampleScene");
            }
            else
            {
                Debug.Log("2 글자에서 12 글자 사이 입력하세요.");
                return;
            }
        }
}
