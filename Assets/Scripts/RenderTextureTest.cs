using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class RenderTextureTest : MonoBehaviour
{
    public Text Text;

    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"RenderTexture:{target.activeSelf}";
    }

    public void OnClick()
    {
        target.SetActive(!target.activeSelf);
    }
}