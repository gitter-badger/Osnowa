//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Osnowa.Osnowa.Example.ECS.Heartbeat.ExecutePreTurnComponent executePreTurnComponent = new Osnowa.Osnowa.Example.ECS.Heartbeat.ExecutePreTurnComponent();

    public bool isExecutePreTurn {
        get { return HasComponent(GameComponentsLookup.ExecutePreTurn); }
        set {
            if (value != isExecutePreTurn) {
                var index = GameComponentsLookup.ExecutePreTurn;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : executePreTurnComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherExecutePreTurn;

    public static Entitas.IMatcher<GameEntity> ExecutePreTurn {
        get {
            if (_matcherExecutePreTurn == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ExecutePreTurn);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherExecutePreTurn = matcher;
            }

            return _matcherExecutePreTurn;
        }
    }
}
