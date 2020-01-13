//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Osnowa.Osnowa.Example.ECS.Senses.AwareComponent aware { get { return (Osnowa.Osnowa.Example.ECS.Senses.AwareComponent)GetComponent(GameComponentsLookup.Aware); } }
    public bool hasAware { get { return HasComponent(GameComponentsLookup.Aware); } }

    public void AddAware(int newTurnsLeft) {
        var index = GameComponentsLookup.Aware;
        var component = (Osnowa.Osnowa.Example.ECS.Senses.AwareComponent)CreateComponent(index, typeof(Osnowa.Osnowa.Example.ECS.Senses.AwareComponent));
        component.TurnsLeft = newTurnsLeft;
        AddComponent(index, component);
    }

    public void ReplaceAware(int newTurnsLeft) {
        var index = GameComponentsLookup.Aware;
        var component = (Osnowa.Osnowa.Example.ECS.Senses.AwareComponent)CreateComponent(index, typeof(Osnowa.Osnowa.Example.ECS.Senses.AwareComponent));
        component.TurnsLeft = newTurnsLeft;
        ReplaceComponent(index, component);
    }

    public void RemoveAware() {
        RemoveComponent(GameComponentsLookup.Aware);
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

    static Entitas.IMatcher<GameEntity> _matcherAware;

    public static Entitas.IMatcher<GameEntity> Aware {
        get {
            if (_matcherAware == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Aware);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAware = matcher;
            }

            return _matcherAware;
        }
    }
}
