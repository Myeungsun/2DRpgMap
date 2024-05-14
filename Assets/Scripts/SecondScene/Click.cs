using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public InputField playerNameInput;
    public Button joinButton;

    private void Start()
    {
       //joinButton.interactable = false;
    }
     
    public void SceneChange()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void CheckInput()
    {
        // 입력된 텍스트의 길이를 확인하여 Join 버튼 활성화/비활성화
        if (playerNameInput.text.Length >= 2 && playerNameInput.text.Length <= 10)
        {
            joinButton.interactable = true;
        }
        else
        {
            joinButton.interactable = false;
        }
    }
}
