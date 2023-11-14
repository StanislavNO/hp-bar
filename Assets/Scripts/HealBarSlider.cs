using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class HealBarSlider : HealthRenderer
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private bool _isTimer;
        [SerializeField] private float _speed;

        private void Awake()
        {
            _slider.maxValue = 1;
            _slider.wholeNumbers = false;
        }

        public override void WriteHealth()
        {
            float percent = 100f;
            float _normalizeHealth;

            _normalizeHealth = (_slider.maxValue / percent) *
                               (MaxHealth / percent * HealthPoint);

            if (_isTimer )
            {
                _slider.value = Mathf.MoveTowards(
                    _slider.value, 
                    _normalizeHealth, 
                    Time.deltaTime * _speed);
            }
            else
                _slider.value = _normalizeHealth;
        }
    }
}