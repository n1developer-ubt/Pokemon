using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Pokemon.Controls
{
    public partial class PlayerContainer : UserControl
    {
        private const int Players = 8;

        private int CurrentRound;
        private int CurrentPlayer;

        public List<PlayerGame> GameData = new List<PlayerGame>();

        public delegate void GameDataUpdated(List<PlayerGame> gameData);
        public delegate void GameStatusUpdated(GameStatus gameStatus);

        public event GameDataUpdated Updated;
        public event GameStatusUpdated StatusUpdated;

        private List<Player> PlayersList;

        public PlayerContainer()
        {
            InitializeComponent();
            PlayersList= pnlPlayers.Controls.OfType<Player>().ToList();
            InitData();
            CurrentPlayer = 1;
            CurrentRound = 0;
        }

        private readonly Stack<GameStatus> UndoStack = new Stack<GameStatus>();
        private readonly Stack<GameStatus> RedoStack = new Stack<GameStatus>();

        public void Undo()
        {
            if (UndoStack.Count == 0)
                return;

            var preStatus = UndoStack.Pop();
            RedoStack.Push(preStatus);
            CurrentGameStatus = preStatus;
            PokemonSelected(new PokemonImageType(){PokemonType = PokemonType.None,Image = ""}, true);
            CurrentGameStatus = preStatus;

            StatusUpdated?.Invoke(CurrentGameStatus);
        }

        public void Redo()
        {
            if(RedoStack.Count == 0)
                return;

            var postStatus = RedoStack.Pop();
            UndoStack.Push(postStatus);
            //event
            CurrentGameStatus = postStatus;
            PokemonSelected(postStatus.ImageType,true);
            StatusUpdated?.Invoke(CurrentGameStatus);
        }

        private void AddItem()
        {
            UndoStack.Push(CurrentGameStatus);
            RedoStack.Clear();
        }

        public void InitData()
        {
            RedoStack.Clear();
            UndoStack.Clear();
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
            _skip = false;
            _isTurned = true;
        }

        public GameStatus CurrentGameStatus
        {
            get => new GameStatus(){CurrentPlayer = CurrentPlayer,CurrentOrder = CurrentOrder, CurrentRound = CurrentRound, IsTurned = _isTurned, Skip = _skip, ImageType =CurrentPokemonImageType };
            set
            {
                CurrentPlayer = value.CurrentPlayer;
                CurrentOrder = value.CurrentOrder;
                CurrentRound = value.CurrentRound;
                _skip = value.Skip;
                _isTurned = value.IsTurned;
                CurrentPokemonImageType = value.ImageType;
            }
        }

        public PokemonImageType CurrentPokemonImageType { get; set; }

        public class GameStatus
        {
            public int CurrentPlayer { get; set; } = 1;
            public int CurrentRound { get; set; } = 0;
            public Order CurrentOrder { get; set; } = Order.Increasing;
            public bool IsTurned { get; set; } = true;
            public bool Skip { get; set; } = false;
            public PokemonImageType ImageType { get; set; }
        }

        private bool _skip, _isTurned;

        public Order CurrentOrder ;

        public bool PokemonSelected(PokemonImageType imageType, bool isUndo = false)
        {
            var player = PlayersList.FirstOrDefault(x => x.GameData.Index.Equals(CurrentPlayer + ""));

            if (player == null)
                return false;

            if (CurrentPlayer == 1 && CurrentRound == 7 && !isUndo)
            {
                MessageBox.Show("Game Over!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            player.UpdateRound(CurrentRound == 0 ? "Ban" : CurrentRound + "", imageType);

            CurrentPokemonImageType = imageType;

            if(!isUndo)
                AddItem();

            if (CurrentPlayer == 8 && CurrentRound == 0)
            {
                CurrentPlayer = 1;
                CurrentRound = 1;
                _skip = true;
                _isTurned = true;
            }

            if (!_skip)
            {
                if (CurrentPlayer == 1 && !_isTurned)
                {
                    CurrentRound++;
                    _isTurned = true;
                }
                else if (CurrentPlayer == 1 && _isTurned)
                {
                    CurrentPlayer++;
                    _isTurned = false;
                    CurrentOrder = Order.Increasing;
                }
                else if (CurrentPlayer == Players && !_isTurned)
                {
                    CurrentRound++;
                    _isTurned = true;
                }
                else if (CurrentPlayer == Players && _isTurned)
                {
                    CurrentPlayer--;
                    CurrentOrder = Order.Decreasing;
                    _isTurned = false;
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
                _skip = false;
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
