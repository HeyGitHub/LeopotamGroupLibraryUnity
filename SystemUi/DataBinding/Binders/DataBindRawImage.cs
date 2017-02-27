// ----------------------------------------------------------------------------
// The MIT License
// LeopotamGroupLibrary https://github.com/Leopotam/LeopotamGroupLibraryUnity
// Copyright (c) 2012-2017 Leopotam <leopotam@gmail.com>
// ----------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;

// ReSharper disable RedundantCast.0

namespace LeopotamGroup.SystemUi.DataBinding.Binders {
    /// <summary>
    /// Data binding of texture for any RawImage component.
    /// </summary>
    [RequireComponent (typeof (RawImage))]
    public sealed class DataBindRawImage : AbstractBinderBase {
        RawImage _target;

        protected override void ProcessBindedData (object data) {
            if ((object) _target == null) {
                _target = GetComponent<RawImage> ();
            }
            _target.texture = data as Texture;
        }
    }
}