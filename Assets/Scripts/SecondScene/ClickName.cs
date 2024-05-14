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
                    // �÷��̾��� �г����� ����
                    PlayerPrefs.SetString("PlayerName", playerName);

                    // ���� ����
                    SceneManager.LoadScene("SampleScene");
            }
            else
            {
                Debug.Log("2 ���ڿ��� 12 ���� ���� �Է��ϼ���.");
                return;
            }
        }
}
