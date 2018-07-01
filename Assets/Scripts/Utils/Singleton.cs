using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Utils
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static T _instance;

        public static T instance
        {
            get
            {
                if (_instance == null)
                    _instance = GameObject.FindObjectOfType<T>();

                if (_instance == null)
                    throw new Exception("Failed to get singleton instance: " + typeof(T).Name);

                return _instance;
            }
        }

        protected void Awake()
        {
            _instance = gameObject.GetComponent<T>();
        }
    }
}