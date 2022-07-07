using UnityEngine;

namespace NebusokuDev.StateMover.Runtime.InputAbstraction
{
    public class LegacyMoverInput : MonoBehaviour, IMoverInput
    {
        public float Horizontal => UnityEngine.Input.GetAxisRaw("Horizontal");
        public float Vertical => UnityEngine.Input.GetAxisRaw("Vertical");
        public bool IsUpward => UnityEngine.Input.GetButtonDown("Jump");
        public bool IsDownward => false;
        public bool IsSprint { get; }
    }
}