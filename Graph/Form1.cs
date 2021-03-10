using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Graph
{
    public partial class Form1 : Form
    {
        public GraphMethods graph;

        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnMenu_Click(object sender, EventArgs e)//for display visited nodes
        {
            

            if (cmbTraversal.Text=="" || cmbGraph.Text == "")//check if dropdown are blank
            {
                MessageBox.Show("Don't leave the form blank.");
            }

            else
            {
                graph = new GraphMethods();
                graph.CreateGraph();

                //if user selected Graph 1 and DFS Traversal, call the DFS_Display method 
                if (cmbTraversal.Text == "DFS" && cmbGraph.Text == "Graph 1")
                {
                    graph.DFS_Display(graph.graph1);
                }
                //if user selected Graph 2 and DFS Traversal, call the DFS_Display method 
                else if (cmbTraversal.Text == "DFS" && cmbGraph.Text == "Graph 2")
                {
                    graph.DFS_Display(graph.graph2);
                }
                //if user selected Graph 1 and BFS Traversal, call the BFS_Display method 
                else if (cmbTraversal.Text == "BFS" && cmbGraph.Text == "Graph 1")
                {
                    graph.BFS_Display(graph.graph1);
                }
                //if user selected Graph 2 and BFS Traversal, call the BFS_Display method 
                else if (cmbTraversal.Text == "BFS" && cmbGraph.Text == "Graph 2")
                {
                    graph.BFS_Display(graph.graph2);

                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)//for search method
        {

            if (cmbTraversal.Text == "" || cmbGraph.Text == "" || txtVertex.Text=="")//check if textbox or dropdown are blank
            {
                MessageBox.Show("Don't leave the form blank.");
            }

            else
            {
                graph = new GraphMethods();//if not blank thin load the graph
                graph.CreateGraph();

                string searchVal = txtVertex.Text;//put the value of the textbox to the variable

                if (cmbTraversal.Text == "DFS" && cmbGraph.Text == "Graph 1")//if user selected Graph 1 and DFS Traversal, call the DFS_Search_Display method 
                {
                    graph.DFS_Search_Display(graph.graph1, searchVal);
                }

                else if (cmbTraversal.Text == "DFS" && cmbGraph.Text == "Graph 2")//if user selected Graph 2 and DFS Traversal, call the DFS_Search_Display method 
                {
                    graph.DFS_Search_Display(graph.graph2, searchVal);
                }

                else if (cmbTraversal.Text == "BFS" && cmbGraph.Text == "Graph 1")//if user selected Graph 1 and BFS Traversal, call the BFS_Search_Display method 
                {
                    graph.BFS_Search_Display(graph.graph1, searchVal);
                }

                else if (cmbTraversal.Text == "BFS" && cmbGraph.Text == "Graph 2")//if user selected Graph 2 and BFS Traversal, call the BFS_Search_Display method 
                {
                    graph.BFS_Search_Display(graph.graph2, searchVal);

                }
            }

 
        }


        private void btnMatrix_Click(object sender, EventArgs e)// display the matrix of a given graph
        {

            if ( cmbGraph.Text == "")//check if textbox or dropdown are blank
            {
                MessageBox.Show("Don't leave the form blank.");
                return;
            }

            if (cmbGraph.Text == "Graph 1")//Didsplay the matrix of Graph 1 for checking purposes only
            {
                graph.DisplayMatrix(graph.graph1);
            }

            else if (cmbGraph.Text == "Graph 2")//Didsplay the matrix of Graph 2 for checking purposes only
            {
                graph.DisplayMatrix(graph.graph2);
            }
        }

        private void cmbGraph_SelectedIndexChanged_1(object sender, EventArgs e)//select which graph to traverse
        {
            graph = new GraphMethods();// bind he graph
            graph.CreateGraph();

            if (cmbGraph.Text == "Graph 1")//if graph 1 is selected, value for the traversal is DFS
            {
                //
                cmbTraversal.Text = "DFS";
            }

            else//if graph 1 is selected, value for the traversal is BFS
            {
                cmbTraversal.Text = "BFS";
            }
        }

        private void btnDisplayVert_Click(object sender, EventArgs e)// display the verices of a given graph
        {
            graph = new GraphMethods();// bind he graph
            graph.CreateGraph();

            if (cmbGraph.Text == "")//check if textbox or dropdown are blank
            {
                MessageBox.Show("Don't leave the form blank.");
                return;
            }

            if (cmbGraph.Text == "Graph 1")//Didsplay the matrix of Graph 1 for checking purposes only
            {
                graph.printVertices(graph.graph1);
            }

            else if (cmbGraph.Text == "Graph 2")//Didsplay the matrix of Graph 2 for checking purposes only
            {
                graph.printVertices(graph.graph2);
            }
        }
    }
}
   