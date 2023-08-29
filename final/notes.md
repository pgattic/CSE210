
# Tron

## Classes

### MapElement
 - Store and update position (as multiple of grid cell size)
 - Return absolute screen coords
 - Test position against screen dimensions
 - Hold onto color

### SquareMapElement : MapElement
 - MapElement but customized to drawing a square

### CircularMapElement : MapElement
 - MapElement but customized to draw a circle

### BodySegment : MapElement
 - Display itself on screen
 - Return

### Snake : MapElement
 - Store and append to list of BodySegments
 - Draw body segments on screen

### Food : MapElement
 - draw itself on screen

### Collider
 - Hold onto the physical elements of the game
 - Perform collision detection

### Keys
 - Detect and store keypress state

