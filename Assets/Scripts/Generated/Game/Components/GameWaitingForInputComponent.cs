//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity waitingForInputEntity { get { return GetGroup(GameMatcher.WaitingForInput).GetSingleEntity(); } }

    public bool isWaitingForInput {
        get { return waitingForInputEntity != null; }
        set {
            var entity = waitingForInputEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isWaitingForInput = true;
                } else {
                    entity.Destroy();
                }
            }
        }
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

    static readonly Osnowa.Osnowa.Core.ECS.Initiative.WaitingForInputComponent waitingForInputComponent = new Osnowa.Osnowa.Core.ECS.Initiative.WaitingForInputComponent();

    public bool isWaitingForInput {
        get { return HasComponent(GameComponentsLookup.WaitingForInput); }
        set {
            if (value != isWaitingForInput) {
                var index = GameComponentsLookup.WaitingForInput;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : waitingForInputComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherWaitingForInput;

    public static Entitas.IMatcher<GameEntity> WaitingForInput {
        get {
            if (_matcherWaitingForInput == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.WaitingForInput);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWaitingForInput = matcher;
            }

            return _matcherWaitingForInput;
        }
    }
}
