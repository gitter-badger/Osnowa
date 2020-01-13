﻿using System;
using System.Collections.Generic;
using System.Linq;
using Entitas;

namespace Osnowa.Osnowa.Core.ECS
{
	[Serializable]
	public class VisionComponent : IComponent
	{
		/// <summary>
		/// Indicates how far the actor's sight can reach.
		/// </summary>
		public int VisionRay;

		/// <summary>
		/// Indicates perception of known items and actors around given entity in normal circumstances.
		/// </summary>
		public int PerceptionRay;


		// todo: decide how the set of seen entities should be handled. Is it needed? Maybe we should assume entities in vicinity with some exceptions?
		// Maybe something like EntitiesReachable would make sense? Or maybe EntitiesRecentlySeen?

		/// <remarks>
		/// For reading, use EntitiesRecentlySeen if you don't need the ID.
		/// </remarks>
		public HashSet<Guid> EntitiesNoticed;

		// todo: this doesn't look the best. For example, what if someone whants to check EntitiesRecentlySeen.Any()? maybe better would be to have
		// an EntitiesSeenProvider which would give the entity and remove it if it has been destroyed
		public IEnumerable<GameEntity> EntitiesRecentlySeen => EntitiesNoticed
															     .Select(id => Contexts.sharedInstance.game.GetEntityWithId(id))
															     .Where(e => e != null);
	}
}