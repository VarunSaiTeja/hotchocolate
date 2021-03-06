using System.Collections.Generic;
using System.Linq;

namespace HotChocolate.Data.Neo4J.Filtering
{
    public class Neo4JOrFilterDefinition : Neo4JFilterDefinition
    {
        private readonly List<Neo4JFilterDefinition> _filters;
        public Neo4JOrFilterDefinition(IEnumerable<Neo4JFilterDefinition> filters)
        {
            _filters = filters.ToList();
        }
    }
}
