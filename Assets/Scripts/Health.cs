using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private UnityEvent _lifePointsOver;
        [SerializeField] private UnityEvent _damageWasTaken;
        [SerializeField] private int _lifePoint;

        private readonly int _minPoint = 0;

        public int LifePoint => _lifePoint;
        public int MaxLifePoint { get; private set; }

        private void Awake() =>
            MaxLifePoint = _lifePoint;

        private void OnEnable() =>
            EventBus.MedicinePickedUp.AddListener(Heal);

        public void TakeDamage(int value)
        {
            if (value > _minPoint)
            {
                if (_lifePoint >= value)
                    _lifePoint -= value;
                else
                    _lifePointsOver.Invoke();
            }

            _damageWasTaken.Invoke();
        }

        private void Heal(int value)
        {
            int drawback = MaxLifePoint - _lifePoint;

            if (value > _minPoint && value <= drawback)
            {
                _lifePoint += value;
            }
            else if (value > drawback)
            {
                _lifePoint = MaxLifePoint;
            }
        }
    }
}