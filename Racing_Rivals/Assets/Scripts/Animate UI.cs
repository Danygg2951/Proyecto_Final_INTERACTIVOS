using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateUI : MonoBehaviour
{
    public GameObject Logo;
    public GameObject Registro;
    public GameObject Iniciosesion;
    public GameObject Desarrollador;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(Logo.GetComponent<RectTransform>(), 96, 1.3f).setEase(LeanTweenType.easeOutBounce)
            .setDelay(0.5f);
        LeanTween.moveX(Registro.GetComponent<RectTransform>(), 1020, 1.8f).setEase(LeanTweenType.easeInOutCubic)
            .setDelay(0.6f);
        LeanTween.moveY(Iniciosesion.GetComponent<RectTransform>(), -360, 1.5f).setEase(LeanTweenType.easeInOutCubic)
            .setDelay(0.5f);
        LeanTween.moveX(Desarrollador.GetComponent<RectTransform>(), 1013, 1.9f).setEase(LeanTweenType.easeInOutCubic)
            .setDelay(0.8f); 
    }
}
