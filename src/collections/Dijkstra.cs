using System;
using System.Collections.Generic;
//using System.Linq;

namespace Collections
{
    public class Dijkstra {

        public Array GetShortestPath((int nodeOrigin, int nodeTarget, int value)[] nodes){

            List<int> visiteds = new List<int>();
            List<(int node, int value)> priorityList = new List<(int node, int value)>();
            int nodeOrigin = 0;
            var dists = new []{
               (node: 0, value: int.MaxValue),
               (node: 1, value: int.MaxValue),
               (node: 2, value: int.MaxValue),
               (node: 3, value: int.MaxValue),
               (node: 4, value: int.MaxValue)
            };

            //place manually the initial value in the priority list for a start
            priorityList.Add((0,0));

            while(CanContinue(dists)){
                var nextItemToProcess = GetNextNode(priorityList, visiteds.ToArray());
                visiteds.Add(nextItemToProcess.node);
                var newNodes = GetNeighbours(nodes, nextItemToProcess.node);
                foreach(var item in newNodes){
                    dists[item.nodeTarget].value = dists[nextItemToProcess.node].value + item.value;
                    priorityList.Add((item.nodeTarget,item.value));
                }
            }

            return dists;
        }

        private bool CanContinue((int node, int value)[] dists){
            bool canContinue = false;
            foreach(var item in dists){
                if(item.value == int.MaxValue){
                    canContinue = true;
                    break;
                }
            }
            return canContinue;
        }

        private List<(int nodeOrigin, int nodeTarget, int value)> GetNeighbours((int nodeOrigin, int nodeTarget,
         int value)[] nodes, int node){
             List<(int nodeOrigin, int nodeTarget, int value)> newNodes = new List<(int nodeOrigin, int nodeTarget, int value)>();   
            foreach(var item in nodes)
                if (item.nodeOrigin == node)
                    newNodes.Add((nodeOrigin: item.nodeOrigin, nodeTarget: item.nodeTarget, value: item.value));
            
            return newNodes;
        }

        private (int node, int value) GetNextNode(List<(int node, int value)> priorityList, int[] visiteds){
            int nextNode = int.MaxValue;
            int shortestPath = int.MaxValue;

            foreach(var item in priorityList){
                if (Array.IndexOf(visiteds, item.node) == -1)
                    if (item.value < shortestPath){
                        shortestPath = item.value;
                        nextNode = item.node;
                    }
            }

            return (nextNode, shortestPath);
        }
    }
}