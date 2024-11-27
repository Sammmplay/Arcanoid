using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    [SerializeField]
    GameObject pantallaInfo;
    [SerializeField]
    GameObject canvasJuego;
    [SerializeField]
    GameObject canvasPausa;

    [SerializeField]
    MovimientoJugador movimientoJugador;
    [SerializeField]
    MovimientoPelota movimientoPelota;

    [SerializeField]
    TMP_Dropdown dropdown;
    [SerializeField]
    int calidad;

    float tiempoSinFuncionar = 0f;
    void Start()
    {
        pantallaI.SetActive(true);
        pantallaG.SetActive(false);
        pantallaP.SetActive(false);
        pantallaO.SetActive(false);
        pantallaInfo.SetActive(false);
        movimientoJugador.enabled = false;
        movimientoPelota.enabled = false;
        canvasJuego.SetActive(false);
        canvasPausa.SetActive(false);
        calidad = PlayerPrefs.GetInt("numeroDeCalidad", 3);
        dropdown.value = calidad;
        AjustarCalidad();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvasPausa.SetActive(true );
        }
    }

    public void StartButton()
    {
        pantallaI.SetActive(false);
        pantallaInfo.SetActive(true);
        canvasJuego.SetActive(true);
        LeanTween.scale(pantallaInfo, Vector3.one * 0.9f, 0.5f).setEase(animCurve).setOnComplete(() =>
        {
            LeanTween.scale(pantallaInfo, Vector3.one * 1f, 0.5f);
        });
    }

    public void ListoButton()
    {
        pantallaInfo.SetActive(false);
        canvasPausa.SetActive(false);
        //tiempoSinFuncionar += Time.deltaTime;
        //if (tiempoSinFuncionar>=5.0f)
        //{
            movimientoJugador.enabled = true;
            movimientoPelota.enabled=true;
        //}
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

    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroDeCalidad", dropdown.value);
        calidad=dropdown.value;
    }
    public void SubirVolumenButton()
    {

    }

    public void BajarVolumenButton()
    {

    }

    public void CalidadButton()
    {

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
        Debug.Log("Salir");
        Application.Quit();
    }

    public void PantallaDeInicioButton()
    {
        canvasPausa.SetActive(false);
        pantallaG.SetActive(false);
        pantallaP.SetActive(false);
        pantallaI.SetActive(true);
    }
    public void ReintentarButton()
    {
        pantallaG.SetActive(false);
        pantallaP.SetActive(false);
    }
}

