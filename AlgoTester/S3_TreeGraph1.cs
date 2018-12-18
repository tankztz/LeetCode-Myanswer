using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTester
{
    class S3_TreeGraph1
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public class Solution
        {
            public IList<int> InorderTraversal(TreeNode root)
            {
                var ans = new List<int>();
                var st = new Stack<object>();

                st.Push(root);
                while (st.Count > 0)
                {
                    var x = st.Pop();
                    if (x == null) continue;
                    if (x is TreeNode)
                    {
                        var thisNode = (TreeNode)x;
                        st.Push(thisNode.right);
                        st.Push(thisNode.val);
                        st.Push(thisNode.left);
                    }
                    else if (x is int)
                    {
                        ans.Add((int)x);
                    }
                    else
                        continue;
                }
                return ans;
            }
        }
    }
}
