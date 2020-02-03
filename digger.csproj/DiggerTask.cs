using System.Collections.Generic;
using System.Windows.Forms;

namespace Digger
{
    //Напишите здесь классы Player, Terrain и другие.
    class Terrain : ICreature
    {
        public string GetImageFileName()
        {
            return "Terrain.png";
        }

        public int GetDrawingPriority()
        {
            return 3;
        }

        public bool DeadInConflict(ICreature conflictObject)
        {
            return true;
        }

        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand()
            {
                DeltaX = 0,
                DeltaY = 0,
            };
        }
    }

    class Player : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            var command = new CreatureCommand();

            if (Game.KeyPressed == Keys.Right && x + 1 < Game.MapWidth)
                command.DeltaX = 1;
            else if (Game.KeyPressed == Keys.Left && x - 1 >= 0)
                command.DeltaX = -1;
            else if (Game.KeyPressed == Keys.Up && y - 1 >= 0)
                command.DeltaY = -1;
            else if (Game.KeyPressed == Keys.Down && y + 1 < Game.MapHeight)
                command.DeltaY = 1;
            return command;
        }

        public string GetImageFileName()
        {
            return "Digger.png";
        }

        public int GetDrawingPriority()
        {
            return 0;
        }

        public void ScoreCount()
        {
            Game.Scores += 10;
        }
        public bool DeadInConflict(ICreature conflictObject)
        {
            if (conflictObject is Sack)
                return true;
            else if (conflictObject is Gold)
            {
                ScoreCount();
                return false;
            }
            return false;
        }
    }

    class Sack : ICreature
    {

        // Сделайте класс Sack, реализовав ICreature. Это будет мешок с золотом.
        // Мешок может лежать на любой другой сущности(диггер, земля, мешок, золото, край карты).
        // Если под мешком находится пустое место, он начинает падать.
        // Если мешок падает на диггера, диггер умирает, а мешок продолжает падать, пока не приземлится на землю, другой мешок, золото или край карты.
        // Диггер не может подобрать мешок, толкнуть его или пройти по нему.
        // Если мешок падает, а диггер находится непосредственно под ним и идет вверх, они могут "разминуться", и диггер окажется над мешком.Это поведение непросто исправить в существующей упрощенной архитектуре, поэтому считайте его нормальным.

        public static Dictionary<int, int> transform = new Dictionary<int, int>();

        public string GetImageFileName()
        {
            return "Sack.png";
        }

        public int GetDrawingPriority()
        {
            return 2;
        }

        static CreatureCommand Lay(int x)
        {
            //transform.Remove(x);
            return new CreatureCommand
            {
                DeltaX = 0,
                DeltaY = 0,
            };
        }

        static CreatureCommand Fall()
        {
            return new CreatureCommand
            {
                DeltaX = 0,
                DeltaY = 1,
            };
        }

        static CreatureCommand Break(int x)
        {
            transform.Remove(x);
            return new CreatureCommand()
            {
                DeltaX = 0,
                DeltaY = 0,
                TransformTo = new Gold()
            };
        }

        public bool TransformationMethod(int x)
        {
            if (!transform.ContainsKey(x))
            {
                transform.Add(x, 0);
                return false;
            }
            else
            {
                transform.TryGetValue(x, out int value);
                if (value > 1)
                    return true;
                else
                    return false;
            }
        }
        public CreatureCommand Act(int x, int y)
        {
            bool convert = TransformationMethod(x);

            if (y + 1 < Game.MapHeight)
            {
                var field = Game.Map[x, y + 1];

                if (field == null)
                {
                    transform[x]++;
                    return Fall();
                }
                else if (field != null && convert)
                {
                    return Break(x);
                }
            }
            else if (y + 1 == Game.MapHeight && convert)
            {
                return Break(x);
            }
            //transform.Remove(x);
            return Lay(x);
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return false;
        }
    }

    class Gold : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand
            {
                DeltaX = 0,
                DeltaY = 0,
            };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return true;
        }

        public int GetDrawingPriority()
        {
            return 1;
        }

        public string GetImageFileName()
        {
            return "Gold.png";
        }
    }
}
