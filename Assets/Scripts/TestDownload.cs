﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDownload : MonoBehaviour
{
    private void Start ()
    {
        new DownloadRequest().Send();
    }

}
