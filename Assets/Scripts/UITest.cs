using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class UITest : MonoBehaviour
{
    public Text Text;

    public GameObject target;
    // Update is called once per frame
    void Update()
    {
        Text.text = $"UI:{target.activeSelf}";
    }

    public void OnClick()
    {
        target.SetActive(!target.activeSelf);
    }
}