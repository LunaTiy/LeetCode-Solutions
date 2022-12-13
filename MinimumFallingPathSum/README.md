### 931. Minimum Falling Path Sum
Given an n x n array of integers matrix, return the minimum sum of any falling path through matrix.

A falling path starts at any element in the first row and chooses the element in the next row that is either directly below or diagonally left/right. Specifically, the next element from position (row, col) will be (row + 1, col - 1), (row + 1, col), or (row + 1, col + 1).

##### Example 1:
![image](https://user-images.githubusercontent.com/36387585/207306000-20a735dd-c35b-489b-abf6-f81ab490fd76.png)

##### Example 2:
![image](https://user-images.githubusercontent.com/36387585/207306095-9b910b89-b6b1-4c5c-8049-b47a6305b20f.png)

##### Constraints:
    n == matrix.length == matrix[i].length
    1 <= n <= 100
    -100 <= matrix[i][j] <= 100
