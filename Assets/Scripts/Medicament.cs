using UnityEngine;

namespace Assets.Scripts
{
    public class Medicament : MonoBehaviour
    {
        [SerializeField] private int _livePoint;

        public void GetHealth() =>
            EventBus.CallMedicinePickedUp(_livePoint);
    }
}