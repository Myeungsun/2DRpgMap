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
        // �Էµ� �ؽ�Ʈ�� ���̸� Ȯ���Ͽ� Join ��ư Ȱ��ȭ/��Ȱ��ȭ
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
