using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public static class Day8Puzzle1
    {
        public static List<Circuit> Circuits = [];
        public static long Run(string path, int nbrOfIterations, bool runningPuzzle1 = true)
        {
            var junctionBoxes = CreateJunctionBoxesService.CreateJunctionBoxes(path);
            foreach (var junctionBox in junctionBoxes)
                junctionBox.OrderBoxes(junctionBoxes);
            int i = 0;
            double x1 = 0;
            double x2 = 0;
            
            while(Circuits.Count() < 1 || junctionBoxes.Any(jb => !Circuits.First().ConnectedBoxes.Contains(jb)))
            {
                if(i == nbrOfIterations && runningPuzzle1)
                    break;
                i++;
                List<JunctionBox> sortedJunctionBoxes = junctionBoxes.OrderBy(jb => jb.SortedBoxesAndDistance[0].Distance)
                .ToList();
                var junctionBox = sortedJunctionBoxes[0];
                var closest = junctionBox.SortedBoxesAndDistance[0].Box;
                if (!Circuits.Any(c => c.ConnectedBoxes.Contains(junctionBox)))
                {
                    var newCircuit = new Circuit();
                    newCircuit.ConnectedBoxes.Add(junctionBox);
                    Circuits.Add(newCircuit);
                }
                if (!Circuits.Any(c => c.ConnectedBoxes.Contains(closest)))
                {
                    var newCircuit = new Circuit();
                    newCircuit.ConnectedBoxes.Add(closest);
                    Circuits.Add(newCircuit);
                }
                var circuitForBox1 = Circuits.First(c => c.ConnectedBoxes.Contains(junctionBox));
                var circuitForBox2 = Circuits.First(c => c.ConnectedBoxes.Contains(closest));
                if (circuitForBox1 == circuitForBox2)
                {
                    junctionBox.SortedBoxesAndDistance.RemoveAt(0);
                    if (closest.SortedBoxesAndDistance[0].Box == junctionBox)
                        closest.SortedBoxesAndDistance.RemoveAt(0);
                    continue;
                }
                x1 = closest.X;
                x2 = junctionBox.X;
                MergeCircuits(circuitForBox1, circuitForBox2);
                junctionBox.SortedBoxesAndDistance.RemoveAt(0);
                if (closest.SortedBoxesAndDistance[0].Box == junctionBox)
                    closest.SortedBoxesAndDistance.RemoveAt(0);

            }
            if (runningPuzzle1)
                return CalculateTotalPuzzle1();
            return (long)x1 * (long)x2;
            
        }
        public static long CalculateTotalPuzzle1()
        {
            var tot = 1;
            Circuits = Circuits.OrderBy(c => c.ConnectedBoxes.Count())
                .ToList();
            for (int n = 0; n < 3; n++)
            {
                var largestCircuit = Circuits[0];
                foreach (var circuit in Circuits)
                {
                    if (circuit.ConnectedBoxes.Count() > largestCircuit.ConnectedBoxes.Count())
                        largestCircuit = circuit;
                }
                tot *= largestCircuit.ConnectedBoxes.Count();
                Circuits.Remove(largestCircuit);

            }
            return tot;

        }

        public static void MergeCircuits(Circuit circuit1, Circuit circuit2)
        {
            circuit1.ConnectedBoxes.AddRange(circuit2.ConnectedBoxes);
            Circuits.Remove(circuit2);
        }
    }
}
