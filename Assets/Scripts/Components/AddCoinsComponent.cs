using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class AddCoinsComponent : MonoBehaviour
    {
        [SerializeField] private int _coins;
        [SerializeField] private Hero _hero;

        public void AddCoins()
        {
            _hero.AmountCoinsToAdd(_coins);
        }
    }
}