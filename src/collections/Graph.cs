using System;
using System.Collections.Generic;

class Graph {
    //Adjancency List
    //Undirected 
    //Unweighted

    public Dictionary<int, List<int>> Connections {get; set;}
    public int NumberOfNodes {get; set;}

    public Graph(){
      this.Connections = new Dictionary<int, List<int>>();
      this.NumberOfNodes = 0;
    }

    public void AddVertex(int node){
      this.Connections.Add(node, new List<int>());
      this.NumberOfNodes++;
    }

    public void AddEdge(int nodeFrom, int nodeTo){
      this.Connections[nodeFrom].Add(nodeTo);
      this.Connections[nodeTo].Add(nodeFrom);

    }

    public void ShowConnections(){
      Console.WriteLine("ShowConnections");

      foreach(var kvp in this.Connections){
        Console.Write($"{kvp.Key}->");
        foreach(var item in kvp.Value){
          Console.Write($"{item} ");
        }
          Console.WriteLine("");
      }

    }
}





