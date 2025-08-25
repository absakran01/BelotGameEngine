namespace Belot.Engine.GameMechanics
{
    using Belot.Engine.Game;

    public class RoundResult
    {
        public RoundResult(Bid contract)
        {
            this.Contract = contract;
        }

        public Bid Contract { get; set; }

        public int SouthNorthPoints { get; set; }

        public int SouthNorthTotalInRoundPoints { get; set; }

        public int EastWestPoints { get; set; }

        public int EastWestTotalInRoundPoints { get; set; }

        public bool NoTricksForOneOfTheTeams { get; set; }

    /* COULD BE REMOVED_________________________
    violation of saudi baloot rule: no carryover points to next round
    To the total team score is added points scored from bonuses (see below). When the No Trumps game is played the points scored are doubled (except for the bonus of getting all the hands). If the team that bid the game scores more points then the opponent then the game is won by the bidders. If the points are equal then the game is declared hanging. If the bidding team does not score more points then the opponent then the game is forfeited by the bidding team.------CHANGE

When the game is won successfully both teams record their respective scores divided by 10 and rounded to a whole number (see later for the rounding rules).

When the game is forfeited the team that didn't bid records all points ( including those scored by the bidding team) divided by 10 and rounded (see later for the rounding rules).

When the game hangs the team that bid that game does not record any points but those points are left to the winner of the next game. If the next game hangs then the points accumulate for the game after that and so on!--------------REMOVE
**/
        public int HangingPoints { get; set; }
    }
}
