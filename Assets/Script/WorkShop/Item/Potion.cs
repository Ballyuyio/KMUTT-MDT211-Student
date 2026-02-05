using UnityEngine;

public class Potion : Item
{
    public AudioClip SoundPotion;
    public int AmountHealth = 20;
    public override void OnCollect(Player player)
    {
        base.OnCollect(player);
        player.Heal(AmountHealth);
        SoundManager.instance.PlaySFX(SoundPotion);
        Destroy(gameObject);
    }
}
