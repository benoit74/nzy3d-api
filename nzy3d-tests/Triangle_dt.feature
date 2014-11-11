Feature: Triangle_dt
	
Scenario: Triangle setup in counterclockwise
	Given I have an initial test setup
	And I have a triangle with coordinates (0.0,0.0)-(1.0,0.0)-(0.0,1.0)
	Then the triangle has coordinates (0.0,0.0)-(1.0,0.0)-(0.0,1.0)
	
Scenario: Triangle setup in clockwise
	Given I have an initial test setup
	And I have a triangle with coordinates (0.0,0.0)-(0.0,1.0)-(1.0,0.0)
	Then the triangle has coordinates (0.0,0.0)-(1.0,0.0)-(0.0,1.0)

Scenario: Point inside triangle
	Given I have an initial test setup
	And I have a triangle with coordinates (0.0,0.0)-(0.0,1.0)-(1.0,0.0)
	And I have a point with coordinates (0.25,0.25)
	Then The point is inside the triangle

Scenario: Point outside triangle
	Given I have an initial test setup
	And I have a triangle with coordinates (0.0,0.0)-(0.0,1.0)-(1.0,0.0)
	And I have a point with coordinates (0.75,0.75)
	Then The point is outside the triangle

Scenario: Point on the boundary of triangle
	Given I have an initial test setup
	And I have a triangle with coordinates (0.0,0.0)-(0.0,1.0)-(1.0,0.0)
	And I have a point with coordinates (0.5,0.5)
	Then The point is on the boundary of the triangle
