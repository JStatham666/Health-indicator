using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    [SerializeField] private TextHealthViewer _textHealthViewer;
    [SerializeField] private RegularHealthbarViewer _healthbarViewer;
    [SerializeField] private SmoothHealthbarViewer _smoothHealthbarViewer;
    [SerializeField] private DamageButton _damageButton;
    [SerializeField] private HealButton _healButton;

    private Health _health;

    private void Awake()
    {
        _health = new Health();

        _textHealthViewer.Init(_health);
        _healthbarViewer.Init(_health);
        _smoothHealthbarViewer.Init(_health);
        _damageButton.Init(_health);
        _healButton.Init(_health);
    }
}