﻿
// -------------------------------------------------------
// LeopotamGroupLibrary for unity3d
// Copyright (c) 2012-2017 Leopotam <leopotam@gmail.com>
// -------------------------------------------------------

using LeopotamGroup.Common;
using System.Collections;
using UnityEngine;

namespace LeopotamGroup.FX {
    /// <summary>
    /// Setup music parameters on start.
    /// </summary>
    public sealed class MusicOnStart : MonoBehaviour {
        [SerializeField]
        string _music;

        [SerializeField]
        bool _isLooped = true;

        IEnumerator Start () {
            yield return null;
            var sm = Singleton.Get<SoundManager> ();
            if (sm.MusicVolume <= 0f) {
                sm.StopMusic ();
            }
            sm.PlayMusic (_music, _isLooped);
        }
    }
}