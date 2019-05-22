using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Israel Torres
 * Class: Visual Frameworks - Online (MDV1830-O)
 * Term: C201905 01
 * Code Exercise: TreeView and TabControl
 * Number: CE06
 */

namespace IsraelTorres_CE06
{
    public partial class Form1 : Form
    {
        private List<Data> new_data = null;

        public Data data
        {
            get
            {
                Data d = new Data();
                d.Direction = comboBoxDirection.Text;
                d.Miles = numericUpDownMiles.Value;
                d.Hours = numericUpDownHours.Value;
                d.Mode = textBoxMode.Text;

                return d;
            }

            set
            {
                comboBoxDirection.Text = value.Direction;
                numericUpDownMiles.Value = value.Miles;
                numericUpDownHours.Value = value.Hours;
                textBoxMode.Text = value.Mode;
            }
        }

        public Form1()
        {
            InitializeComponent();

            new_data = Data.DataList;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDirection.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Data d = data;

            if(comboBoxDirection.SelectedIndex != 0)
            {
                if (!String.IsNullOrEmpty(d.ToString()))
                {
                    new_data.Add(d);
                }

                if (new_data.Count > 0)
                {
                    BuildTree();

                    CalculateTotal();
                }
            }
        }

        private void BuildTree()
        {
            treeView1.Nodes.Clear();

            foreach (var itemList in new_data)
            {
                TreeNode node = new TreeNode();
                Data d = itemList as Data;

                node.Text = d.Direction;
                switch (d.Direction)
                {
                    case "East":
                        node.ImageIndex = 0;
                        break;
                    case "West":
                        node.ImageIndex = 1;
                        break;
                    case "North":
                        node.ImageIndex = 2;
                        break;
                    case "South":
                        node.ImageIndex = 3;
                        break;
                    default:
                        break;
                }
                node.SelectedImageIndex = 4;
                node.Nodes.Add("Miles: " + d.Miles);
                node.Nodes.Add("Hours: " + d.Hours);
                node.Nodes.Add("Mode: " + d.Mode);
                node.Nodes[0].ImageIndex = 5;
                node.Nodes[0].SelectedImageIndex = 4;
                node.Nodes[1].ImageIndex = 6;
                node.Nodes[1].SelectedImageIndex = 4;
                node.Nodes[2].ImageIndex = 7;
                node.Nodes[2].SelectedImageIndex = 4;

                treeView1.Nodes.Add(node);
            }
        }

        private void CalculateTotal()
        {
            decimal totalMiles = 0;
            decimal totalHours = 0;
            int totalLegs = 0;
            foreach (var itemlist in new_data)
            {
                totalMiles += itemlist.Miles;
                totalHours += itemlist.Hours;
                totalLegs++;
            }
            textBoxTotalMiles.Text = totalMiles.ToString();
            textBoxTotalHours.Text = totalHours.ToString();
            textBoxTotalLegs.Text = totalLegs.ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxDirection.SelectedIndex = 0;
            numericUpDownMiles.Value = 0;
            numericUpDownHours.Value = 0;
            textBoxMode.Text = "";

            textBoxTotalMiles.Text = "";
            textBoxTotalHours.Text = "";
            textBoxTotalLegs.Text = "";

            new_data.Clear();

            treeView1.Nodes.Clear();
            
            tabControl1.SelectTab(0);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.N))
            {
                newToolStripMenuItem_Click(this, new EventArgs());
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
