using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Graph
{
    public class GraphClass// create a class for a graph
    {
        public int[,] matrix;//a graph has matrix, 2d array nxn size

        public int Size;//size of an array

        public Vertex[] vertices;// the vertices of a graph. I put it in an array, separate data structure


        public GraphClass(int size)//properties of grpah class
        {
            this.Size = size;//set the size

            this.vertices = new Vertex[size];//set the size of the vertices

            this.matrix = new int[size, size];//set the size of the matrix

        }


    }
    public class Vertex// class for the vertex
    {
        public string Value;// a vertex has value
        public bool isVisited;// check if the vertex is visited or not

        public Vertex(string value)
        {
            Value = value;
            isVisited = false;//initially not visited
        }
    }

    public class GraphMethods
    {

        // I used hash functions to hashed the values in to the Vertices Array
        public void hashF(Vertex[] vertices, string vertex)//put the hashed value in the index
        {
            Vertex vertex_ = new Vertex(vertex);//get the value
            int vertexASCII = (int)Convert.ToChar(vertex);//convert the value to ASCII Code
            vertices[vertexASCII % vertices.Length] = vertex_;//put the vertex value to the hash table
        }

        public int hashFIndex(Vertex[] vertices, string vertex)//get the vertex 
        {
            int vertexASCII = (int)Convert.ToChar(vertex);//convert the value to ASCII Code
            return vertexASCII % vertices.Length;//return the index 
        }

        public GraphClass graph1 = new GraphClass(7);//size of Graph 1 is 7
        public GraphClass graph2 = new GraphClass(5);//size of Graph 2 is 7


        //Create Vertices for Graph 1
        public void CreateVertices_1()
        {

            hashF(graph1.vertices, "1");
            hashF(graph1.vertices, "2");
            hashF(graph1.vertices, "3");
            hashF(graph1.vertices, "4");
            hashF(graph1.vertices, "5");
            hashF(graph1.vertices, "6");
            hashF(graph1.vertices, "7");

        }
        //Create Vertices for Graph 2
        public void CreateVertices_2()
        {

            hashF(graph2.vertices, "A");
            hashF(graph2.vertices, "B");
            hashF(graph2.vertices, "C");
            hashF(graph2.vertices, "D");
            hashF(graph2.vertices, "E");
        }

        //method on adding edge
        public void addEdge(GraphClass graph, string From, string To)
        {
            //no need for me to loop through the matrix since I have hash table already
            graph.matrix[hashFIndex(graph.vertices, From), hashFIndex(graph.vertices, To)] = 1;
        }


        public void CreateMatrix1()
        {
            //create matrix of graph 1
            addEdge(graph1, "1", "2");//hashed the value 1 to the Vertices, so the hashed key would be 0,
                                     //then hashed the value 2 to the Vertices, so the hashed key would be 1,
                                     //put value 1 to matrix [0,1]

            addEdge(graph1, "1", "3");//hashed the value 1 to the Vertices, so the hashed key would be 0,
                                      //then hashed the value 3 to the Vertices, so the hashed key would be 2,
                                      //put value 1 to matrix [0,2]

            addEdge(graph1, "2", "4");//hashed the value 2 to the Vertices, so the hashed key would be 1,
                                      //then hashed the value 4 to the Vertices, so the hashed key would be 3,
                                      //put value 1 to matrix [1,3]

            addEdge(graph1, "3", "6");//hashed the value 3 to the Vertices, so the hashed key would be 2,
                                      //then hashed the value 6 to the Vertices, so the hashed key would be 5,
                                      //put value 1 to matrix [2,5]

            addEdge(graph1, "4", "5");//hashed the value 4 to the Vertices, so the hashed key would be 3,
                                      //then hashed the value 5 to the Vertices, so the hashed key would be 4,
                                      //put value 1 to matrix [3,4]

            addEdge(graph1, "5", "2");//hashed the value 5 to the Vertices, so the hashed key would be 4,
                                      //then hashed the value 2 to the Vertices, so the hashed key would be 1,
                                      //put value 1 to matrix [4,1]

            addEdge(graph1, "6", "4");//hashed the value 6 to the Vertices, so the hashed key would be 5,
                                      //then hashed the value 4 to the Vertices, so the hashed key would be 3,
                                      //put value 1 to matrix [5,3]

            addEdge(graph1, "6", "7");//hashed the value 6 to the Vertices, so the hashed key would be 5,
                                      //then hashed the value 7 to the Vertices, so the hashed key would be 6,
                                      //put value 1 to matrix [5,6]
        }



        public void CreateMatrix2()
        {
            //create matrix of graph 2
            addEdge(graph2, "A", "B");//hashed the value A to the Vertices, so the hashed key would be 0,
                                      //then hashed the value B to the Vertices, so the hashed key would be 1,
                                      //put value 1 to matrix [0,1]

            addEdge(graph2, "B", "E");//hashed the value B to the Vertices, so the hashed key would be 1,
                                      //then hashed the value E to the Vertices, so the hashed key would be 4,
                                      //put value 1 to matrix [1,4]

            addEdge(graph2, "E", "C");//hashed the value E to the Vertices, so the hashed key would be 4,
                                      //then hashed the value C to the Vertices, so the hashed key would be 2,
                                      //put value 1 to matrix [4,2]

            addEdge(graph2, "E", "D");//hashed the value E to the Vertices, so the hashed key would be 4,
                                      //then hashed the value D to the Vertices, so the hashed key would be 3,
                                      //put value 1 to matrix [4,3]

        }

        public void CreateGraph()//create those matrices
        {
            CreateVertices_1();
            CreateMatrix1();
            CreateVertices_2();
            CreateMatrix2();

        }

        public void printVertices(GraphClass graph)//method to print vertices of a graph
        {

            string elements = "";
            foreach (Vertex element in graph.vertices)
            {
                elements = elements +  element.Value + "  ";
            }
            MessageBox.Show(elements);
        }


        public void DisplayMatrix(GraphClass graph)//display  the matrix
        {
            if (graph == graph1)
            {
                CreateMatrix1();
            }
            if (graph == graph2)
            {
                CreateMatrix2();
            }

            string val = "";

            for (int i = 0; i < graph.Size; i++)// loop though the matrix row
            {
                for (int j = 0; j < graph.Size; j++)// loop though the matrix column
                {
                    val = val + graph.matrix[i, j].ToString() + "   ";
                }
                val = val + "\n";

            }

            MessageBox.Show(val,"Matrix");
        }

        public string print = "";


//-------------------------------------------------------------------------------------
//-------------------------DEPTH FIRST SEARCH----------------------------------------
        public void DFS_Traverse(GraphClass graph, int root, int neighbor)//DEPTH FIRST SEARCH TRAVERSAL
        {

            if (root < graph.Size)//ensure that the vertex is checking is not greater than the size of a grpah
            {
                if (graph.vertices[root].isVisited == true)//if the vertex is visited, go to next vertex
                {
                    return;
                }

                graph.vertices[root].isVisited = true;//else, visit the vertex and set the IsVisited to True
                print = print + graph.vertices[root].Value + ",";//put the vertex value in the variable for printing later
                while (graph.matrix[root, neighbor] == 0)//loop though tha columns (neighbor/adjacent) of root while its 0. If its 0, exit from while loop
                {
                    neighbor++;//increment the column

                    //when all columns are 0, meaning no adjacent vertex, exit the loop
                    if (root >= graph.Size || neighbor >= graph.Size)//if that columns is exceeding the graph size
                    {
                        break;
                    }
                }

                //when the matrix [root, neighbor] value is 1, then set that column to new root

                DFS_Traverse(graph, neighbor, 0);//traverse that new root again

                
                //If it is the end of the traversal, then backtrack

                for (int x = neighbor + 1; x < graph.Size; x++)//loop the next column
                {
                    if (graph.matrix[root, x] == 1)//if the next column is 1, then traverse again
                    {
                        DFS_Traverse(graph, x, 0);
                        break;
                    }
                    else//if 0, then loop until 1 is encountered
                    {
                        continue;
                    }
                }
                
            }
 
        }

        public void DFS_Display(GraphClass graph)//Display the DFS Traversal of a graph
        {
            DFS_Traverse(graph, 0, 0);// starts from vertex 0
            MessageBox.Show(print,"DFS Traversal");
        }
        
        //In searching vetext, I used Stack to store the value in backtracking
        public int[] Stack;//create stack
        public int Stacktail;//pointer for stack

        public void DFS_Search(GraphClass graph, int root,int neighbor, string val)
        {
            if ((root >= graph.Size))// if the root is greater than the size, return
            {
                MessageBox.Show("Cannot find vertex: " + val);
                return;
            }

            if (graph.vertices[root].Value == val)//if the value is equal to the root vertex, return
            {
                MessageBox.Show("Found vertex: " + val);
                return;
            }

            else
            {
                //push on stack
                if (graph.vertices[root].isVisited == false)
                {
                    Push(root);//push the root vertex to the stack
                    graph.vertices[root].isVisited = true;//make that vertex visited
                    
                    //get the adjacent value                  
                    while (graph.matrix[root, neighbor] == 0)
                    {
                        neighbor++;

                        if (root >= graph.Size || neighbor >= graph.Size)//if cannot find
                        {
                            break;
                        }
                    }
                    
                    //when the matrix [root, neighbor] value is 1, then set that column to new root
                    root = neighbor;
                
                    DFS_Search(graph, root, 0,val);//traverse that new root again

                }
                else if (graph.vertices[root].isVisited == true)//if visted already, back track
                {
                    neighbor = root + 1;//mov to the next adjacent vertex
                    root =Pop();// pop the top value in the stack and make it as a root

                    //back track. Traverse that root
                    while (graph.matrix[root, neighbor] == 0)
                    {
                        neighbor++;

                        if (root >= graph.Size || neighbor >= graph.Size)//if cannot find
                        {
                            break;
                        }
                    }


                    if (neighbor >= graph.Size)//no more adjacent vertex
                    {
                        neighbor = root;//save the previous adjacent                       
                        DFS_Search(graph, root, neighbor, val);// traverse again

                    }

                    else//make that adjacent vertex as the new root to traverse
                    {
                        root = neighbor;
                        DFS_Search(graph, root, 0, val);//traverse again
                    }
                                        
                }
            }

        }

        public void DFS_Search_Display(GraphClass graph, string val)
        {
            Stack = new int[graph.Size];//create the stack
            Stacktail = 0;//set the tail to 0 where can insert the vertex
            DFS_Search(graph, 0,0, val);//start from 0 index
            
        }
        public void Push(int val)
        {
            //get the index

           Stack[Stacktail] = val;

            Stacktail++; // INCREASE THE STACK BY ADD. MEANING THIS IS THE NEXT AVAILABLE STACK

        }

        public int Pop()//REMOVE NOTEBOOK OWNER ON TOP OF THE STACK
        {

            if (Stacktail == 0)//IF NOTHING TO REMOVE
            {
                MessageBox.Show("Stack Underflow. Nothing to check from the stack.");
            }

            else//check the notebook from the top
            {
                Stacktail = Stacktail - 1; //decrement the pointer             
            }
            return Stack[Stacktail];
        }

//-------------------------------------------------------------------------------------
//-------------------------BREADTH FIRST SEARCH----------------------------------------
        public int[] Queue_;// Use que for back tracking 
        public int Qtail=0;
        public int Qhead=0;

        public void BFS_Traverse(GraphClass graph, int root)
        {
                        
            //explore root
            for (int i=0; i<graph.Size; i++)
            {
                if (graph.matrix[root, i] == 1 && graph.vertices[i].isVisited == false)//if the node is not visited and the value is 1
                {
                    Enque(i);//put the vertex in the queue. put it in the last 
                    graph.vertices[i].isVisited = true;//set that vertex to true
                }
            }

            Qhead = Qhead + 1;//increment the pointer to be traversed

            if (Qtail <= Qhead)//this is the termination code. When head pointer is already pointing to tail. meaning all nodes are visited
            {
                return;
            }

            root = Deque();//get the first value of the Queue ans set to new root

            BFS_Traverse(graph, root);//traverse that root

          

        }


        public void BFS_Display(GraphClass graph)
        {
            Queue_ = new int[graph.Size];//set the size of the Q to the size of the graph
            Enque(0);//start from 0 index
            graph.vertices[0].isVisited = true;//set that vertex to visited
            BFS_Traverse(graph, 0);//traverse the vertex 0
            PrintQueue(graph);// print all the values after traversal


        }

        public void PrintQueue(GraphClass graph)//traverse the values in the queue
        {
            string str = "";

            foreach (int element in Queue_)
            {

                str = str + graph.vertices[element].Value + ",";
            }
            MessageBox.Show(str, "DFS Traversal");
        }

        public void BFS_Search(GraphClass graph, int root,string val)//this is similar to BFS_Traverse method
        {
            //explore root

            if (graph.vertices[root].Value == val)//if the value is equal to the root vertex, return
            {
                MessageBox.Show("Found vertex: " + val);
                return;
            }


            for (int i = 0; i < graph.Size; i++)
            {
                if (graph.matrix[root, i] == 1 && graph.vertices[i].isVisited == false)//if the node is not visited and the value is 1
                {
                    Enque(i);//put the vertex in the queue. put it in the last 
                    graph.vertices[i].isVisited = true;//set that vertex to true
                }
            }

            Qhead = Qhead + 1;//increment the pointer to be traversed

            if (Qtail <= Qhead)//this is the termination code. When head pointer is already pointing to tail. 
                              //meaning all nodes are visited and cannot find the value
            {
                MessageBox.Show("Cannot find vertex: " + val);
                return;
            }

            root = Deque();//get the first value of the Queue ans set to new root

            BFS_Search(graph, root,val);//traverse again the root

        }


        public void BFS_Search_Display(GraphClass graph, string val)
        {
            Queue_ = new int[graph.Size];//set the size of the Q to the size of the graph
            Enque(0);//start from 0 index
            graph.vertices[0].isVisited = true;//set that vertex to visited

            BFS_Search(graph, 0,val);//traverse the vertex 0
        }
        public void Enque(int val)//enque the vertex
        {
            Queue_[Qtail] = val;

            Qtail = Qtail + 1;
        }

        public int Deque()//degque the vertex
        {
            int val;

            val = Queue_[Qhead];//get the index of the first in the queue

            return val;
        }
    }
}
