using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasFade : MonoBehaviour
{
    bool fade = false;
    bool hasFaded = false;
    public float fadeTime = 0.4f;
    float timer = 0f;
    public float afkTimer = 3;


    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > afkTimer & hasFaded == false)
        {
            Debug.Log("Fade out");
            hasFaded = true;
            Fade();
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("fade in");
            if (hasFaded == true)
            {
                hasFaded = false;
                Fade();
            }
            timer = 0f;
        }
    }

    public void Fade()
    {
        var canvasGroup = GetComponent<CanvasGroup>();

        //toggle the end value baised on the fade state
        StartCoroutine(StartFade(canvasGroup, canvasGroup.alpha, fade ? 1 : 0));

        fade = !fade;
    }

    public IEnumerator StartFade(CanvasGroup canvasGroup, float start, float end)
    {
        float counter = 0f;

        while (counter < fadeTime)
        {
            counter += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, end, counter / fadeTime);

            yield return null;
        }
    }
}
