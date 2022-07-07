using System;
using UnityEngine;

namespace NebusokuDev.StateMover.Runtime
{
    [Serializable]
    public struct DegreeAxis
    {
        [SerializeField] private float minAxis;
        [SerializeField] private float maxAxis;
        [SerializeField] private bool isClamp;

        public DegreeAxis(float value = 0, float minAxis = -89f, float maxAxis = 89f, bool isClamp = false)
        {
            this._current = value;
            this.maxAxis = maxAxis;
            this.minAxis = minAxis;
            this.isClamp = isClamp;
        }

        private float _current;

        public float Current
        {
            get => _current;
            set => SetDegree(value);
        }

        public void SetDegree(float degree)
        {
            if (minAxis > maxAxis) (minAxis, maxAxis) = (maxAxis, minAxis);

            _current = isClamp ? Mathf.Clamp(degree, minAxis, maxAxis) : degree;
        }


        public Quaternion ToQuaternion(Vector3 axis) => Quaternion.AngleAxis(_current, axis);
    }
}