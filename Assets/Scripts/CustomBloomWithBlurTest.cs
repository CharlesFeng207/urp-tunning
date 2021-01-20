using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class CustomBloomWithBlurTest : MonoBehaviour
{
    public Text Text;
    public VolumeProfile Profile;

    private Bloom bloom;
    private void Awake()
    {
         Profile.TryGet<Bloom>(out bloom);
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = $"BloomWithBlur:{bloom.bloomWithBlur.value}";
    }

    public void OnClick()
    {
        bloom.bloomWithBlur.value = !bloom.bloomWithBlur.value;
    }
}