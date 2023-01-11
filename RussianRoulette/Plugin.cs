using Exiled.API.Features;

namespace RussianRoulette;

public class Plugin : Plugin<Configs>
{

    public EventHandlers? EventHandlers;
    public override string Author => "Tiliboyy";
    public override string Name => "CustomLobbySpawner";

    public override string Prefix => "CustomLobbySpawner";
    public override Version Version => new(1, 0, 0);
    public override Version RequiredExiledVersion => new(5, 0, 0, 0);


    public override void OnEnabled()
    {
        try
        {
            EventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.Shooting += EventHandlers.Shooting;
        }
        catch (Exception error)
        {
            Log.Error(error);
        }
    }


    public override void OnDisabled()
    {
        EventHandlers = null;
        Exiled.Events.Handlers.Player.Shooting -= EventHandlers.Shooting;

    }
}