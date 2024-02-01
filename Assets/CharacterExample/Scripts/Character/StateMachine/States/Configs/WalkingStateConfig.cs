using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WalkingStateConfig
{
    [SerializeField, Range(0, 10)] private float _speed;

    public float Speed => _speed;
}
