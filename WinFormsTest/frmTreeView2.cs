using System.Data;
using WinFormsTest.Helper;

namespace WinFormsTest
{
    public partial class frmTreeView2 : Form
    {
        public frmTreeView2()
        {
            InitializeComponent();
        }

        private void frmTreeView2_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();//清除所有节点
            //1. 获取数据
            DataTable dtMenus = DBHelper.GetDataTable("select Id,MName,ParentId from MenuInfos", 1);
            //3.调用方法,添加节点
            CreateNode(dtMenus, null, 0);
        }

        //2.添加节点（递归）
        private void CreateNode(DataTable dt, TreeNode pNode, int parentId)
        {
            //1.获取要创建的节点数据
            DataRow[] rows = dt.Select("ParentId=" + parentId);
            if (rows.Length > 0)
            {
                foreach (DataRow r in rows)
                {
                    //2.新建子节点
                    TreeNode node = new TreeNode();
                    node.Name = r["Id"].ToString();
                    node.Text = r["MName"].ToString();
                    //3.直接添加到TreeView Nodes  还是添加指定节点的Nodes里？ 
                    if (pNode != null)
                        pNode.Nodes.Add(node);
                    else
                        treeView1.Nodes.Add(node);
                    //4.判断当前节点下有没有子节点
                    //这个是递归，直到rows为0即当前节点没有子节点时结束递归
                    CreateNode(dt, node, int.Parse(node.Name));
                }
            }
        }

        bool isMouseClick = true;
        private void treeView1_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            isMouseClick = false;
            //子节点勾选
            SetChildNodesState(e.Node);
            //父节点勾选
            SetParentNodeState(e.Node);
            isMouseClick = true;
        }
        private void treeView1_AfterCheck_1(object sender, TreeViewEventArgs e)
        {
            if (isMouseClick)
            {
                treeView1.SelectedNode = e.Node; //当前操作节点选中
            }
        }

        //递归处理子节点的勾选
        private void SetChildNodesState(TreeNode node)
        {
            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode n in node.Nodes)
                {
                    n.Checked = node.Checked;
                    SetChildNodesState(n);
                }
            }
        }

        private void SetParentNodeState(TreeNode node)
        {
            TreeNode pNode = node.Parent;//获取父节点
            if (pNode != null)
            {
                bool bl = false;

                foreach (TreeNode n in pNode.Nodes)
                {
                    if (n.Checked)
                    {
                        bl = true;
                        break;
                    }
                }
                pNode.Checked = bl;
                SetParentNodeState(pNode);
            }
        }
    }
}
