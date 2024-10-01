using System;
using UnityEngine;

namespace Game.Scripts.Extra
{
    public class Singelton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance { get; private set; }

        protected virtual void Awake()
        {
            Instance = this as T;
        }
    }
}