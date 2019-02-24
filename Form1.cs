using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtAd.Text = treeView1.SelectedNode.Text;
            txtSoyad.Text = treeView1.SelectedNode.Nodes[0].Text;
            dateTimePicker1.Text = treeView1.SelectedNode.Nodes[0].Nodes[0].Text;
            //dateTimePicker1.Text = treeView1.Nodes.ToString();
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(txtAd.Text);
            treeView1.Nodes[i].Nodes.Add(txtSoyad.Text);
            treeView1.Nodes[i].Nodes[0].Nodes.Add(dateTimePicker1.Text);
            treeView1.ExpandAll();
            i++;
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            
        }
        private void treeView1_DragLeave(object sender, EventArgs e)
        {

        }
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
        }
        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
