nzy3d-api
=========

This is a main Git repository for Nzy3d, a .Net API for 3d charts. 

Much of this work is based on Jzy3d, a Java API from my friend [Martin](github.com/martin-pernollet).

##nzy3d-api
This is the toolkit by itself. It is based on OpenTK for OpenGL integration in C#.

##nzy3d-tests
This is where all unit/integration tests resides. Work In Progress, testers are welcome !

##nzy3d-wpfDemo
This is a demo of the use of the toolkit in a WPF application. I chose to made the demo in a WPF
 application because it is more complexe than in a Winforms where it is very straigthforward since
 the toolkit provides a Winforms control to use for rendering of 3D scene.
In WPF, the integration is a bit more complex since we have to integrate this Winforms control inside a WPF
canvas. There is no other solution so far since OpenTK does not provide a WPF control for drawing (at least
it did not in 2012 ... and I don't even think it would made any sense).

Video here: http://www.screencast.com/t/Oj2CjuFF

