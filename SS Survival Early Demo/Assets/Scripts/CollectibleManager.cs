﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    private int _totalToiletPaper;
    private int _collectedToiletPaper;

    public TextMeshProUGUI toiletPaperCount;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _totalToiletPaper = FindObjectsOfType<Collectible>().Length;
        DisplaytoiletPaperCount();
    }
    void DisplaytoiletPaperCount()
    {
        toiletPaperCount.SetText(_collectedToiletPaper + " / " + _totalToiletPaper);
    }

    public void HandleToiletPaperCollected()
    {
        _collectedToiletPaper++;
        DisplaytoiletPaperCount();
    }
}
