using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class OneTextureTest : MonoBehaviour
{
    public Text Text;

    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"RGBA64:{target.activeSelf}";
    }

    public void OnClick()
    {
        target.SetActive(!target.activeSelf);
    }
}