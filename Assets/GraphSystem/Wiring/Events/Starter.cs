//
// Klak - Utilities for creative coding with Unity
//
// Copyright (C) 2016 Keijiro Takahashi
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
using UnityEngine;

namespace Klak.Wiring
{
    [NodeType("Events")]
    [AddComponentMenu("Klak/Wiring/Event/Starter")]
    public class Starter : EventNode
    {
        #region Node I/O

        [SerializeField, Outlet]
        VoidEvent _onStartEvent = new VoidEvent();

        [SerializeField, Outlet]
        VoidEvent _onAwakeEvent = new VoidEvent();

        #endregion

        #region MonoBehaviour functions

        void Start()
        {
            _onStartEvent.Invoke();
        }
        void Awake()
        {
            _onAwakeEvent.Invoke();
        }

        #endregion
    }
}
