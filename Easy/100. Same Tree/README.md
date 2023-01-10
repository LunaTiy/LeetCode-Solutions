## 100. Same Tree

Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

##### Example 1:

![image](https://user-images.githubusercontent.com/36387585/211521518-bb5e30ed-56c3-4e2c-bdfb-a80c142ed212.png)

    Input: p = [1,2,3], q = [1,2,3]
    Output: true

##### Example 2:

![image](https://user-images.githubusercontent.com/36387585/211521546-2eca0ab0-6cc2-4723-8f55-11a7fe141462.png)


    Input: p = [1,2], q = [1,null,2]
    Output: false

##### Example 3:

![image](https://user-images.githubusercontent.com/36387585/211521589-0e6a8ef0-6130-4216-b899-bc3ff9e4722b.png)

    Input: p = [1,2,1], q = [1,1,2]
    Output: false

##### Constraints:

    The number of nodes in both trees is in the range [0, 100].
    -10^4 <= Node.val <= 10^4
