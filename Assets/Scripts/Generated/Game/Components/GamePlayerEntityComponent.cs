//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity playerEntityEntity { get { return GetGroup(GameMatcher.PlayerEntity).GetSingleEntity(); } }
    public Osnowa.Osnowa.Core.ECS.PlayerEntityComponent playerEntity { get { return playerEntityEntity.playerEntity; } }
    public bool hasPlayerEntity { get { return playerEntityEntity != null; } }

    public GameEntity SetPlayerEntity(System.Guid newId) {
        if (hasPlayerEntity) {
            throw new Entitas.EntitasException("Could not set PlayerEntity!\n" + this + " already has an entity with Osnowa.Osnowa.Core.ECS.PlayerEntityComponent!",
                "You should check if the context already has a playerEntityEntity before setting it or use context.ReplacePlayerEntity().");
        }
        var entity = CreateEntity();
        entity.AddPlayerEntity(newId);
        return entity;
    }

    public void ReplacePlayerEntity(System.Guid newId) {
        var entity = playerEntityEntity;
        if (entity == null) {
            entity = SetPlayerEntity(newId);
        } else {
            entity.ReplacePlayerEntity(newId);
        }
    }

    public void RemovePlayerEntity() {
        playerEntityEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Osnowa.Osnowa.Core.ECS.PlayerEntityComponent playerEntity { get { return (Osnowa.Osnowa.Core.ECS.PlayerEntityComponent)GetComponent(GameComponentsLookup.PlayerEntity); } }
    public bool hasPlayerEntity { get { return HasComponent(GameComponentsLookup.PlayerEntity); } }

    public void AddPlayerEntity(System.Guid newId) {
        var index = GameComponentsLookup.PlayerEntity;
        var component = (Osnowa.Osnowa.Core.ECS.PlayerEntityComponent)CreateComponent(index, typeof(Osnowa.Osnowa.Core.ECS.PlayerEntityComponent));
        component.Id = newId;
        AddComponent(index, component);
    }

    public void ReplacePlayerEntity(System.Guid newId) {
        var index = GameComponentsLookup.PlayerEntity;
        var component = (Osnowa.Osnowa.Core.ECS.PlayerEntityComponent)CreateComponent(index, typeof(Osnowa.Osnowa.Core.ECS.PlayerEntityComponent));
        component.Id = newId;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerEntity() {
        RemoveComponent(GameComponentsLookup.PlayerEntity);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPlayerEntity;

    public static Entitas.IMatcher<GameEntity> PlayerEntity {
        get {
            if (_matcherPlayerEntity == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerEntity);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerEntity = matcher;
            }

            return _matcherPlayerEntity;
        }
    }
}
