using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScript : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaI;
    [SerializeField]
    GameObject pantallaG;
    [SerializeField]
    GameObject pantallaP;
    [SerializeField]
    GameObject pantallaO;
    [SerializeField]
    LeanTweenType animCurve;

    void Start()
    {
        pantallaI.SetActive(true);
        pantallaG.SetActive(false);
        pantallaP.SetActive(false);
        pantallaO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        pantallaI.SetActive(false);
    }

    public void OptionButton()
    {

        LeanTween.moveLocalX(pantallaI, -1920f, 1f).setOnComplete(() =>
        {
            pantallaI.SetActive(false);
        });
        pantallaO.SetActive(true);
        LeanTween.moveLocalX(pantallaO, 0, 1f);
    }

    public void ReturnButton()
    {
        LeanTween.moveLocalX(pantallaO, 1920, 1f).setOnComplete(() =>
        {
            pantallaO.SetActive(false);
        });
        pantallaI.SetActive(true);
        LeanTween.moveLocalX(pantallaI, 0, 1f);
    }

    public void SalirButton()
    {
        Application.Quit();
        Debug.Log("Ha salido del juego");
    }
}
