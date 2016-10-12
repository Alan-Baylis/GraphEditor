using UnityEngine;

namespace Klak.Wiring
{
    [AddComponentMenu("Klak/Wiring/Decomposer/Transform")]
    public class TransformDecomposer : NodeBase
    {
        #region Private members

        [SerializeField]
        public Transform _inputValue;

        #endregion


        #region Node I/O

        [Inlet]
        public Transform input
        {
            set
            {
                if (!enabled)
                    return;
                _inputValue = value;
                _position.Invoke(_inputValue.position);
                _localPosition.Invoke(_inputValue.localPosition);
                _scale.Invoke(_inputValue.localScale);
                _rotation.Invoke(_inputValue.rotation);
            }
        }

        [SerializeField, Outlet]
        Vector3Event _position = new Vector3Event();
        [SerializeField, Outlet]
        Vector3Event _localPosition = new Vector3Event();
        [SerializeField, Outlet]
        Vector3Event _scale = new Vector3Event();
        [SerializeField, Outlet]
        QuaternionEvent _rotation = new QuaternionEvent();

        #endregion


        #region MonoBehaviour functions
        #endregion
    }
}