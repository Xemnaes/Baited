﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardStateScript : MonoBehaviour
{

    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        damage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        Debug.Log("pp time");
    }
}
