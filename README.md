# AntColony-TSP
Ant colony optimisation algorithm is used for solving travelling salesman problem.
Ants spread pheromone while walking, but pheromone evaporates. 
Ant chooses the random way, but the more pheromone it sense, the greater probability that it will go there.
Pheromone accumulates on the shortest ways.

There are three types of the algorithm:
  - ant-quantity: ants update pheromone directly after move from point to point and quantity of spreaded pheromone is constant,
  - ant-density: ants update pheromone after move as well, but quantity of spreaded pheromone in each edge depends on its length,
  - ant-cycle: ants update pheromone after entire tour and amount of pheromone deposited by each ant depends on tour quality.
I've implemented these algorithms in the app above.

Parameter Q means how much pheromone each ant spreads on the one edge.
Parameter alpha determines how much an ant pays attention to pheromone amount during picking next point.
Parameter beta determines influence of point's distance during selection.

When application started, you need to pick at least four points on the field by click and choose type of alghorithm and click Start.
