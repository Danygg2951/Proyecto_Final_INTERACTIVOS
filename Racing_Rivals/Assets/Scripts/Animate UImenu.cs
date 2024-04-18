using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateUImenu : MonoBehaviour
{

    public GameObject botones;
    public GameObject botones1;
    public GameObject botones2;
    public GameObject botones3;
    public GameObject botones4;
    public GameObject Logo;
    public GameObject tutorial;
    public GameObject jugar;
    public GameObject tienda;
    public GameObject ranking;
    public GameObject usuario;
    public GameObject casco;
    public GameObject llanta;


    public void ActivaBotones()
    {
        LeanTween.moveX(botones.GetComponent<RectTransform>(), -484f, 3f)
            .setEase(LeanTweenType.easeInOutElastic);
    }
    public void ActivaBotones1()
    {
        LeanTween.moveX(botones1.GetComponent<RectTransform>(), -484f, 3f)
            .setEase(LeanTweenType.easeInOutElastic);
    }
    public void ActivaBotones2()
    { 
        LeanTween.moveX(botones2.GetComponent<RectTransform>(), -484f, 3f)
           .setEase(LeanTweenType.easeInOutElastic);
    }
    public void ActivaBotones3()
    {
        LeanTween.moveX(botones3.GetComponent<RectTransform>(), -484f, 3f)
           .setEase(LeanTweenType.easeInOutElastic);
    }
    public void ActivaBotones4()
    { 
        LeanTween.moveX(botones4.GetComponent<RectTransform>(), -484f, 3f)
           .setEase(LeanTweenType.easeInOutElastic);
    }
    private void Start()
    {
        LeanTween.moveY(Logo.GetComponent<RectTransform>(), 370, 1.3f).setEase(LeanTweenType.easeOutBounce)
            .setDelay(0.5f);
        LeanTween.moveX(tutorial.GetComponent<RectTransform>(), 619, 1.3f).setEase(LeanTweenType.easeOutBounce)
           .setDelay(0.5f); 
        LeanTween.moveX(tienda.GetComponent<RectTransform>(), -874, 1.3f).setEase(LeanTweenType.easeOutBounce)
           .setDelay(0.5f);
        LeanTween.moveX(ranking.GetComponent<RectTransform>(), -482, 1.3f).setEase(LeanTweenType.easeOutBounce)
           .setDelay(0.5f);
        LeanTween.moveY(jugar.GetComponent<RectTransform>(), -309, 1.3f).setEase(LeanTweenType.easeOutBounce)
          .setDelay(0.5f);
        LeanTween.moveX(usuario.GetComponent<RectTransform>(), 977, 1.3f).setEase(LeanTweenType.easeOutBounce)
          .setDelay(0.5f);
        LeanTween.moveY(casco.GetComponent<RectTransform>(), 457, 1.3f).setEase(LeanTweenType.easeOutBounce)
          .setDelay(0.5f);
        LeanTween.moveY(llanta.GetComponent<RectTransform>(), 442, 1.3f).setEase(LeanTweenType.easeOutBounce)
          .setDelay(0.5f);

    }
}