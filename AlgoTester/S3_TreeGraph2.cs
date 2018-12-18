using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTester
{
    class S3_TreeGraph2
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
            public void dfs(int depth)
            {

            }

            public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
            {
                var ans = new List<IList<int>>();
                if (root == null) return ans;
                var depthDic = new Dictionary<TreeNode, int>();
                depthDic.Add(root, 1);

                var st = new List<Stack<TreeNode>>();
                st.Add(new Stack<TreeNode>());// q[0]
                st.Add(new Stack<TreeNode>());// q[1]
                st[0].Push(root);
                int level = 0;

                while (st[level%2].Count > 0)
                {
                    int thisStLevel = level % 2;
                    int nextStLevel = (level + 1) % 2;

                    while (st[thisStLevel].Count() > 0)
                    {
                        var thisNode = st[thisStLevel].Pop();
                        if (thisNode == null) continue;

                        while (ans.Count() < level + 1) ans.Add(new List<int>()); // level == 0 requires ans.count = 1
                        ans[level].Add(thisNode.val);

                        if (thisStLevel == 0)
                        {
                            if (thisNode.left != null)
                            {
                                st[nextStLevel].Push(thisNode.left);
                                depthDic.Add(thisNode.left, depthDic[thisNode] + 1);
                            }
                            if (thisNode.right != null)
                            {
                                st[nextStLevel].Push(thisNode.right);
                                depthDic.Add(thisNode.right, depthDic[thisNode] + 1);
                            }
                        }
                        else
                        {
                            if (thisNode.right != null)
                            {
                                st[nextStLevel].Push(thisNode.right);
                                depthDic.Add(thisNode.right, depthDic[thisNode] + 1);
                            }
                            if (thisNode.left != null)
                            {
                                st[nextStLevel].Push(thisNode.left);
                                depthDic.Add(thisNode.left, depthDic[thisNode] + 1);
                            }
                        }
                    }
                    level++;
                }
                return ans;
            }
        }
    }
}
