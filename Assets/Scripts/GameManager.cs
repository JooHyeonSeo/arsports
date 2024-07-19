using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject soccerInfo;
    public GameObject baseballInfo;
    public GameObject basketballInfo;
    public GameObject badminton;
    private void Start()
    {
        soccerInfo.SetActive(false);
        baseballInfo.SetActive(false);
        basketballInfo.SetActive(false);
    }
    

    public void ToggleSoccerInfo()
    {

        soccerInfo.SetActive(!soccerInfo.activeSelf);
        baseballInfo.SetActive(false);
        basketballInfo.SetActive(false);

    }

    public void ToggleBaseballInfo()
    {
        baseballInfo.SetActive(!baseballInfo.activeSelf);
        soccerInfo.SetActive(false);
        basketballInfo.SetActive(false);
        badminton.SetActive(false);

    }

    public void ToggleBasketballInfo()
    {
        basketballInfo.SetActive(!basketballInfo.activeSelf);
        soccerInfo.SetActive(false);
        baseballInfo.SetActive(false);
        badminton.SetActive(false);
    }

    public void ToggleBadmintonInfo()
    {
        badminton.SetActive(!badminton.activeSelf);
        soccerInfo.SetActive(false);
        baseballInfo.SetActive(false);
        basketballInfo.SetActive(false);
    }
}
