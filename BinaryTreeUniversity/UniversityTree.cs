using System;
namespace BinaryTreeUniversity{
    class UniversityTree{
        public PositionNode Root;

        public void CreatePosition(PositionNode parent, 
                                    Position positionToCreate, 
                                    string parentPositionName){
            

            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;
            if (Root == null){
                Root = newNode;
                return;
            }
            if (parent == null){
                return;
            }
            if (parent.Position.Name == parentPositionName){
                if (parent.left == null){
                    parent.left = newNode;
                    return;
                }
                parent.right = newNode;
                return;
            }
            CreatePosition(parent.left, positionToCreate, parentPositionName);
            CreatePosition(parent.right, positionToCreate, parentPositionName);
        }

        public void PrintTree(PositionNode from){
            if (from == null)
            {
                return;
            }
            Console.WriteLine($"{from.Position.Name} : {from.Position.Salary}");
            PrintTree(from.left);
            PrintTree(from.right);
        }

        public float AddSalaries(PositionNode from){
            if(from == null){
                return 0;
            }
            return from.Position.Salary + AddSalaries(from.left) + AddSalaries(from.right);
        }
    }
}
