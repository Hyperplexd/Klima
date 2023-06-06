using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PopUp : MonoBehaviour
{
    public Animator popUpAnim, anim;
    public Slider timeSlider;

    public GameObject popUpObj;

    //Percentage
    public float target1, target2;
    public float smoothStep;
    float value1 = 0, value2 = 0;

    public Image img1, img2;
    public TMP_Text percentage1, percentage2;
    //Percentage

    bool appeared;
    [HideInInspector] public bool clicked;

    void OnEnable()
    {
        appeared = false;
        StartCoroutine(waitUntilAppear());
        StartCoroutine(AnimateSliderOverTime(6));
    }

    public void ClickedPopUp()
    {
        clicked = true;
        StopCoroutine(AnimateSliderOverTime(6));
        anim.SetTrigger("OpenMenu");
        
        StopAllCoroutines();
        Destroy(popUpObj);
    }

    public void Back()
    {
        Destroy(this.gameObject, 1f);
    }

    void Update()
    {
        if(!appeared) return;

        value1 = Mathf.Lerp(value1, target1, smoothStep);
        value2 = Mathf.Lerp(value2, target2, smoothStep);

        img1.fillAmount = value1 / 100;
        percentage1.text = value1.ToString("F1") + "%";

        img2.fillAmount = value2 / 100;
        percentage2.text = value2.ToString("F1") + "%";
    }

    IEnumerator AnimateSliderOverTime(float seconds)
    {
        float animationTime = 0f;
        while (animationTime < seconds)
        {
            animationTime += Time.deltaTime;
            float lerpValue = animationTime / seconds;
            timeSlider.value = Mathf.Lerp(0f, 1f, lerpValue);
            if(clicked) break;
            yield return null;
        }

        if(!clicked)
        {
            popUpAnim.SetTrigger("Disable");
            Destroy(this.gameObject, 2f);
        }
    }

    IEnumerator waitUntilAppear()
    {
        yield return new WaitForSeconds(0.8f);
        appeared = true;
    }
}
