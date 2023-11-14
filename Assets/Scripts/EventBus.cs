using UnityEngine.Events;

namespace Assets.Scripts
{
    public class EventBus
    {
        public static readonly UnityEvent<int> MedicinePickedUp = new();

        public static void CallMedicinePickedUp(int value) => 
            MedicinePickedUp?.Invoke(value);
    }
}