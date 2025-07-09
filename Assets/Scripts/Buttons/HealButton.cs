using UnityEngine;

public class HealButton : ButtonEvent
{
    protected override void OnClick()
    {
        AddHealth();
    }

    private void AddHealth()
    {
        if (TryAddHealth(HealthAmount) == false)
            return;      
    }

    public bool TryAddHealth(float recoverHealth)
    {
        return Health.TryAddValue(recoverHealth);
    }
}