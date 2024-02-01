using UnityEngine;

namespace Assets.Scripts
{
    public class Hero : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _jumpSpeed;

        [SerializeField] private LayerCheck _groundCheck;

        private Vector2 _direction;
        private Rigidbody2D _rb;


        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        public void SetDirection(Vector2 direction)
        {
            _direction = direction;
        }

        private bool IsGrounded()
        {
            return _groundCheck.IsTouchingLayer;
        }

        private void FixedUpdate()
        {

            var isJumping = _direction.y > 0;
            if (isJumping)
            {
                if (IsGrounded())
                {
                    _rb.velocity = new Vector2(_rb.velocity.x, 0f);
                    _rb.AddForce(Vector2.up * _jumpSpeed, ForceMode2D.Impulse);
                }
                else if (_rb.velocity.y > 0)
                {
                    _rb.velocity = new Vector2(_rb.velocity.x, _rb.velocity.y * 0.5f);
                }
            }
            _rb.velocity = new Vector2(_direction.x * _speed, _rb.velocity.y);
        }
    }
}
