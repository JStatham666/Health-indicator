using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class ButtonEvent : MonoBehaviour
{
    [SerializeField] protected int HealthAmount;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    public void Init(Health health)
    {
        Health = health;
    }

    protected abstract void OnClick();
}