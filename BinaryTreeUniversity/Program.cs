using System;

namespace BinaryTreeUniversity{
    class Program{
        static void Main(string[] args){
            Position rectorPosition = new Position("Rector", 1000);
            Position vicFinPosition = new Position("Vicerector Financiero", 750);
            Position contadorPosition = new Position("Contador", 500);
            Position jefeFinPosition = new Position ("Jefe Financiero", 610);
            Position secFin1Position = new Position("Secretario Financiero 1", 350);
            Position secFin2Position = new Position("Secretario Financiero 2", 310);
            Position vicAcadPosition = new Position("Vicerector Academico", 780);

            Position jefeRegPosition = new Position("Jefe de Registros", 640);
            Position secReg2Position = new Position("Secretario 2 del Jefe de Registros", 360);
            Position secReg1Position = new Position("Secretario 1 del Jefe de Registros", 400);
            Position  asist2Position = new Position("Asistente 2", 170);
            Position asist1Position = new Position("Asistente 1", 250);
            Position mensajeroPosition = new Position("Mensajero", 90);

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, jefeRegPosition,vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg2Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asist1Position, secReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asist2Position.Name);
            
            universityTree.PrintTree(universityTree.Root);
            Console.WriteLine("Total Salaries: $" + universityTree.AddSalaries(universityTree.Root));
        }
    }
}
