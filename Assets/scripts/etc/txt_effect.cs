using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class txt_effect : MonoBehaviour
{
    Text txt;

    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.enabled = false;
    }

    void DoEffect(object earn)
    {
        txt.text = "+" + (int)earn;
        StartCoroutine("MakeEffect");
    }

    IEnumerator MakeEffect()
    {
        float t = 0.01f;
        RectTransform rt = (RectTransform)gameObject.transform;
        rt.anchoredPosition = new Vector2(0f, -68f);
        txt.enabled = true;
        while(t<=2.0f)
        {
            rt.Translate(new Vector3(0, 0.1f, 0));
            yield return new WaitForSeconds(0.01f);
            t += 0.1f;
        }
        txt.enabled = false;
    }
}
