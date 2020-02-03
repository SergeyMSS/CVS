using System;
using System.Collections.Generic;

namespace Clones
{
    public class Clone
    {
        public LinkedList<int> Skills = new LinkedList<int>();
        public LinkedList<int> RollBack = new LinkedList<int>();

        public void SkillsLearn(int programmIndex)
        {
            Skills.AddLast(programmIndex);
        }

        public void RollBackMethod()
        {
            RollBack.AddLast(Skills.Last.Value);
            Skills.RemoveLast();
        }

        public void RelearnMethod()
        {
            Skills.AddLast(RollBack.Last.Value);
        }
    }
    public class CloneVersionSystem : ICloneVersionSystem
    {
        List<Clone> clonesList = new List<Clone>();
        Clone clone = new Clone();
        public string Execute(string query)
        {
            string command = DecoderCommand(query);
            int cloneIndex = DecoderCommandCI(query);
            int programmIndex = DecoderCommandPI(query);

            if (clonesList.Count < cloneIndex)
            {
                clonesList.Add(clone);
            }

            switch (command)
            {
                case "learn":
                    clonesList[cloneIndex - 1].SkillsLearn(programmIndex);
                    break;
                case "rollback":
                    clonesList[cloneIndex - 1].RollBackMethod();
                    break;
                case "relearn":
                    clonesList[cloneIndex - 1].RelearnMethod();
                    break;
                case "clone":
                    Clone newClone = new Clone();
                    if (clonesList[cloneIndex - 1].Skills.Count != 0)
                        newClone.Skills.AddLast(clonesList[cloneIndex - 1].Skills.Last.Value);
                    if (clonesList[cloneIndex - 1].RollBack.Count != 0)
                        newClone.RollBack.AddLast(clonesList[cloneIndex - 1].RollBack.Last.Value);
                    clonesList.Add(newClone);
                    break;
                case "check":
                    if (clonesList[cloneIndex - 1].Skills.Count == 0)
                        return "basic";
                    else
                    {
                        return clonesList[cloneIndex - 1].Skills.Last.Value.ToString();
                    }
            }

            return null;
        }

        public string DecoderCommand(string query)
        {
            string[] comArr = query.Split(' ');
            return comArr[0];
        }

        public int DecoderCommandCI(string query)
        {
            string[] comArr = query.Split(' ');
            return int.Parse(comArr[1]);
        }

        public int DecoderCommandPI(string query)
        {
            string[] comArr = query.Split(' ');
            if (comArr.Length == 3)
                return int.Parse(comArr[2]);
            return 0;
        }
    }
}
