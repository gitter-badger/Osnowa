namespace PCG.MapIngredientGenerators
{
	using System.Collections;
	using MapIngredientConfigs;
	using Osnowa.Osnowa.Core;
	using Osnowa.Osnowa.Example;
	using UnityEngine;

	public class WalkabilityIngredientGenerator : MapIngredientGenerator
	{
		private WalkabilityIngredientConfig _config;
        private ValueMap _waterMap;
        private IExampleContext _context;

        public void Init(IExampleContext context, WalkabilityIngredientConfig config, WorldGeneratorConfig worldGeneratorConfig, ValueMap waterMap)
		{
            _context = context;
            _config = config;
			_waterMap = waterMap;
            Values = new ValueMap(1, worldGeneratorConfig.XSize, worldGeneratorConfig.YSize);

            base.Init(context, config, worldGeneratorConfig);
		}

		public override IEnumerator Recalculating()
		{
            MatrixFloat walkabilityMap = _context.Walkability;

            foreach (Position cellMiddle in _waterMap.AllCellMiddles())
			{
				if (_waterMap.Get(cellMiddle) != WaterIngredientGenerator.Ground)
				{
                    walkabilityMap.Set(cellMiddle, 0f);
					continue;
				}

                walkabilityMap.Set(cellMiddle, 1f);
            }

            yield return new WaitForSeconds(0.1f);
		}
	}
}