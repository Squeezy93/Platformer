﻿using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Components
{
    public class EnterTriggerComponent : MonoBehaviour
    {
        [SerializeField] private string _tag;
        [SerializeField] private UnityEvent _action;

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if(collider.gameObject.CompareTag(_tag))
            {
                _action?.Invoke();
            }
        }

    }
}