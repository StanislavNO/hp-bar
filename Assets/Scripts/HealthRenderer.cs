using UnityEngine;

namespace Assets.Scripts
{
    public abstract class HealthRenderer : MonoBehaviour
    {
        [SerializeField] private Health _health;

        protected int HealthPoint;

        public int MaxHealth { get; private set; }

        protected void Start() =>
            MaxHealth = _health.MaxLifePoint;

        protected void Update()
        {
            if (HealthPoint != _health.LifePoint)
                HealthPoint = _health.LifePoint;

            WriteHealth();
        }

        public abstract void WriteHealth();
    }
}