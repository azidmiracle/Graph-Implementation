namespace Graph
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenu = new System.Windows.Forms.Button();
            this.cmbGraph = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTraversal = new System.Windows.Forms.ComboBox();
            this.txtVertex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.btnDisplayVert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(77, 70);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(121, 23);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Display Visited Nodes";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // cmbGraph
            // 
            this.cmbGraph.FormattingEnabled = true;
            this.cmbGraph.Items.AddRange(new object[] {
            "Graph 1",
            "Graph 2"});
            this.cmbGraph.Location = new System.Drawing.Point(77, 12);
            this.cmbGraph.Name = "cmbGraph";
            this.cmbGraph.Size = new System.Drawing.Size(121, 21);
            this.cmbGraph.TabIndex = 1;
            this.cmbGraph.SelectedIndexChanged += new System.EventHandler(this.cmbGraph_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Graph";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Traversal";
            // 
            // cmbTraversal
            // 
            this.cmbTraversal.FormattingEnabled = true;
            this.cmbTraversal.Items.AddRange(new object[] {
            "BFS",
            "DFS"});
            this.cmbTraversal.Location = new System.Drawing.Point(77, 43);
            this.cmbTraversal.Name = "cmbTraversal";
            this.cmbTraversal.Size = new System.Drawing.Size(121, 21);
            this.cmbTraversal.TabIndex = 4;
            // 
            // txtVertex
            // 
            this.txtVertex.Location = new System.Drawing.Point(77, 183);
            this.txtVertex.Name = "txtVertex";
            this.txtVertex.Size = new System.Drawing.Size(52, 20);
            this.txtVertex.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vertex";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(135, 180);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMatrix
            // 
            this.btnMatrix.Location = new System.Drawing.Point(77, 99);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(121, 23);
            this.btnMatrix.TabIndex = 8;
            this.btnMatrix.Text = "Display Matrix";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // btnDisplayVert
            // 
            this.btnDisplayVert.Location = new System.Drawing.Point(77, 128);
            this.btnDisplayVert.Name = "btnDisplayVert";
            this.btnDisplayVert.Size = new System.Drawing.Size(121, 23);
            this.btnDisplayVert.TabIndex = 9;
            this.btnDisplayVert.Text = "Display Vertices";
            this.btnDisplayVert.UseVisualStyleBackColor = true;
            this.btnDisplayVert.Click += new System.EventHandler(this.btnDisplayVert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(218, 221);
            this.Controls.Add(this.btnDisplayVert);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVertex);
            this.Controls.Add(this.cmbTraversal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGraph);
            this.Controls.Add(this.btnMenu);
            this.Name = "Form1";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTraversal;
        private System.Windows.Forms.TextBox txtVertex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ComboBox cmbGraph;
        public System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.Button btnMatrix;
        public System.Windows.Forms.Button btnDisplayVert;
    }
}

