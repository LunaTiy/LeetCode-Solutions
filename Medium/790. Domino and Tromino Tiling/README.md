﻿## 790. Domino and Tromino Tiling

You have two types of tiles: a 2 x 1 domino shape and a tromino shape. You may rotate these shapes.

![image](https://user-images.githubusercontent.com/36387585/209416585-247ef72e-f90d-4ec6-a2b4-afefba9b93ea.png)

Given an integer n, return the number of ways to tile an 2 x n board. Since the answer may be very large, return it modulo 10^9 + 7.

In a tiling, every square must be covered by a tile. Two tilings are different if and only if there are two 4-directionally adjacent cells on the board such that exactly one of the tilings has both squares occupied by a tile.

##### Example 1:

![image](https://user-images.githubusercontent.com/36387585/209416592-3e4373db-f0da-408a-952f-2c2f43766cd7.png)

    Input: n = 3
    Output: 5
    Explanation: The five different ways are show above.

##### Example 2:

    Input: n = 1
    Output: 1

##### Constraints:

    1 <= n <= 1000
