# Bessel Spline Renderer for Unity

For rendering bessel splines. The effect is as follow.

<img src="/1.gif?raw=true">

Usage:
Add BesselSpline.cs to any GameObject and assign the list of control points in the inspector. The control points are drawn with sphere gizmos so you can visualize them in the editor window.

<img src="http://wjwtest.oss-cn-qingdao.aliyuncs.com/cg_exercise/03/sample.png">

As an experiment, I created LineGradient.cs to control an animated color gradient moving on the spline. A changing color gradient can be assigned. The results are not satisfactory, though.

------------- Edit -------------

## Note
I made a serious mistake - the curve should be called B¨¦zier curve (https://en.wikipedia.org/wiki/B%C3%A9zier_curve), not to be confused with Bessel curve (a rarely-used mathematical term)