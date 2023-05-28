using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class TreeNode
    {
        public string Name { get; set; }
        public bool IsExpanded { get; set; }
        public List<TreeNode> Children { get; set; }

        public TreeNode()
        {
            Children = new List<TreeNode>();
        }
    }
}
