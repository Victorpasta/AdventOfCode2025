using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Splitter
    {
        public Splitter(int x, int y) 
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }
        public long GetNumberOfDirectPathsDown(List<Splitter> splittersBelow)
        {
            long tot = 0;
            var hitSplitterToLeft = splittersBelow.FirstOrDefault(s => s.X == X - 1);
            var hitSplitterToRight = splittersBelow.FirstOrDefault(s => s.X == X + 1);
            var numberOfSplittersHit = 0;

            if (hitSplitterToLeft != null)
            {
                if (!Day7Puzzle2.Cache.TryGetValue(hitSplitterToLeft, out long nbrOfPathsInExisting))
                    tot += hitSplitterToLeft.GetNumberOfDirectPathsDown(hitSplitterToLeft.GetSplittersBelow(splittersBelow));
                else
                    tot += nbrOfPathsInExisting;
            }
            else
                numberOfSplittersHit++;
            if (hitSplitterToRight != null)
            {
                if (!Day7Puzzle2.Cache.TryGetValue(hitSplitterToRight, out long nbrOfPathsInExisting))
                    tot += hitSplitterToRight.GetNumberOfDirectPathsDown(hitSplitterToRight.GetSplittersBelow(splittersBelow));
                else
                    tot += nbrOfPathsInExisting;
            }
            else
                numberOfSplittersHit++;
            var nbrOfPaths = tot + (2 - numberOfSplittersHit);
            Day7Puzzle2.Cache.Add(this, nbrOfPaths);
            return nbrOfPaths;
        }

        public List<Splitter> GetSplittersBelow(List<Splitter> allSplitters) => allSplitters.Where(s => s.Y > Y).ToList();
    }
}
