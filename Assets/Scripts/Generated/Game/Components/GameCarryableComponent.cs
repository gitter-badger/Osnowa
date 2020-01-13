//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Osnowa.Osnowa.Example.ECS.Carrying.CarryableComponent carryableComponent = new Osnowa.Osnowa.Example.ECS.Carrying.CarryableComponent();

    public bool isCarryable {
        get { return HasComponent(GameComponentsLookup.Carryable); }
        set {
            if (value != isCarryable) {
                var index = GameComponentsLookup.Carryable;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : carryableComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherCarryable;

    public static Entitas.IMatcher<GameEntity> Carryable {
        get {
            if (_matcherCarryable == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Carryable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCarryable = matcher;
            }

            return _matcherCarryable;
        }
    }
}
