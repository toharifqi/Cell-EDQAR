﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class roundData
{
    public string name;
    public int timeLimitInSeconds;
    public int pointAddedForCorrectAnswer;
    public questionData[] question;
}
