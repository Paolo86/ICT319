﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{

    Image bombImage;
    Text ammoText;
    // Start is called before the first frame update
    void Start()
    {
        bombImage = transform.GetChild(2).GetComponent<Image>();
        ammoText = transform.GetChild(1).GetComponentInChildren<Text>();
    }

    public void EnableBomb(bool enable)
    {
        bombImage.enabled = enable;
    }

    public void SetAmmoText(string text)
    {
        ammoText.text = text;
    }
}
