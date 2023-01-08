## 149. Max Points on a Line

Given an array of points where points[i] = [xi, yi] represents a point on the X-Y plane, return the maximum number of points that lie on the same straight line.

##### Example 1:

![image](https://user-images.githubusercontent.com/36387585/211205437-4e469f97-cca8-4c25-9441-1d1a1fa75d61.png)


    Input: points = [[1,1],[2,2],[3,3]]
    Output: 3

##### Example 2:

![image](https://user-images.githubusercontent.com/36387585/211205458-dfe8490c-74aa-4b70-9f13-1f8a0da8f7eb.png)


    Input: points = [[1,1],[3,2],[5,3],[4,1],[2,3],[1,4]]
    Output: 4

##### Constraints:

    1 <= points.length <= 300
    points[i].length == 2
    -10^4 <= xi, yi <= 10^4
    All the points are unique.
