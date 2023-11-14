using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    public class HealthBarTexter : HealthRenderer
    {
        [SerializeField] private TMP_Text _text;

        public override void WriteHealth() =>
            _text.text = $"{HealthPoint}/{MaxHealth}";
    }
}