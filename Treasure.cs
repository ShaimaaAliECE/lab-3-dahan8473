using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        private int Score;
        public Treasure(string Description, int Score) : base(Description)
        {
            this.Score = Score;
        }
        public void UpdateTotalScore()
        {
            Board.TotalScore += this.Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }
        public override void AddMe(List<Collectable> collected)
        {
            base.AddMe(collected);
            UpdateTotalScore();
        }
            
    }
}
