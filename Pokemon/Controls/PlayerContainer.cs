using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon.Controls
{
    public partial class PlayerContainer : UserControl
    {
        private const int Players = 8;
        private const int Rounds = 8;

        private int CurrentRound;
        private int CurrentPlayer;

        public List<PlayerGame> GameData = new List<PlayerGame>();

        public delegate void GameDataUpdated(List<PlayerGame> gameData);

        public event GameDataUpdated Updated;

        private List<Player> PlayersList;

        public PlayerContainer()
        {
            InitializeComponent();
            PlayersList= pnlPlayers.Controls.OfType<Player>().ToList();
            InitData();
            CurrentPlayer = 1;
            CurrentRound = 0;
        }

        public void InitData()
        {
            GameData.Clear();
            foreach (var player in PlayersList)
            {
                var d = new PlayerGame() { Index = player.AccessibleName, Name = "Player " + player.AccessibleName };
                player.LoadData(d);
                GameData.Add(d);
                player.Updated -= PlayerOnUpdated;
                player.Updated += PlayerOnUpdated;
            }

            CurrentPlayer = 1;
            CurrentRound = 0;
            CurrentOrder = Order.Increasing;
            Skip = false;
            IsTurned = true;
        }

        public GameStatus CurrentGameStatus
        {
            get => new GameStatus(){CurrentPlayer = CurrentPlayer,CurrentOrder = CurrentOrder, CurrentRound = CurrentRound, IsTurned = IsTurned, Skip = Skip};
            set
            {
                CurrentPlayer = value.CurrentPlayer;
                CurrentOrder = value.CurrentOrder;
                CurrentRound = value.CurrentRound;
                Skip = value.Skip;
                IsTurned = value.IsTurned;
            }
        }

        public class GameStatus
        {
            public int CurrentPlayer { get; set; } = 1;
            public int CurrentRound { get; set; } = 0;
            public Order CurrentOrder { get; set; } = Order.Increasing;
            public bool IsTurned { get; set; } = true;
            public bool Skip { get; set; } = false;
        }

        private bool Skip;

        public Order CurrentOrder ;

        private bool IsTurned;

        public bool PokemonSelected(string path)
        {
            var player = PlayersList.FirstOrDefault(x => x.GameData.Index.Equals(CurrentPlayer + ""));

            if (player == null)
                return false;


            if (CurrentPlayer == 1 && CurrentRound == 7)
            {
                MessageBox.Show("Game Over!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }


            player.UpdateRound(CurrentRound == 0 ? "Ban" : CurrentRound + "", path);

            if (CurrentPlayer == 8 && CurrentRound == 0)
            {
                CurrentPlayer = 1;
                CurrentRound = 1;
                Skip = true;
                IsTurned = true;
            }

            if (!Skip)
            {
                if (CurrentPlayer == 1 && !IsTurned)
                {
                    CurrentRound++;
                    IsTurned = true;
                }
                else if (CurrentPlayer == 1 && IsTurned)
                {
                    CurrentPlayer++;
                    IsTurned = false;
                    CurrentOrder = Order.Increasing;
                }
                else if (CurrentPlayer == Players && !IsTurned)
                {
                    CurrentRound++;
                    IsTurned = true;
                }
                else if (CurrentPlayer == Players && IsTurned)
                {
                    CurrentPlayer--;
                    CurrentOrder = Order.Decreasing;
                    IsTurned = false;
                }
                else if (CurrentOrder == Order.Increasing)
                {
                    CurrentPlayer++;
                }
                else
                {
                    CurrentPlayer--;
                }
            }
            else
            {
                Skip = false;
            }

            return true;
        }

        public enum Order
        {
            Increasing,
            Decreasing
        }


        public Status GetStatus()
        {

            var ctrl = PlayersList.FirstOrDefault(x => x.GameData.Index.Equals(CurrentPlayer + ""));

            return new Status(){Round = CurrentRound == 0 ? "Ban" : CurrentRound + "", Turn = ctrl.GameData.Name};
        }

        public class Status
        {
            public string Turn { get; set; }
            public string Round { get; set; }
        }

        private void PlayerOnUpdated(PlayerGame gamedata)
        {
            var c = GameData.FirstOrDefault(x => x.Index.Equals(gamedata.Index));

            c.Name = gamedata.Name;
            c.Pokemons= gamedata.Pokemons;

            Updated?.Invoke(GameData);
        }

        public void LoadPreviousGame(List<PlayerGame> game)
        {
            GameData = game;
            var ctrls = pnlPlayers.Controls.OfType<Player>();

            foreach (var ctrl in ctrls)
            {
                ctrl.LoadData(game.First(x=>x.Index.Equals(ctrl.AccessibleName)));
            }
        }
    }
}
