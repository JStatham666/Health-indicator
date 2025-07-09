using UnityEngine;

public class DamageButton : ButtonEvent
{
    protected override void OnClick()
    {
        Health.TakeDamage(HealthAmount);
    }
}