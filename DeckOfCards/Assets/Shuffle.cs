﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            GameObject go = GameObject.Find("2_of_hearts");
            Debug.Log(go.Card);
        }
    }
}
