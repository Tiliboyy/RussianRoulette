using Exiled.Events.EventArgs.Player;
using InventorySystem.Items.Firearms;
using InventorySystem.Items.Firearms.Attachments.Components;
using Random = UnityEngine.Random;

namespace RussianRoulette;

public class EventHandlers
{
    public static void Shooting(ShootingEventArgs ev)
    {
        if (ev.Player.CurrentItem.Type != ItemType.GunRevolver) return;
        var gun = ev.Player.CurrentItem.Base as Firearm;
        if (gun != null && gun.Status.Ammo == 1)
        {
            ev.IsAllowed = Random.Range(1 ,gun.AmmoManagerModule.MaxAmmo) == 1;
        }
    }
}