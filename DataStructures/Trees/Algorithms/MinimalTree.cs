using System;
using System.Collections.Generic;

namespace DataStructures.Trees
{
    public class MinimalTree
    {
        public BinaryTreeNode BuildFromSortedArray(List<int> sortedArray)
        {
            var sortedArrayCount = sortedArray.Count;
            if (sortedArrayCount == 1)
            {
                //create leaf node
                return new BinaryTreeNode(sortedArray[0]);
            }
            
            var middleElementIndex = sortedArrayCount/ 2;
            
            var root = new BinaryTreeNode(sortedArray[middleElementIndex]);
            
            root.LeftNode = BuildFromSortedArray(sortedArray.GetRange(0, middleElementIndex));
            
            // if array has only two elements we can't put anything on the rightmost leaf
            if (sortedArrayCount > 2)
            {
                root.RightNode = BuildFromSortedArray(
                                sortedArray.GetRange(middleElementIndex + 1, sortedArrayCount - middleElementIndex - 1));
            }
            
            return root;

        }
    }
}