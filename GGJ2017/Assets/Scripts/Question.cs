﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Question {

    public int id;
    public string question;
    public string[] options;
    public int[] next;
}
