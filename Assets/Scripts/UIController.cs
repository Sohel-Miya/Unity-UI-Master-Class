using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button playBtn;
    public Button facebookBtn;
    public Button leaderBoardBtn;
    public Button likeBtn;
    public Button shopBtn;
    public Button settingsBtn;


    public void OnButtonClicked(string message)
    {
        Debug.Log(message);
    }
}
