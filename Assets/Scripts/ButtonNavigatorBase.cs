﻿using UnityEngine;

namespace THFUMO
{
    public abstract class ButtonNavigatorBase : MonoBehaviour
    {
        public abstract int CurrentButton { get; set; }
    }
}