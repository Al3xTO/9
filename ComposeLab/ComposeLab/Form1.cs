using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComposeLab
{
    public partial class Form1 : Form
    {
        private enum Parts
        {
            Wheel = 1,
            Body = 2,
            Window = 4,
        }

        private byte Car = 0;
        CarriagePart wheel;
        CarriagePart body;
        CarriagePart window;

        CompositeCarriage carriage;

        public Form1()
        {
            InitializeComponent();
        }

        private void UncheckAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = false;

                if (node.Nodes.Count > 0)
                {
                    UncheckAllNodes(node.Nodes);
                }
            }
        }

        private void BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                e.Cancel = true;
            }
            else
            {
                switch (e.Node.Parent.Name)
                {
                    case "nWheel":
                        if (!e.Node.Checked)
                        {
                            if ((Car & (byte)Parts.Wheel) != 1)
                            {
                                Car |= (byte)Parts.Wheel;
                                wheel = new CarriagePart(e.Node.Text);
                            }
                            else
                            {
                                MessageBox.Show("Можна вибрати лише один тип коліс.");
                                e.Cancel = true;
                            }
                        }
                        else
                        {
                            Car &= 0b1111_1110;
                            wheel = null;
                        }
                        break;
                    case "nBody":
                        if (!e.Node.Checked)
                        {
                            if ((Car & (byte)Parts.Body) != 2)
                            {
                                Car |= (byte)Parts.Body;
                                body = new CarriagePart(e.Node.Text);
                            }
                            else
                            {
                                MessageBox.Show("Можна вибрати лише один тип кузова.");
                                e.Cancel = true;
                            }
                        }
                        else
                        {
                            Car &= 0b1111_1101;
                            body = null;
                        }
                        break;
                    case "nWindow":
                        if (!e.Node.Checked)
                        {
                            if ((Car & (byte)Parts.Window) != 4)
                            {
                                Car |= (byte)Parts.Window;
                                window = new CarriagePart(e.Node.Text);
                            }
                            else
                            {
                                MessageBox.Show("Можна вибрати лише один тип вікон.");
                                e.Cancel = true;
                            }
                        }
                        else
                        {
                            Car &= 0b1111_1011;
                            window = null;
                        }
                        break;

                }
            }
        }

        private void btnDecompCar_Click(object sender, EventArgs e)
        {
            treeView1.BeforeCheck -= BeforeCheck;
            UncheckAllNodes(treeView1.Nodes);
            Car = 0;
            treeView1.BeforeCheck += BeforeCheck;
            carriage = null;
            textBox1.Text = string.Empty;
        }

        private void btn_CompCarClick(object sender, EventArgs e)
        {
            if (Car == 7)
            {
                carriage = new CompositeCarriage();
                carriage.AddComponent(wheel);
                carriage.AddComponent(body);
                carriage.AddComponent(window);

                textBox1.Text = carriage.getCarDescription();
            }
            else
            {
                MessageBox.Show("Вибрано не всі компоненти для збирання карети.");
            }
        }
    }
}
