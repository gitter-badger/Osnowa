//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Osnowa.Osnowa.Example.ECS.AI.ActivityComponent activity { get { return (Osnowa.Osnowa.Example.ECS.AI.ActivityComponent)GetComponent(GameComponentsLookup.Activity); } }
    public bool hasActivity { get { return HasComponent(GameComponentsLookup.Activity); } }

    public void AddActivity(Osnowa.Osnowa.AI.Activities.IActivity newActivity) {
        var index = GameComponentsLookup.Activity;
        var component = (Osnowa.Osnowa.Example.ECS.AI.ActivityComponent)CreateComponent(index, typeof(Osnowa.Osnowa.Example.ECS.AI.ActivityComponent));
        component.Activity = newActivity;
        AddComponent(index, component);
    }

    public void ReplaceActivity(Osnowa.Osnowa.AI.Activities.IActivity newActivity) {
        var index = GameComponentsLookup.Activity;
        var component = (Osnowa.Osnowa.Example.ECS.AI.ActivityComponent)CreateComponent(index, typeof(Osnowa.Osnowa.Example.ECS.AI.ActivityComponent));
        component.Activity = newActivity;
        ReplaceComponent(index, component);
    }

    public void RemoveActivity() {
        RemoveComponent(GameComponentsLookup.Activity);
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

    static Entitas.IMatcher<GameEntity> _matcherActivity;

    public static Entitas.IMatcher<GameEntity> Activity {
        get {
            if (_matcherActivity == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Activity);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherActivity = matcher;
            }

            return _matcherActivity;
        }
    }
}
